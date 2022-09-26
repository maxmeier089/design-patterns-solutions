using System;
using System.Collections.Generic;
using CSVReader;

CSVReader.CSVReader reader = new();

List<CSVEntry> entries = await reader.ReadFile("Fruits.CSV");

entries.ForEach(entry => Console.WriteLine(entry.ToString()));

