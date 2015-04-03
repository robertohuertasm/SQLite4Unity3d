For this to work properly you will have to do some extra work.

You will have to follow these steps:
1. In your Unity project, remove the WP/x86 folder.
2. Select the content of the WP/ARM folder and in the Plugin Inspector check "Don't process".
3. Make sure that the SQLite4Unity3d contains a placeholder to Assets/Plugins/SQLite4Unity3d.dll
3. Generate the project.
4. Add the following references:
	- sqlite.winmd (directly in the ARM folder)
	- SQLite4Unity3d.dll
	- SQLite for Windows Phone (Windows Phone/Extensions in your reference manager. You will have to download this with TOOLS > Extensions and Updates in your VS )
5. You're ready to go!