using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp18
{

        class Program
        {
        //#1 make movie class
            static void Main(string[] args)
            {

            //#6
            List<Movie> movies = Movie.GetListOfMovies();
            //7
            Console.WriteLine("Welcome to movie search engine!");
            int cont = 1;
            int valid = 0;
            while (cont == 1)
            {
                
                Console.WriteLine("Current categories include BioPic, Action, Adventure, and Childrens:");
                string userCategory = Movie.GetUserInfo("Search here: ");

                foreach (Movie flic in movies)
                {

                    if (flic.Genre == (userCategory))
                    {
                        Console.WriteLine(flic.Title);
                        valid = valid+1;
                        
                    }
                   

                }
                if (valid == 0)
                {
                    Console.WriteLine("Invalid entry! Please try again.");
                }
                else cont = 0;
                if (valid >= 1)
                {
                    Console.WriteLine("Would you like to search again? (y/n)");
                    string input = Console.ReadLine();
                    if (input.Contains('y')){
                        cont = 1;
                    }
                }
               
            }
                }
              
            }
        

      
       

       

}




