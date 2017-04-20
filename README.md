[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/codecoding/SQLite4Unity3d.svg)](http://isitmaintained.com/project/codecoding/SQLite4Unity3d "Average time to resolve an issue")
[![Percentage of issues still open](http://isitmaintained.com/badge/open/codecoding/SQLite4Unity3d.svg)](http://isitmaintained.com/project/codecoding/SQLite4Unity3d "Percentage of issues still open")

# What's this?
When I started with Unity3d development I needed to use SQLite in my project and it was very hard to me to find a place with simple instructions on how to make it work. All I got were links to paid solutions on the Unity3d's Assets Store and a lot of different and complicated tutorials.

At the end, I decided that there should be a simpler way and I created **SQLite4Unity3d**, a plugin that helps you to use SQLite in your Unity3d projects in a clear and easy way and works in **iOS, Mac, Android and Windows** projects.

It uses the great [sqlite-net](https://github.com/praeclarum/sqlite-net) library as a base so you will have **Linq besides sql**. For a further reference on what possibilities you have available with this library I encourage you to visit [its github repository](https://github.com/praeclarum/sqlite-net). 

*Note: _SQLite4Unity3d uses only the synchronous part of sqlite-net, so all the calls to the database are synchronous._

If you want to know more about why I created this plugin you can read more [here](http://www.codecoding.com/sqlite4unity3d-using-sqlite-net-library-and-unity3d-free-edition/).

# The fast track
All you have to do to start using it in your project:

1. [Download this zip](https://github.com/codecoding/SQLite4Unity3d/raw/master/SQLite4Unity3d.zip), extract its content and  **copy the resulting folder to your Assets/Plugins folder**. It contains the dlls that Unity3d will need to access sqlite.
2. **Copy the SQLite.cs** file into your scripts folder.
3. Don’t forget to **copy your SQLite database file in your Assets/StreamingAssets folder if you’re shipping one**.
4. **You’re done!** Now you can get access to your database using sqlite-net.  ;P

# Example
If you want to try it I've uploaded a small example that you will be able to find in the "Example" folder. Download the folder and open it with Unity3d to give it a try. It contains classes that will help you to start.

## Android particularities
Android configuration and deployment is very straight forward. Take a look at the **following video** if you want to get a picture on how to proceed:

<a href="http://www.youtube.com/watch?feature=player_embedded&v=oPEl0mzeYoQ" target="_blank"><img src="http://img.youtube.com/vi/oPEl0mzeYoQ/0.jpg" alt="UWP"  border="10" /></a>

# iOS particularities
As you may know **iOS doesn't allow JIT compilation** so, generally speaking, you will have to be very careful when you use **reflection** in your code. For a more deeper explanation of this issue please refer to Google but making it short: you cannot create dynamic objects using reflection. How is this affecting SQLite4Unity3d? Well, prior to this version you couldn't use very complicated queries. Now, **for basic queries you will have iOS support**. In case you stumble uppon a JIT compilation error it's time to use the old sql syntax.

Check this video to know how to proceed with iOS deployment:

<a href="http://www.youtube.com/watch?feature=player_embedded&v=a4HXlGbO_2c" target="_blank"><img src="http://img.youtube.com/vi/a4HXlGbO_2c/0.jpg" alt="UWP"  border="10" /></a>

# Windows particularities
In general you won't find any issues with Android and iOS. For **Windows versions**, please take a look at the **the video below** for more details on how to proceed:

<a href="http://www.youtube.com/watch?feature=player_embedded&v=zVXr70fYxoA" target="_blank"><img src="http://img.youtube.com/vi/zVXr70fYxoA/0.jpg" alt="UWP"  border="10" /></a>

# Acknowledgements
This project is based on the work of:

- [Sqlite-net](https://github.com/praeclarum/sqlite-net) - License: custom - see https://github.com/praeclarum/sqlite-net/blob/master/license.md


