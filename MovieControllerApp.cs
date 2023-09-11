using MovieClassL;
using MovieClassL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieController
{
    internal class MovieControllerApp
    {
        public MovieControllerApp()
        {
            new MovieManager();
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1.Display movies");
                Console.WriteLine("2.Add a movie");
                Console.WriteLine("3.Clear All movies");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());
                
                

                    switch (choice)
                    {
                        case 1:
                            DisplayMovies();
                            break;
                        case 2:
                            AddMovie();
                            break;
                        case 3:
                            ClearMovies();
                            break;
                        case 4:

                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;


                    }
                }

                
               


            
                 void DisplayMovies()
                {
                     List<Movie> movies =  MovieManager.DisplayMovies();
                    Console.WriteLine("Movies:");
                    foreach (var movie in movies)
                    {
                        Console.WriteLine(movie);
                    }
                }
                 void AddMovie()
                {
                    
                    if (MovieManager.GiveMovieCount >= 5)
                    {
                        Console.WriteLine("Movie storage is full. you cannot add more movies");
                    }
                    else
                    {


                        Console.WriteLine("Enter movie ID: ");
                        int MovieId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter movie name: ");
                        string Name = Console.ReadLine();

                        Console.WriteLine("Enter movie genre");
                        string Genre = Console.ReadLine();

                        Console.WriteLine("Enter movie year: ");
                        int Year = Convert.ToInt32(Console.ReadLine());

                        MovieManager.AddMovie(MovieId, Name, Genre, Year);
                        Console.WriteLine("Movie added successfully");
                    }
                }
                void ClearMovies()
                {
                  MovieManager.ClearMovies();
                    Console.WriteLine("All movies cleared");
                }

            }
        }
    }



                
             
             
           

     

