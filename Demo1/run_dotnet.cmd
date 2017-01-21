copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\LIB_DEBUG\C\gateway.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug\
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\LIB_DEBUG\C\aziotsharedutil.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug\
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\LIB_DEBUG\C\nanomsg.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug\
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\LIB_DEBUG\C\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug\
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\hostapplication.json D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug\
copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\ModuleCSSender\bin\Debug\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug\

copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\ModuleCSFilter\bin\x86\Debug\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug

copy D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\ModuleCSSender\bin\x86\Debug\*.* D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug


cd "D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\Debug"
HostApplication.exe D:\GIT_TKOPACZ\2017IotHubGatewaySDK\Demo1\dotnet_logger.json 
cd ..
