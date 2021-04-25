#if UNITY_EDITOR

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UnityEditor;

using Debug = UnityEngine.Debug;

public static class GrpcHelper
{
	[MenuItem("gRPC/Build proto files")]
	private static void BuildProtoFiles()
	{
		Debug.Log("BuildProtoFiles");
		try
		{
			var protoExe = Path.GetFullPath("Assets/Plugins/Grpc.Tools/protoc.exe");
			var grpcPluginExe = Path.GetFullPath("Assets/Plugins/Grpc.Tools/grpc_csharp_plugin.exe");

			if (File.Exists(protoExe) == false || File.Exists(grpcPluginExe) == false)
			{
				Debug.LogError($"Grpc Tool is missing, check [{protoExe}] and {grpcPluginExe}");
				return;
			}

			var protoFileExtension = ".proto";

			var protoFiles = Directory
					.EnumerateFiles("Assets/", "*.*", SearchOption.AllDirectories)
					.Where(f => Path.GetExtension(f).ToLowerInvariant().Equals(protoFileExtension)).Select(p => Path.GetFullPath(p));

			foreach (var protoFile in protoFiles)
			{
				var protoFileName = Path.GetFileName(protoFile);
				Debug.Log($"Compiling protofile : {protoFileName}");

				var directory = Path.GetDirectoryName(protoFile);

				var arguments = $"/K {protoExe} -I {directory} --plugin=protoc-gen-grpc={grpcPluginExe} --csharp_out={directory} --grpc_out={directory} {protoFile}";

				var processStartInfo = new ProcessStartInfo()
				{
					FileName = "cmd.exe",
					UseShellExecute = false,
					Arguments = arguments,
					RedirectStandardOutput = true,
					CreateNoWindow = false
				};
				var rezultProcess = Process.Start(processStartInfo);

				var rezult = rezultProcess.StandardOutput.ReadToEnd();
				rezultProcess.WaitForExit();
			}
		}
		catch (Exception exception)
		{
			Debug.LogError(exception.Message);
		}
	}
}

#endif