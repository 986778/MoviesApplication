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
    internal class serdeser
    {
        public static List<Movie> movies = new List<Movie>();
        public const string fileName = "movies.dat";
        public void SaveMovies(List<Movie>movies)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, movies);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving movies: " + ex.Message);
            }
        }

        public static List<Movie> LoadMovies()
        {
            if (File.Exists(fileName))
            {
                try
                {
                    List<Movie> movies = null;
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        movies = (List<Movie>)formatter.Deserialize(fs);
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading movies:" + ex.Message);
                }
            }
            return movies;


        }
    }
}
