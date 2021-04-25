using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSession : MonoBehaviour
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

			Debug.Log($"reply from server : {helloReply.Message}");
		}
		catch (Exception exception)
		{
			Debug.Log(exception.Message);
		}
	}
}
