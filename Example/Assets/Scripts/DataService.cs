using UnityEngine;
using System.Collections;
using System.IO;
using SQLite4Unity3d;
using System.Collections.Generic;

public class DataService  {

	private ISQLiteConnection _connection;

	public DataService(string DatabaseName){

		var factory = new Factory ();
		var dbPath = string.Format(@"Assets/StreamingAssets/{0}", DatabaseName);
		//http://docs.unity3d.com/Manual/StreamingAssets.html

#if UNITY_ANDROID && !UNITY_EDITOR
		
		// check if file exists in Application.persistentDataPath
		var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);
		
		if (!File.Exists(filepath))
		{
			Debug.Log("Database not in Persistent path");
			// if it doesn't ->
			// open StreamingAssets directory and load the db ->
			var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
			while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
			// then save to Application.persistentDataPath
			File.WriteAllBytes(filepath, loadDb.bytes);
			Debug.Log("Database written");
		}
		//open db connection
		dbPath = filepath;
		
#elif UNITY_IOS && !UNITY_EDITOR
		
		// check if file exists in Application.persistentDataPath
		var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);
		
		if (!File.Exists(filepath))
		{
			Debug.Log("Database not in Persistent path");
			// if it doesn't ->
			// open StreamingAssets directory and load the db ->
			var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
			
			// then save to Application.persistentDataPath
			File.Copy(loadDb, filepath);
			Debug.Log("Database written");
		}
		//open db connection
		dbPath = filepath;
		
		
#elif !UNITY_ANDROID && !UNITY_WP8 && !UNITY_IOS
		var path = Path.Combine(Directory.GetCurrentDirectory(), dbPath);
#endif
		Debug.Log("Final PATH: " + dbPath);
		_connection = factory.Create(dbPath);
	}

	public void CreateDB(){
		_connection.DropTable<Person> ();
		_connection.CreateTable<Person> ();

		_connection.InsertAll (new[]{
			new Person{
				Id = 1,
				Name = "Tom",
				Surname = "Perez",
				Age = 56
			},
			new Person{
				Id = 2,
				Name = "Fred",
				Surname = "Arthurson",
				Age = 16
			},
			new Person{
				Id = 3,
				Name = "John",
				Surname = "Doe",
				Age = 25
			},
			new Person{
				Id = 4,
				Name = "Roberto",
				Surname = "Huertas",
				Age = 37
			},
		});
	}

	public IEnumerable<Person> GetPersons(){
		return _connection.Table<Person>();
	}

	public IEnumerable<Person> GetPersonsNamedRoberto(){
		return _connection.Table<Person>().Where(x => x.Name == "Roberto");
	}

	public Person GetJohnny(){
		return _connection.Table<Person>().Where(x => x.Name == "Johnny").FirstOrDefault();
	}

	public Person CreatePerson(){
		var p = new Person{
				Name = "Johnny",
				Surname = "Mnemonic",
				Age = 21
		};
		_connection.Insert (p);
		return p;
	}
}
