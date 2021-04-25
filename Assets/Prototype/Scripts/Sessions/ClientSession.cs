using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class connects to the server
/// </summary>
public class ClientSession : ISession
{
	private Channel _Channel;


	private HelloService.HelloServiceClient _HelloServiceClient;

	public void Connect(string serverIP)
	{
		try
		{
			_Channel = new Channel($"{serverIP}", ChannelCredentials.Insecure);

			_HelloServiceClient = new HelloService.HelloServiceClient(_Channel);

			var helloReply = _HelloServiceClient.SayHello(new HelloRequest { Message = "Hello server!" });

			DontDestroyOnLoad(gameObject);
			SceneManager.LoadScene("PlayScene");

			Debug.Log($"reply from server : {helloReply.Message}");
		}
		catch (Exception exception)
		{
			Debug.Log(exception.Message);
		}
	}

	public override string GetIP()
	{
		try
		{
			return _Channel.ResolvedTarget;
		}
		catch (Exception exception)
		{
			Debug.LogError(exception.Message);

			return string.Empty;
		}
	}
}
