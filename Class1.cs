﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp18
{
    class Class1
    {
        //private fields - name, hometown birthay fav number
        //these start with a lower case letter
        private string movie;
        private string genre;
        private string year;


        //public properties
        //these start with an uppercase letter - pascal case
        //bc these are public, these are used to access properties of an object
        //getters & setters
        public string Movie
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


        //constructor(s)
        //classes come with a default constructor
        //once a constructor is overloaded, it no longer exists
        //this overloaded constructor will allow...
        //an objects properties value once the object is created.
        public Class1()
        {
            movie = "Impreza";
            genre = "Subaru";
            year = "2011";

        }
        public Class1(string _movie, string _genre, string _year)
        {
            movie = _movie; //setting field to value
            genre = _genre;
            year = _year;

        }

        //methods
        //
        //
        public void PrintMovieInfo(string input, int i)
        {
            if (input.Contains(genre))
            {
                Console.WriteLine($"{movie} is from {genre} ");
                Console.WriteLine($"this movie was made in {year} ");
                i = 0;
               
            }
            else { i = 1; }
            if (i != 0){ 
                Console.WriteLine("The input you provided is invalid. Please try again!");
                i = 2;
                
            }

        }
           
     }

       

 }
