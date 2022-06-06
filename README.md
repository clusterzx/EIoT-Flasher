# EIoT-Flasher
 .NET Flasher for INO Projects specially for EioT-Framework


This application is for flashing your Modules via a GUI .NET Application.
It uses the arduino-cli executable.

It is used specially for the EioT-Framework:
https://github.com/clusterzx/EioT-Framework

## Installation
1. Open the VS Solution
2. GoTo Project Settings
[![image.png](https://i.postimg.cc/v8rhwZK5/image.png)](https://postimg.cc/BtvHx44v)
4. Get the src (base64 encoded) for the module -> decode it -> change GPIO settings -> encode it -> put back -> save

(ex. for Thermostat):
```c++
//DHT Sensor 
uint8_t DHTPin = 12;
```
and set it to your GPIO Pin on your board where the DHT11 is connected.

Screenshot from GUI:
[![gui.png](https://i.postimg.cc/bYLWPr7K/gui.png)](https://postimg.cc/dDk4mstB)

