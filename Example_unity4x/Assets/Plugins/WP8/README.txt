For this to work properly you will have to do some extra work.
It seems that Unity 4.x is not recognizing the folder structure when creating the WP8 project and it will use the x86 dlls by default. If you try to override them in your recently created solution it will compile but when you try to run it it wont work and you will recibe an error similar to this:
'Could not load type 'UnityEngine.Internal.$Metadata[..]'

You will have to follow these steps:
0. If you're targeting a the emulator an not a real device, then when it says WP/x86 you must read WP/ARM and the other way around. i.e. 1-5 is written considering you want to deploy to a real device.
1. In your Unity project, remove the WP/x86 folder.
2. Put the content of the WP/ARM folder into WP and remove WP/ARM folder.
3. Generate the project.
4. Add the following references:
	- sqlite.winmd (directly in the root)
	- SQLite for Windows Phone (Windows Phone/Extensions in your reference manager. You will have to download this with TOOLS > Extensions and Updates in your VS )
5. You're ready to go!