using System.Collections.Generic;
using FubuDemo.Core;

namespace FubuDemo.Service
{
    class MovieService : IMovieService
    {
        private readonly Dictionary<int, Movie> movies = new Dictionary<int, Movie>();

        public Movie Get(int id)
        {
            return movies[id];
        }

        public void Add(Movie movie)
        {
            movies.Add(movie.Id, movie);
        }

        public void Update(Movie movie)
        {
            movies[movie.Id] = movie;
        }

        public ICollection<Movie> All()
        {
            return movies.Values;
        }
    }
}