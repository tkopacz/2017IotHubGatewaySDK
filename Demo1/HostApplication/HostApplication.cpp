// HostApplication.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "gateway.h"


int main(int argc, char** argv)
{
	GATEWAY_HANDLE gateway;
	printf("Enter - gateway start(please connect debugger etc.)\n");
	(void)getchar();
	if (argc != 2)
	{
		printf("usage: HostApplication configFile\n");
		printf("where configFile is the name of the file that contains the Gateway configuration\n");
	}
	else
	{
		if ((gateway = Gateway_CreateFromJson(argv[1])) == NULL)
		{
			printf("failed to create the gateway from JSON\n");
		}
		else
		{
			printf("gateway successfully created from JSON\n");
			printf("gateway shall run until ENTER is pressed\n");
			(void)getchar();
			Gateway_Destroy(gateway);
		}
	}

}

