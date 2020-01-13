@rem Generate the C# code for .proto files

setlocal

@rem enter this directory
cd /d %~dp0

packages\Grpc.Tools.2.26.0\tools\windows_x64\protoc.exe -I protos protos\gameN.proto --csharp_out=GamesLibrary --grpc_out=GamesLibrary --plugin=protoc-gen-grpc=packages\Grpc.Tools.2.26.0\tools\windows_x64\grpc_csharp_plugin.exe 
endlocal

pause
