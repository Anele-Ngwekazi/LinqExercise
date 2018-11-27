using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            QueryStringArray();

            LambdaIntArray();

            FirstNonRepeatingLetter();

            QueryCollection();
            Console.ReadLine();
        }

        private static void QueryStringArray()
        {
            Console.WriteLine("*********************\n* QueryStringArray *\n*********************");
            string[] dogs = {"Pitbull", "German Shepard",
            "Scooby Doo", "Bulldog", "Bull Terrir",
            "Snoopy"};

            var dogsQuery = from dog in dogs
                            where dog.Contains("B")
                            orderby dog ascending
                            select dog;

            Console.WriteLine("----Displaying the query of d0gs that have B---");
            foreach (var dog in dogsQuery)
            {
                Console.WriteLine(dog);
            }
           dogs[0] = "Bobby";
            Console.WriteLine("----Redisplaying the query---");
            foreach (var dog in dogsQuery)
            {
                Console.WriteLine(dog);
            }

        }

        private static void LambdaIntArray()
        {

            Console.WriteLine("\n*********************\n* LambdaIntArray *\n*********************");
            int[] nums = { 0, 5, 10, 15, 20, 25, 30, 35 };

            // Get numbers bigger then 20
            //var getFirstvalue = nums.Where(x => x > 100).First();
            //Console.WriteLine("value greater than 100: " + getFirstvalue);


            //Console.WriteLine(getFirstvalue);

            var checkValues = nums.Any(x => x > 10);

            Console.WriteLine("Are any the values greater than 10: " + checkValues);

        }

        private static void FirstNonRepeatingLetter()
        {
            Console.WriteLine("\n*********************\n* FirstNonRepeatingLetter *\n*********************");

            string sentence = "FEDCBbcdef";

            var letters = sentence.Where(char.IsLower);
            foreach (var letter in letters)
            {
                Console.WriteLine(letter);
            }

        }

        static void QueryCollection()
        {
            Console.WriteLine("\n*********************\n* QueryCollection *\n*********************");
            var animalList = new List<Animal>()
            {
                new Animal{Name = "Bobby",
                Height = 25,
                Weight = 77},
                new Animal{Name = "Pitbull",
                Height = 7,
                Weight = 4.4},
                new Animal{Name = "Bulldag",
                Height = 30,
                Weight = 200}
            };

            var bigDogs = from dog in animalList
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            foreach (var dog in bigDogs)
            {
                Console.WriteLine("A {0} weighs {1}kg",
                    dog.Name, dog.Weight);
            }

            Console.WriteLine();
        }
    }
}