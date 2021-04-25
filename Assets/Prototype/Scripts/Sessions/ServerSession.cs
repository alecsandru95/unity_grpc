using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ServerSession : MonoBehaviour
{
	private Server _Server;

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

			Debug.Log($"Server started on port : {_Server.Ports.FirstOrDefault().BoundPort}");
		}
		catch(Exception exception)
		{
			Debug.LogError(exception.Message);
			_Server = null;
		}
	}
}
