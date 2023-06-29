using System;
using System.Linq;

namespace HomeWork_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainlands = new List<Mainland>()
            {
                new Mainland() { Name = "Europe" },
                new Mainland() { Name = "North America" },
                new Mainland() { Name = "Africa" },
                new Mainland() { Name = "Asia" },
                new Mainland() { Name = "South America" }
            };
            var countries = new List<Country>()
            {
                new Country() { Name = "Ukraine", Mainland = "Europe"},
                new Country() { Name = "Austria", Mainland = "Europe"},
                new Country() { Name = "Italy", Mainland = "Europe"},
                new Country() { Name = "USA", Mainland = "North America"},
                new Country() { Name = "Angola", Mainland = "Africa"},
                new Country() { Name = "Nigeria", Mainland = "Africa"},
                new Country() { Name = "Japan", Mainland = "Asia"},
                new Country() { Name = "Argentina", Mainland = "South America"}
            };
            var cities = new List<City>()
            {
                new City() { Name = "Kyiv", Population = 3000000, Country=countries.First(c=>c.Name == "Ukraine"), CreationDate= 482, IsCapital = true},
                new City() { Name = "Lviv", Population = 756171, Country=countries.First(c=>c.Name == "Ukraine"), CreationDate = 1256, IsCapital = false},
                new City() { Name = "Washington", Population = 324000, Country=countries.First(c=>c.Name == "USA"), CreationDate = 482, IsCapital = true},
                new City() { Name = "Maimi", Population = 150000, Country=countries.First(c=>c.Name == "USA"), CreationDate = 1512, IsCapital = false},
                new City() { Name = "Luanda", Population = 212333, Country=countries.First(c=>c.Name == "Angola"), CreationDate = 1324, IsCapital = true},
                new City() { Name = "Uambo", Population = 4645, Country=countries.First(c=>c.Name == "Angola"), CreationDate = 212, IsCapital = false},
                new City() { Name = "Tokio", Population = 700000, Country=countries.First(c=>c.Name == "Japan"), CreationDate = 245, IsCapital = true},
                new City() { Name = "Kioto", Population = 26783, Country=countries.First(c=>c.Name == "Japan"), CreationDate = 1543, IsCapital = false},
                new City() { Name = "Buenos-Ayres", Population = 20083, Country=countries.First(c=>c.Name == "Argentina"), CreationDate = 894, IsCapital = true},
                new City() { Name = "Rosario", Population = 3333, Country=countries.First(c=>c.Name == "Argentina"), CreationDate = 1924, IsCapital = false}
            };

            //количество стран по континентам
            var countiesByMainland = countries.GroupBy(c => c.Mainland)
                .Select(g => $"{g.Key}: {g.Count()}");
            foreach (var item in countiesByMainland)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //топ 3 по населению без учета созданных до 1200 года
            var top3 = cities.OrderByDescending(c => c.CreationDate <= 1200)
                .OrderByDescending(c => c.Population)
                .Take(3);
            foreach (var city in top3)
            {
                Console.WriteLine($"{city.Name}: {city.Population}");
            }

            Console.WriteLine();

            //страна с наибольшим населением и ее столицей
            var cityWithHightPeople = cities.OrderByDescending(c => c.Population).FirstOrDefault();
            Console.WriteLine($"The city with the largest population: {cityWithHightPeople.Name}");

            Console.WriteLine();

            //континент с наибольшим количеством городов в которых население больше 1000000
            var mainlandsWithMostCities = cities
            .Where(c => c.Population> 1000000)
            .GroupBy(c => c.Country.Mainland)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key);

            foreach (var mainland in mainlandsWithMostCities)
            {
                Console.WriteLine($"Mainland: {mainland}");
            }
        }
    }
}
