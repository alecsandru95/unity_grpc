# Unity_gRPC

## Setup
### Alternative A
1. .NET 4.x
	- in Unity3d, got to Edit > Project Setting > Player > Configuration > Scripting Runtime Version, change it to .Net 4.x
2. grpc_unity_package
	- go to https://packages.grpc.io/
	- select the latest build Id
	- select grpc_unity_package.VERSION.zip from the C# section
	- extract the archive
	- copy the Plugins folder in your unity Assets folder (Assets/Plugins)
	
### Alternative B

See : https://intl.cloud.tencent.com/document/product/1055/39057\

## GrpcHelper.cs

- It's a helper tool that compiles all the protobuf code in the Assets folder.
- In Unity, top menu, go to gRPC > Build proto files