copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\LIB_RELEASE_VS2015\C\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Release\
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\ModuleCSSender\bin\x86\Release\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Release
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\ModuleCSFilter\bin\x86\Release\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Release

cd "D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Release"
HostApplication.exe D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\dotnet_logger.json 
cd ..
