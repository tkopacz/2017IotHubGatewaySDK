#Copyright (c) Microsoft. All rights reserved.
#Licensed under the MIT license. See LICENSE file in the project root for full license information.

#this is CMakeLists.txt for iothub_messaging_sample
cmake_minimum_required(VERSION 2.8.11)

if(WIN32)
    message(FATAL_ERROR "This CMake file is only support Linux builds!")
endif()

set(AZUREIOT_INC_FOLDER ".." "/usr/include/azureiot")

include_directories(${AZUREIOT_INC_FOLDER})

set(iothub_messaging_sample_c_files
    ../iothub_messaging__sample.c
    ./main.c
)

set(iothub_messaging_sample_h_files
    ../iothub_messaging_sample.h
)

add_executable(iothub_messaging_sample ${iothub_messaging_sample_c_files} ${iothub_messaging_sample_h_files})

target_link_libraries(iothub_messaging_sample
    aziotsharedutil
)
