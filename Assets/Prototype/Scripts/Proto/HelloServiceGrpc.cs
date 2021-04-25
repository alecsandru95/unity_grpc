// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HelloService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class HelloService
{
  static readonly string __ServiceName = "HelloService";

  static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (message is global::Google.Protobuf.IBufferMessage)
    {
      context.SetPayloadLength(message.CalculateSize());
      global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
      context.Complete();
      return;
    }
    #endif
    context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
  }

  static class __Helper_MessageCache<T>
  {
    public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
  }

  static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (__Helper_MessageCache<T>.IsBufferMessage)
    {
      return parser.ParseFrom(context.PayloadAsReadOnlySequence());
    }
    #endif
    return parser.ParseFrom(context.PayloadAsNewBuffer());
  }

  static readonly grpc::Marshaller<global::HelloRequest> __Marshaller_HelloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::HelloRequest.Parser));
  static readonly grpc::Marshaller<global::HelloReply> __Marshaller_HelloReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::HelloReply.Parser));

  static readonly grpc::Method<global::HelloRequest, global::HelloReply> __Method_SayHello = new grpc::Method<global::HelloRequest, global::HelloReply>(
      grpc::MethodType.Unary,
      __ServiceName,
      "SayHello",
      __Marshaller_HelloRequest,
      __Marshaller_HelloReply);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::HelloServiceReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of HelloService</summary>
  [grpc::BindServiceMethod(typeof(HelloService), "BindService")]
  public abstract partial class HelloServiceBase
  {
    public virtual global::System.Threading.Tasks.Task<global::HelloReply> SayHello(global::HelloRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for HelloService</summary>
  public partial class HelloServiceClient : grpc::ClientBase<HelloServiceClient>
  {
    /// <summary>Creates a new client for HelloService</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public HelloServiceClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for HelloService that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public HelloServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected HelloServiceClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected HelloServiceClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    public virtual global::HelloReply SayHello(global::HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::HelloReply SayHello(global::HelloRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::HelloReply> SayHelloAsync(global::HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::HelloReply> SayHelloAsync(global::HelloRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override HelloServiceClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new HelloServiceClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(HelloServiceBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, HelloServiceBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::HelloRequest, global::HelloReply>(serviceImpl.SayHello));
  }

}
#endregion
