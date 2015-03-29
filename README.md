# What's this?
When I started with Unity3d development I needed to use SQLite in my project and it was very hard to me to find a place with simple instructions on how to make it work. All I got were links to paid solutions on the Unity3d's Assets Store and a lot of different and complicated tutorials.

At the end, I decided that there should be a simpler way and I created **SQLite4Unity3d**, a library that helps you to use SQLite in your Unity3d projects in a clear and easy way and works in **iOS, Android and Windows Phone** projects.

Besides that, it uses the great [sqlite-net](https://github.com/praeclarum/sqlite-net) library as a base so you will have **Linq besides sql**. For a further reference on what possibilities you have available with this library I encourage you to visit [its github repository](https://github.com/praeclarum/sqlite-net). 

*Note: _SQLite4Unity3d uses only the synchronous part of sqlite-net, so all the calls to the database are synchronous._

If you want to know more about why I created this plugin you can read more [here](http://www.codecoding.com/sqlite4unity3d-using-sqlite-net-library-and-unity3d-free-edition/).

# The fast track
All you have to do to start using it in your project:

1. [Download this zip](https://github.com/codecoding/SQLite4Unity3d/raw/master/Plugins.zip) and **copy the resulting folder to your Assets/Plugins folder**. It contains the dlls that Unity3d will need to access sqlite.
2. Don’t forget to **copy your SQLite database file in your Assets/StreamingAssets folder if you’re shipping one**.
3. **You’re done!** Now you can get access to your database using sqlite-net.  ;P

# Example
If you want to try it I've uploaded a small example that you will be able to find in the "Example" folder. Download the folder and open it with Unity3d to give it a try.

# iOS particularities
**AOT**: 
As you may know **iOS doesn't allow JIT compilation** so, generally speaking, you will have to be very careful when you use **reflection** in your code. For a more deeper explanation of this issue please refer to Google but making it short: you cannot create dynamic objects using reflection. How is this affecting SQLite4Unity3d? Well, **you can't use the linq syntax** when making queries to SQLite and **you will have to use the old sql syntax**.

**UNITY 5**: 
In order to avoid the 'Plugins colliding with each other' error when trying to deploy to iOS in Unity 5, you will have to manually exclude the x86 version of sqlite3.dll from iOS compilation using the [plugin inspector] (http://docs.unity3d.com/Manual/PluginInspector.html)



# Acknowledgements
This project is based on the work of:

- [@MvvmCross](https://github.com/MvvmCross/MvvmCross) - License: developed and distributed under Ms-Pl - see http://opensource.org/licenses/ms-pl.html

- [Sqlite-net](https://github.com/praeclarum/sqlite-net) - License: custom - see https://github.com/praeclarum/sqlite-net/blob/master/license.md


