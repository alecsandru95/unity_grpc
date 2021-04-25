# Unity_gRPC

## Setup
1. .NET 4.x
	- in Unity3d, got to Edit > Project Setting > Player > Configuration > Scripting Runtime Version, change it to .Net 4.x
2. grpc_unity_package
	- go to https://packages.grpc.io/
	- select the latest build Id
	- select grpc_unity_package.VERSION.zip from the C# section
	- extract the archive
	- copy the Plugins folder in your unity Assets folder (Assets/Plugins)
3. grpc-protoc_windows
	- go to https://packages.grpc.io/
	- select the *SAME build Id as in step 2*
	- select the wright grpc-protoc_windows archive from *gRPC protoc Plugins* section
	- extract the archive
	- copy *protoc.exe* and *grpc_csharp_plugin.exe* to Assets/Plugins/Grpc.Tools directory

## GrpcHelper.cs

- It's a helper tool that compiles all the .proto files from the Assets folder.
- In Unity, top menu, go to gRPC > Build proto files

## Documentation
- https://developers.google.com/protocol-buffers/docs/proto3
- https://intl.cloud.tencent.com/document/product/1055/39057