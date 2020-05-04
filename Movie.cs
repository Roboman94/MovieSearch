using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp18
{
    class Movie
    {
           
        //#2
        //private fields
        //these start with a lower case letter
        private string movie;
        private string genre;
        private string year;
        private bool validcheck;

        //#3
        //public properties
        //these start with an uppercase letter - pascal case
        //bc these are public, these are used to access properties of an object
        //getters & setters
        public string Title
        {
            get //when we call this property from an object
            {
                return movie;
            }
            set // when we give property its value
            {
                movie = value;
            }
        }
        public string Genre
        {
            get //when we call this property from an object
            {
                return genre;
            }
            set // when we give property its value
            {
                genre = value;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        //#4
        //constructor(s) //method that allows an instance/object of our class
        //classes come with a default constructor
        //once a constructor is overloaded, it no longer exists
        //this overloaded constructor will allow...
        //an objects properties value once the object is created.
        public Movie()
        {
            movie = "default";
            genre = "default";
            year = "default";

        }
        public Movie(string _movie, string _genre, string _year)
        {
            //setting field to value coming from the parameters, 
            //overloading to create on object of type movie
            movie = _movie; 
            genre = _genre;
            year = _year;

        }

        //methods
        //
        //

        ///static because its using a collection of objects
        public static string GetUserInfo(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public static List<Movie> GetListOfMovies()
        {
            List<Movie> movies = new List<Movie> {
            new Movie("Social Network", "BioPic", "2010"),
            new Movie("Small Soldiers", "Childrens", "1994"),
            new Movie("My Neighbor Totoro", "Childrens", "2001"),
            new Movie("Nightmare Before Christmas", "Childrens", "2012"),
            new Movie("Jobs", "BioPic", "2011"),
            new Movie("Sonic", "Childrens", "2009"),
            new Movie("Iron Man", "Action", "2008"),
            new Movie("iRobot", "Action", "2004"),
            new Movie("Martian", "Adventure", "2013"),
            new Movie("Spiderman", "Action", "2002")
            };
            return movies;
        }
        public void PrintMovieInfo(string input, int i)
        {
            if (input.Contains(genre))
            {
                Console.WriteLine($"{movie} is from {genre} ");
                Console.WriteLine($"this movie was made in {year} ");
                i = 2;
               
            }
           

        }

        public bool ValidCheck(int i, bool validcheck)
        {
            if (i == 1)
            {
                validcheck = false;
            }
            else
            {
                validcheck = true;
            }
            return false;
        }
     }

       

 }

