http://developer.nokia.com/community/wiki/How_to_use_SQLite_in_Windows_Phone

You'll probably get this error message: The type or namespace name 'Community' could not be found. It can be fixed by this approach: Create the USE_WP8_NATIVE_SQLITE compilation symbol in the "SqliteForWP8" project. Please pay attention to the configuration and platform that you are creating this symbol since each platform has its own set of compilation symbols. This symbol will tell the sqlite-net package that you are using the SQLite for Windows Phone SDK.

"Any CPU" problem

If you get a warning message as shown below, follow these steps to fix it: Right click on the Solution -> Click on Configuration Properties -> Configuration Manager and change the active solution platform to x86 (If you are using an emulator) or ARM (If you are using a Windows Phone 8 device).