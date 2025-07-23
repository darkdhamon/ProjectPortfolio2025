# Environment Setup

This repository contains C# projects targeting .NET 8.0.

To run `dotnet` commands you may need to install the .NET SDK. If `dotnet --version` fails, set up the SDK using the following steps:

```bash
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
```

After installation confirm with `dotnet --version`.
