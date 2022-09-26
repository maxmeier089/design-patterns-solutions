﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FruitStand
{
    public class FruitClient
    {
        readonly Search search = new();
        readonly Product product = new();
        readonly Price price = new();


        public async Task<List<Fruit>> SearchFruits(string name)
        {
            return await Task.Run(async () =>
            {
                try
                {
                    // search fruits
                    Console.WriteLine("\nSearching...");
                    List<FruitSearchResult> searchResults = await search.SearchFruits(name);

                    // put fruits in a dictionary
                    Dictionary<int, Fruit> fruits = new();

                    // store all ID from the search result here
                    List<int> fruitIDs = new();

                    foreach (FruitSearchResult searchResult in searchResults)
                    {
                        fruits[searchResult.ID] = new Fruit(searchResult.ID, searchResult.Name);
                        fruitIDs.Add(searchResult.ID);
                    }

                    // request informaiton
                    Console.WriteLine("Getting information...");
                    Task<List<FruitInformation>> informationTask = product.GetInformation(fruitIDs);

                    // request price
                    Console.WriteLine("Getting prices...");
                    Task<List<FruitPriceInformation>> priceTask = price.GetPrice(fruitIDs);

                    // read results
                    List<FruitInformation> information = await informationTask;
                    List<FruitPriceInformation> prices = await priceTask;

                    // add information
                    foreach (FruitInformation i in information)
                    {
                        fruits[i.ID].Description = i.Description;
                    }

                    // add prices
                    foreach (FruitPriceInformation p in prices)
                    {
                        fruits[p.ID].Price = p.Price;
                    }

                    return new List<Fruit>(fruits.Values);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    return new List<Fruit>();
                }
            });
        }

    }
}
