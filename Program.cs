using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab1;


string filePath = "./videogames.csv";
string[] lines = File.ReadAllLines(filePath);
List<VideoGame> collection = new List<VideoGame>();

foreach(string line in lines)
    {
        string[] game = line.Split(',');
        VideoGame title = new VideoGame(game[0], game[1], game[2], game[3], game[4], game[5], game[6], game[7], game[8], game[9]);
        collection.Add(title);
    }

collection.Sort();

void PublisherData()
{
    Console.WriteLine("Please enter your favorite publisher.\n");
    string input = Console.ReadLine();

    List<VideoGame> publishers = new List<VideoGame>();
    var publisherQuery = collection
        .Where(title => title.publisher.Equals(input, StringComparison.OrdinalIgnoreCase))
        .ToList();

    publishers.Sort();

    foreach (var game in publisherQuery)
    {
        Console.WriteLine(game);
    }

    int totalCount = collection.Count();
    float publisherCount = publisherQuery.Count();
    double publisherPercentage = Math.Round(publisherCount / totalCount * 100, 2);
    Console.WriteLine($"Out of {totalCount} games in the collection, {publisherCount} are from {input} - which is %{publisherPercentage}.");
}

void GenreData()
{
    Console.WriteLine("Please enter your favorite genre.\n");
    string input = Console.ReadLine();

    List<VideoGame> genres = new List<VideoGame>();
    var genreQuery = collection
        .Where(title => title.genre.Equals(input, StringComparison.OrdinalIgnoreCase))
        .ToList();

    genres.Sort();

    foreach (var game in genreQuery)
    {
        Console.WriteLine(game);
    }

    int totalCount = collection.Count();
    float genreCount = genreQuery.Count();
    double genrePercentage = Math.Round(genreCount / totalCount * 100, 2);
    Console.WriteLine($"Out of {totalCount} games, {genreCount} are of the {input} genre - which is %{genrePercentage}.");
}

bool isDone = false;
while(!isDone)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to Lab 1! Here, you can query a large CSV collection of videogames based on publisher/developer or genre.\nEnter '1' to search for titles based on publisher, or '2' to search based on genre.\nEnter '3' to exit.\n------------------------------------------------------------------------------------------------------------------");
    string input = Console.ReadLine();

    switch(input)
    {
        case "1":
            PublisherData();
            Console.ReadLine();
            Console.Clear();
            break;
        case "2":
            GenreData();
            Console.ReadLine();
            Console.Clear();
            break;
        case "3":
            isDone = true;
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("\nSayonara! :]");
            break;
        default:
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Please enter a valid choice.");
            Console.ReadLine();
            Console.Clear();
            break;
    }
}