GTA:Network Resource Boilerplate
================================

Introduction
------------

This boilerplate aims to give you a head start with scripting your GTA:Network resources.

It features support for IntelliSense in Microsoft Visual Studio Code.

![Imgur](http://i.imgur.com/FTMblG1.gif)

Just have a look around, everything will make sense.

Prerequisites
-------------
For IntelliSense support you need to install the `C#` extension made by OmniSharp. On Linux/macOS you can install `mono` to run the GTANetwork Server using `mono GTANetworkServer.exe`.

To start developing in VS Code with IntelliSense, you need to [download](https://download.gtanet.work/server/) the server ZIP from GTA:Network.

And extract it in the folder [vendor](vendor) in the Git repository. In [Server/Server.csproj](./Server/Server.csproj) you can see the path to the dependencies.

The boilerplate already includes server_0.1.386.270 extracted in the [vendor/server_0.1.386.270](./vendor/server_0.1.386.270) folder.



