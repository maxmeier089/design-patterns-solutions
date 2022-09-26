using System;
using System.Collections.Generic;
using FruitStand;

FruitClient fruitClient = new();

while (true)
{
    try
    {
        // read search text
        Console.WriteLine("Enter search text:");
        string searchText = Console.ReadLine();

        // search
        List<Fruit> fruits = await fruitClient.SearchFruits(searchText);


        // print result
        foreach (Fruit f in fruits)
        {
            Console.WriteLine(f);
        }

        Console.WriteLine("\n\n");
    }
    catch (Exception)
    {
        Console.WriteLine("Error");
    }
}

