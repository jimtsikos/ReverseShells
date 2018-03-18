# ReverseShells
This is a .Net Core console application that generates reverse shell code.

# Windows
Just download the project, open it, build it and run it.

# Kali Linux
Run the following commands to install the .Net Core:
``` Bash
sudo apt-get update
sudo apt-get install curl libunwind8 gettext apt-transport-https
curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg
sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg
sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-debian-stretch-prod stretch main" > /etc/apt/sources.list.d/dotnetdev.list'
sudo apt-get update
sudo apt-get install dotnet-sdk-2.0.0
export PATH=$PATH:$HOME/dotnet
```
Then navigate to folder of the ReverseShells repository and run the following commands:
``` Bash
dotnet build
dotnet run
```
