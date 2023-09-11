using MovieClassL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MovieClassL.Model
{
    public  class MovieManager
    {
        public static List<Movie> movies = new List <Movie>();
        

        public List<Movie> Movies { get ; }
        public  static int GiveMovieCount
        {
            get{  return movies.Count;  }
        }


        public MovieManager()
        {

            movies = serdeser.LoadMovies();
            

        }  
        
            public static List<Movie> DisplayMovies()
            {
                if (movies == null)
            {
                throw new Exception("There is no any movie");
            }
            return movies;
            }

            public static void AddMovie(int MovieId, string Name,string  Genre, int Year)
            {
                movies.Add(new Movie {  MovieId = MovieId, Name = Name, Genre = Genre, Year = Year });
                
            }
            

            public static void ClearMovies()
            {
              movies.Clear();
            }
      

        
        }
    }

