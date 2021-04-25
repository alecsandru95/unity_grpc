using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ServerSession : ISession
{
	private Server _Server;

	public override string GetIP()
	{
		try
		{
			return $"{_Server.Ports.FirstOrDefault().Host}:{_Server.Ports.FirstOrDefault().BoundPort}";
		}
		catch(Exception exception)
		{
			Debug.LogError(exception.Message);

			return string.Empty;
		}
	}

	public void StartServer()
	{
		if(_Server != null)
		{
			return;
		}

		try
		{
			_Server = new Server
			{
				Services = { HelloService.BindService(new HelloServiceImpl()) },
				Ports = { new ServerPort("localhost", 0, ServerCredentials.Insecure) }
			};
			_Server.Start();

			DontDestroyOnLoad(gameObject);
			SceneManager.LoadScene("PlayScene");

			Debug.Log($"Server started on port : {_Server.Ports.FirstOrDefault().BoundPort}");
		}
		catch(Exception exception)
		{
			Debug.LogError(exception.Message);
			_Server = null;
		}
	}
}
