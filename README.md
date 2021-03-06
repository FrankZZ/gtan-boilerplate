GTA:Network Resource Boilerplate
================================

Introduction
------------

This boilerplate aims to give you a head start with scripting your GTA:Network resources.

It features support for IntelliSense (Server side C# for now) in [Microsoft Visual Studio Code](https://code.visualstudio.com).

![Imgur](http://i.imgur.com/FTMblG1.gif)

Just have a look around, everything will make sense.

Prerequisites
-------------
For IntelliSense support you need to install the `C#` extension made by OmniSharp. On Linux/macOS you can install `mono` to run the GTANetwork Server using `mono GTANetworkServer.exe`.

To start developing in VS Code with IntelliSense, you need to [download](https://download.gtanet.work/server/) the server ZIP from GTA:Network.

And extract it in the folder [vendor](vendor) in the Git repository, *you need `GTANetworkServer.exe` and `GTANetworkShared.dll`*.

In [Server/Server.csproj](./Server/Server.csproj) you can see the path to the dependencies.
