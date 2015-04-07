For this to work properly you will have to do some extra work.

You will have to follow these steps:
0. If you're targeting a the emulator an not a real device, then when it says WP/x86 you must read WP/ARM and the other way around. i.e. 1-5 is written considering you want to deploy to a real device.
1. In your Unity project's Plugin inspector, remove the WP/x86 folder items from the WP8Player.
2. Select the content of the WP/ARM folder and in the Plugin Inspector check "Don't process" and set them for WP8Player.
3. Make sure that the SQLite4Unity3d.dll in your plugin folder contains a placeholder to Assets/Plugins/SQLite4Unity3d.dll
3. Generate the project.
4. Add the following references:
	- sqlite.winmd (if you already have a sqlite reference in your project check it's the correct one in terms of architecture)
	- SQLite4Unity3d.dll (maybe your project already has this reference but don't forget to check the architecture)
	- SQLite for Windows Phone (Windows Phone/Extensions in your reference manager. You will have to download this with TOOLS > Extensions and Updates in your VS )
5. You're ready to go!