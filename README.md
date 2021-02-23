# beanstalk-net
### Deploy .NET Core to AWS Elastic Beanstalk with RDS Database


#Launch file for debug:
{
    // Use IntelliSense to learn about possible attributes.
    // Hover to view descriptions of existing attributes.
    // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
    "version": "0.2.0",
    "configurations": [
        {
            "OS-COMMENT1": "Use IntelliSense to find out which attributes exist for C# debugging",
            "OS-COMMENT2": "Use hover for the description of the existing attributes",
            "OS-COMMENT3": "For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md",
            "name": ".NET Core Launch (web)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "OS-COMMENT4": "If you have changed target frameworks, make sure to update the program path.",
            "program": "${workspaceFolder}/bin/Debug/netcoreapp3.1/beanstalk-net.dll",
            "args": [],
            "cwd": "${workspaceFolder}",
            "stopAtEntry": false,
            "OS-COMMENT5": "Enable launching a web browser when ASP.NET Core starts. For more information: https://aka.ms/VSCode-CS-LaunchJson-WebBrowser",
            "serverReadyAction": {
                "action": "openExternally",
                "pattern": "\\\\bNow listening on:\\\\s+(https?://\\\\S+)"
            },
            "env": {
                "ASPNETCORE_ENVIRONMENT": "Development"
            },
            "sourceFileMap": {
                "/Views": "${workspaceFolder}/Views"
            }
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach",
            "processId": "${command:pickProcess}"
        }
    ]
}
