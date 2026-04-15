/*******************************************************************
* Name: Emmanuel Holmes
* Date: 4/15/2026
* Assignment: Course Project Part 2
*
* Main application class.
*******************************************************************/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Emmanuel Holmes - Movie Collection Manager\n");

        Director d1 = new Director("Christopher Nolan", 25);
        Director d2 = new Director("Todd Phillips", 20);
        Director d3 = new Director("Greta Gerwig", 18);

        Movie movie1 = new Movie("Inception", "Sci-Fi", 2010, "PG-13", d1);
        ActionMovie movie2 = new ActionMovie("The Dark Knight", "Action", 2008, "PG-13", d1, "High");
        ComedyMovie movie3 = new ComedyMovie("Barbie", "Comedy", 2023, "PG-13", d3, "Satirical");

        Console.WriteLine("Regular Movie");
        Console.WriteLine(movie1);
        Console.WriteLine();

        Console.WriteLine("Action Movie");
        Console.WriteLine(movie2);
        Console.WriteLine();

        Console.WriteLine("Comedy Movie");
        Console.WriteLine(movie3);
        Console.WriteLine();
    }
}