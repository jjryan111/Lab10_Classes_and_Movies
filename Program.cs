using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";

            List<string> categories = new List<string>();
            categories.Add("horror");
            categories.Add("animated");
            categories.Add("sci-fi");
            categories.Add("drama");

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("The Silence of the Lambs", "horror"));
            movies.Add( new Movie("Casablanca", "drama"));
            movies.Add(new Movie("Alien", "sci-fi"));
            movies.Add(new Movie("Cutting Edge", "horror"));
            movies.Add(new Movie("Toy Story", "animated"));
            movies.Add(new Movie("Moana", "animated"));
            movies.Add(new Movie("IT", "horror"));
            movies.Add(new Movie("Good Will Hunting", "drama"));
            movies.Add(new Movie("The Lord of the Rings", "drama"));
            movies.Add(new Movie("Star Wars", "sci-fi"));
            while (yesNo == "y")
            {
                int choice = GetInput("Which type of movie 1) Horror, 2) Animated, 3) Sci-Si, 4) Drama: ", "Invalid Input!", 0, 4);

                foreach (Movie i in movies)
                {
                    string cat = i.GetCat();
                    string title = i.GetTitle();
                    if (cat == categories[(choice -1)])
                    {
                        Console.WriteLine(title);
                    }
                }
                yesNo = ynInput();
            }
        }

        public static int GetInput(string question, string error, int bottomNum, int topNum)
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.Write(question);
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum <= bottomNum || exitNum > topNum)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }

        public static string ynInput()
        // Gets a y or n.
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.Write("\nAnother genre? (y/n): ");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input == "y" || input == "n")
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("\nPlease enter y or n.");
                }
            }
            return input;
        }
    }
}

