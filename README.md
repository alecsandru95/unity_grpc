# Unity_gRPC for Windows

# gRPC

gRPC is a modern open source high performance Remote Procedure Call (RPC) framework that can run in any environment.
It can efficiently connect services in and across data centers with pluggable support for load balancing, tracing, health checking and authentication.
It is also applicable in last mile of distributed computing to connect devices, mobile applications and browsers to backend services.

## Setup
1. .NET 4.x
	- In Unity3d, got to Edit > Project Setting > Player > Configuration > Scripting Runtime Version, change it to **.Net 4.x**
2. grpc_unity_package
	- Go to https://packages.grpc.io/
	- Select the latest **Build Id**
	- Select grpc_unity_package.*VERSION*.zip from the **C#** section
	- Extract the archive
	- Copy the **Plugins** folder in your unity Assets folder (Assets/Plugins)
3. grpc-protoc_windows
	- go to https://packages.grpc.io/
	- select the **SAME build Id as in step 2**0
	- select the wright grpc-protoc_windows archive from **gRPC protoc Plugins** section (grpc-protoc_windows_*x64/x86-VERSION*.zip). Select x64 if you plan to build for x64 systems.
	- extract the archive
	- copy **protoc.exe** and **grpc_csharp_plugin.exe** to Assets/Plugins/Grpc.Tools directory

## GrpcHelper.cs

- It's a helper tool that compiles **ALL** the .proto files from the Assets folder.
- In Unity, top menu, go to gRPC > Build proto files
- **Doesn't support paths with spaces, windows cmd limitation**

## Documentation
- https://developers.google.com/protocol-buffers/docs/proto3
- https://intl.cloud.tencent.com/document/product/1055/39057