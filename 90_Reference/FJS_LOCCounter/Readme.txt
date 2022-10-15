Microsoft Line Of Code Counter
Copyright 2007 Microsoft Corporation. All rights reserved.

The Microsoft Line Of Code Counter Version 2.3 is available as a standalone Windows Application as well as an Add-in to Visual Studio 2005 IDE.

Pre-Requisites:
• You are working on either Windows XP or Windows Vista Platform
• For Add-in, you are working with one of,
o	Visual Studio 2005
o	Visual Studio 2005 SP1
o If you are on Windows Vista, you have installed Windows Vista upgrade for Visual Studio SP1
• Make sure you have at least Read access to VSTF or VSS projects or network share where the source code is located
• For VSTF source counting, tool assumes you have added project list to your Visual Studio Team Explorer
• Tool uses windows authentication. If this fails tool will ask user to enter login / password credentials.

Installation:
1. Download the zip file
2. Extract the zip file (include folder path info)
3. Uninstall any previous version for this LOC Counter (See below for instructions to uninstall)
4. If you are installing Add-in, Close Visual Studio IDE, if open
5. Run setup.exe

Note: You need to have Visual Studio IDE closed, because install runs the IDE in the background to make configuration changes related to enabling VS Packages.

Basic Operation (Standalone)

1. Start the application from your desktop
2. Create a Counter Task (which represents an assembly/module/project/application) using Menu Counter Task - New (or Tool bar icon for “New”)
3. Configure (or select)  source code, using Menu Counter Task - Configuration or Tool bar icon “Configure”
4. Enable the task in the Grid and Run Counter task using Menu Counter Task - Count, or Tool bar icon “Count”

Basic Operation (Add-in)
 
1. Start Visual Studio IDE
2. Make sure you have "Team Explorer" installed and one or more team projects are added to the Team Explorer.
3. Go to LOC Counter Explorer, present next to "Team Explorer" tab in the IDE. If not present, go to View - Other Windows menu and select "LOC Counter Explorer"
4. Create a Counter Task (which represents an assembly/module/project/application) using Tool bar icon for “New”
5. Configure (or select)  source code, using Tool bar icon “Configure”
6. Right click on the task and select "Run Counter Task" or Select the task, and click on Tool bar icon “Run Selected Counter Task”

Uninstall:
• Go to Control Panel, and remove the application
o 	LOC Counter (for Standalone App)
o 	LOC Counter VS Package (for Add-in)


