
using Grpc.Core;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Server implementation
/// </summary>
public class HelloServiceImpl : HelloService.HelloServiceBase
{
	public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
	{
		Debug.Log($"Got : {request.Message}");

		var helloReply = new HelloReply
		{
			Message = "Hello back"
		};

		return Task.FromResult(helloReply);
	}
}
