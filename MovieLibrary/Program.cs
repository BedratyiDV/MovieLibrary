namespace MovieLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieLibrary allMovies = new MovieLibrary();
            
            foreach (KeyValuePair<int, string> movie in allMovies) 
            
            {
                Console.WriteLine("Key = {0}, Value = {1}", movie.Key, movie.Value);
            }

            Console.WriteLine("Key = 0002, Value = {0}", allMovies.GetMovie(0002));
            Console.WriteLine("Key = 0007, Value = {0}", allMovies.GetMovie(0007));
            Console.WriteLine("Key = 0008, Value = {0}", allMovies.GetMovie(0008));
            Console.WriteLine("Key = 0009, Value = {0}", allMovies.GetMovie(0009));

            Console.WriteLine(allMovies.OrdinaryMovies[0003]);
            Console.WriteLine(allMovies.OnlyAdultMovies[0005]);

            
        }
    }
}