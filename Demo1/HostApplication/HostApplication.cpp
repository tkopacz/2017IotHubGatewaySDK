// HostApplication.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "gateway.h"


int main()
{
	GATEWAY_HANDLE gateway;
	printf("Enter - gateway start(please connect debugger etc.)\n");
	//(void)getchar();
	if ((gateway = Gateway_CreateFromJson("D:\\GIT_TKOPACZ\\2017IotHubGatewaySDK\\Demo1\\hostapplication.json")) == NULL)
	{
		printf("failed to create the gateway from hostapplication.json\n");
	}
	else
	{
		printf("gateway successfully created from JSON\n");
		printf("gateway shall run until ENTER is pressed\n");
		(void)getchar();
		Gateway_Destroy(gateway);
	}
	return 0;
}

