using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Inensia_Coding_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieStars = MovieStarClassObject();

            if(movieStars != null)

            {
                foreach (var movieStar in movieStars)
                {
                    Console.WriteLine($"{movieStar.Name} {movieStar.Surname}");
                    Console.WriteLine($"{movieStar.Sex}");
                    Console.WriteLine($"{movieStar.Nationality}");
                    Console.WriteLine($"{movieStar.Age} years old");
                    Console.WriteLine();
                }
            }

        }
            static List<MovieStar> MovieStarClassObject()
        {

            string filePath = @"C:\Users\Student\workspace\Inensia Coding Task 1\input.txt";

            if (File.Exists(filePath))
            {
                var movieStars = JsonConvert.DeserializeObject<List<MovieStar>>
                    (File.ReadAllText(filePath));

                return movieStars;
            }
            return null;
        }




/*      IF I WERE NOT USING NEWTONSOFT.JSON THIS IS HOW I WOULD SOLVE THE PROBLEM        
{
            string filePath = @"C:\Users\Student\workspace\Inensia Coding Task 1\input.txt";
       
            List<MovieStar> moviestars = new List<MovieStar>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split();

                MovieStar newMovieStar = new MovieStar();

                newMovieStar.Age = entries[0];
                newMovieStar.FirstName = entries[1];
                newMovieStar.Surname = entries[2];
                newMovieStar.Sex = entries[3];
                newMovieStar.Nanionality = entries[4];
                
                moviestars.Add(newMovieStar);
            }
            foreach (var moviestar in moviestars)
            {
                Console.WriteLine($"{moviestar.FirstName} {moviestar.Surname}");
                Console.WriteLine($"{moviestar.Sex}");
                Console.WriteLine($"{moviestar.Nanionality}");
                Console.WriteLine($"{moviestar.Age}");
            }

            Console.ReadLine();

        }*/
    }
}
