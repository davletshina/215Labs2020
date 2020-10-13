using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class film
    {
        public string name;
        public string country;
        public string produser;
        public int year;
        public string genre;
        public film (string _name, string _country, string _produser, int _year, string _genre)
        {
            name = _name;
            country = _country;
            produser = _produser;
            year = _year;
            genre = _genre;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        film[] FilmCollection = new film[5];
        FilmCollection[0] = new film("Alien", "USA", "Ridley Scott", 1979, "Horror");
        FilmCollection[1] = new film("Nine", "USA", "Shane Acker", 2009, "Cartoon");
        FilmCollection[2] = new film("Beetlejuice", "USA", "Tim Berton", 1988, "Comedy");
        FilmCollection[3] = new film("Pulp Fiction", "USA", "Quentin Tarantino", 1994, "Criminal");
        FilmCollection[4] = new film("Fight Club", "USA", "David Fincher", 1999, "Triller");
        Console.WriteLine("Выберите жанр");
        string a = Console.ReadLine();
        Console.WriteLine("Выберите страну");
        string b = Console.ReadLine();
        int c = 0;
        foreach (var item in FilmCollection)
        {
            if (item.genre == a && item.country == b)
            {
                Console.WriteLine($"{item.name} {item.country} {item.produser} {item.year} {item.genre}");
                c += 1;
            }
        }
        if (c == 0) Console.WriteLine("Ничего не найдено");
    }
}
