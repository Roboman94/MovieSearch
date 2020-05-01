using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp18
{

        class Program
        {
            static void Main(string[] args)
            {
            Class1 Movie = new Class1();


            List<Class1> movies = new List<Class1>();
            FillListOfMovies(movies);

            Console.WriteLine("Welcome to movie search engine!");
            bool validcheck = false;
            bool proceed = true;
            int i = 0;
            while (proceed == true)
            {
                while (validcheck == false)
                {
                    Console.WriteLine("Please search movie by category here..");
                    Console.WriteLine("Current categories include BioPic, Action, Adventure, and Childrens:");
                    string input = Console.ReadLine();

                    foreach (Class1 movie in movies)
                    {
                       
                        movie.PrintMovieInfo(input, i);
                        if (i == 2)
                        {
                            validcheck = true;
                        }
                        else { validcheck = false; }
                        //attempt to store validcheck in class
                        //movie.ValidCheck(i, validcheck);
                    }

                    //attempt not good
                    //validcheck = ValidCheck(i, validcheck);

                }
                if (i == 0) { 
                proceed = Proceed();}
            }
        }
        public static void FillListOfMovies(List<Class1> movies)
        {
            movies.Add(new Class1("Social Network", "BioPic", "2010"));
            movies.Add(new Class1("Small Soldiers", "Childrens", "1994"));
            movies.Add(new Class1("My Neighbor Totoro", "Childrens", "2001"));
            movies.Add(new Class1("Nightmare Before Christmas", "Childrens", "2012"));
            movies.Add(new Class1("Jobs", "BioPic", "2011"));
            movies.Add(new Class1("Sonic", "Childrens", "2009"));
            movies.Add(new Class1("Iron Man", "Action", "2008"));
            movies.Add(new Class1("iRobot", "Action", "2004"));
            movies.Add(new Class1("Martian", "Adventure", "2013"));
            movies.Add(new Class1("Spiderman", "Action", "2002"));

        }

        public static bool Proceed()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? (y/n) ");
            string proceed = Console.ReadLine().ToLower();
            if (proceed.StartsWith("y"))
            {
                return true;
            }
            if (proceed.StartsWith("n"))
            {
                Console.WriteLine("thank you!");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again");
                return Proceed();
            }
        }

    }


}

