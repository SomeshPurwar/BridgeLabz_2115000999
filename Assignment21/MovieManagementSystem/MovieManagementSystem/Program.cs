using System;
namespace MovieManagementSystem
{

    class Movie
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public Movie Next;
        public Movie Prev;

        public Movie(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

    class MovieList
    {
        private Movie head;
        private Movie tail;

        public void AddMovieAtEnd(string title, string director, int year, double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);
            if (head == null)
            {
                head = tail = newMovie;
            }
            else
            {
                tail.Next = newMovie;
                newMovie.Prev = tail;
                tail = newMovie;
            }
        }

        public void RemoveMovie(string title)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title == title)
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    Console.WriteLine("Movie removed successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Movie not found.");
        }

        public void SearchMovie(string searchParam)
        {
            Movie current = head;
            bool found = false;
            while (current != null)
            {
                if (current.Director == searchParam || current.Rating.ToString() == searchParam)
                {
                    Console.WriteLine($"Found Movie: {current.Title}, Director: {current.Director}, Year: {current.Year}, Rating: {current.Rating}");
                    found = true;
                }
                current = current.Next;
            }
            if (!found)
                Console.WriteLine("No matching movies found.");
        }

        public void DisplayMovies()
        {
            Movie current = head;
            Console.WriteLine("Movies in List (Forward Order):");
            while (current != null)
            {
                Console.WriteLine($"{current.Title} - {current.Director} - {current.Year} - {current.Rating}");
                current = current.Next;
            }
        }

        public void DisplayMoviesReverse()
        {
            Movie current = tail;
            Console.WriteLine("Movies in List (Reverse Order):");
            while (current != null)
            {
                Console.WriteLine($"{current.Title} - {current.Director} - {current.Year} - {current.Rating}");
                current = current.Prev;
            }
        }

        public void UpdateRating(string title, double newRating)
        {
            Movie current = head;
            while (current != null)
            {
                if (current.Title == title)
                {
                    current.Rating = newRating;
                    Console.WriteLine("Movie rating updated successfully.");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Movie not found.");
        }
    }

    class Program
    {
        static void Main()
        {
            MovieList movieList = new MovieList();
            movieList.AddMovieAtEnd("Jawaan", "Atlee", 2021, 9.0);
            movieList.AddMovieAtEnd("Baby John", "kalees", 2025, 7.8);
            movieList.AddMovieAtEnd("Marco", "Haneef Adeni", 2024, 9.0);

            movieList.DisplayMovies();
            movieList.DisplayMoviesReverse();

            movieList.SearchMovie("kalees");
            movieList.UpdateRating("Marco", 8.0);

            movieList.RemoveMovie("Baby John");
            movieList.DisplayMovies();
        }
    }

}