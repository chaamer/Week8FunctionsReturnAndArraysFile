using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite", "water" };
            string[] movie = { "Horror", "Comedy", "Action", "Documentary" };

            randomFood = PickRandomElemntFromArray(foods);
            randomDrink = PickRandomElemntFromArray(drinks);
            randomMovie = PickRandomElemntFromArray(movie);

            Console.WriteLine($"Today you will have {randomFood} with {randomDrink} and watch {randomMovie}");
             
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string PickRandomElemntFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
