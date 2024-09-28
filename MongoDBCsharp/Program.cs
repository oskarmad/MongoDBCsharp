// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;
using MongoDBCsharp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello, World!");

//MongoClient client = new MongoClient("mongodb://localhost:27017");
////mongodb+srv://oskarmax:password@omdcluster.u6zyq.mongodb.net/
//IMongoDatabase database = client.GetDatabase("school");

//IMongoCollection<People> peopleDB = database.GetCollection<People>("people");

////Crear
//People People = new People() { Nombre = "Oscar", Edad = 35, Country = "Colombia" };
////People People = new People() { Nombre = "Emmma", Edad = 5 };
////People People = new People() { Nombre = "Annie", Edad = 9 };
//peopleDB.InsertOne(People);

////Consultar todo
//List<People> list = peopleDB.Find(d => true).ToList();

//list.First().Nombre = "Emmma Díaz";

////Edito el primero por el id
//peopleDB.ReplaceOne(d => d.Id == list.First().Id, list.First());

////eliminar
////peopleDB.DeleteOne(d => d.Id == list.First().Id);


//Console.WriteLine("Fin!");



// Teorema factorización numeros primos
class Program
{
    //ESTA PRUEBA YA LA REALICÉ CON LA PRUEBA DE C SHARP, AZURE Y MONGODB
    //LO TESTEÉ EN UN PROYECTO DE CONSOLA EN .NET
    //static void Main()
    //{
    //    // Capturar la entrada del usuario
    //    System.Console.WriteLine("Ingresa el a descomponer");
    //    string input = System.Console.ReadLine();
    //    int number;

    //    // Verificar si la entrada es un número entero válido
    //    if (int.TryParse(input, out number))
    //    {
    //        if (number < 2)
    //        {
    //            System.Console.WriteLine("Número no válido, por favor ingrese un número mayor o igual a 2.");
    //            return;
    //        }

    //        // Realizar la factorización prima
    //        GetFactorizacionPrima(number);
    //    }
    //    else
    //    {
    //        System.Console.WriteLine("Entrada no válida, por favor ingrese un número válido.");
    //    }
    //}

    //static void GetFactorizacionPrima(int n)
    //{
    //    // Dividir n entre 2 hasta que sea impar
    //    while (n % 2 == 0)
    //    {
    //        System.Console.WriteLine(2);
    //        n /= 2;
    //    }

    //    // Verificar los números impares empezando desde 3
    //    for (int i = 3; i * i <= n; i += 2)
    //    {
    //        while (n % i == 0)
    //        {
    //            System.Console.WriteLine(i);
    //            n /= i;
    //        }
    //    }

    //    // Si n es un número primo mayor que 2
    //    if (n > 2)
    //    {
    //        System.Console.WriteLine(n);
    //    }
    //}


    //algoritmo fibonacci
    //using System;

    //class Program
    //{

    //ESTA PRUEBA YA LA REALICÉ CON LA PRUEBA DE C SHARP, AZURE Y MONGODB
    //LO TESTEÉ EN UN PROYECTO DE CONSOLA EN .NET
    static void Main()
    {
        // Capturar el valor ingresado
        System.Console.WriteLine("Ingresa el número de secuencia fibonacci");
        string input = System.Console.ReadLine();
        int number;

        // Se valida el valor inresado es un número y uno entero permitido
        if (System.Int32.TryParse(input, out number))
        {
            if (number <= 0)
            {
                System.Console.WriteLine("Debes ingrese un número mayor a 0.");
                return;
            }

            //Permite imprimir la serie de números fibonacci
            ShowFibonacciSequence(number);
        }
        else
        {
            System.Console.WriteLine("Valor ingresado no valido, debe ser un valor númerico");
        }
    }

    static void ShowFibonacciSequence(int n)
    {
        int n1 = 0, n2 = 1, n3;

        for (int i = 1; i <= n; i++)
        {
            n3 = n1 + n2;
            System.Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
        }
    }
}

