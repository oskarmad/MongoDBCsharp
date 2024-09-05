// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;
using MongoDBCsharp.Models;

Console.WriteLine("Hello, World!");

MongoClient client = new MongoClient("mongodb://localhost:27017");
//mongodb+srv://oskarmax:password@omdcluster.u6zyq.mongodb.net/
IMongoDatabase database = client.GetDatabase("school");

IMongoCollection<People> peopleDB = database.GetCollection<People>("people");

//Crear
People People = new People() { Nombre = "Oscar", Edad = 35, Country = "Colombia" };
//People People = new People() { Nombre = "Emmma", Edad = 5 };
//People People = new People() { Nombre = "Annie", Edad = 9 };
peopleDB.InsertOne(People);

//Consultar todo
List<People> list = peopleDB.Find(d => true).ToList();

list.First().Nombre = "Emmma Díaz";

//Edito el primero por el id
peopleDB.ReplaceOne(d => d.Id == list.First().Id, list.First());

//eliminar
//peopleDB.DeleteOne(d => d.Id == list.First().Id);


Console.WriteLine("Fin!");
