# ToyRobotSimulation
Toy Robot Simulation - Telstra Assignment 

# Prerequisites on Windows
- .Net Core 3.1 (Download from https://dotnet.microsoft.com/download/dotnet/3.1)

# GITHUB
  Open command prompt and clone this repo at any drive/folder of your choice
```
  git clone https://github.com/PrashantDhavale/ToyRobotSimulation.git
```
# Folder structure 

  The clone command will create a new folder ToyRobotSimulation -> (Root folder)
```
    ToyRobotSimulation.Client
    ToyRobotSimulation.Service
    ToyRobotSimulation.Tests
    README.md
```
#	Build the code
  Use the same command prompt and issue the following command in the root folder
```
  dotnet build .\ToyRobotSimulation.sln
```
# Execute the xUnit tests
  Once the build is successful use the following command to run the xUnit tests
```
  dotnet test
```
# Execute the application
  Execute the application using the following command
```
  dotnet run -p ./ToyRobotSimulation.Client
```