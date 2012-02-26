using System;
using System.Collections.Generic;
using FubuDemo.Core;
using FubuDemo.Service;

namespace FubuDemo.Web
{
    public class MovieController
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public MovieListViewModel get_movies(MovieListInputModel input)
        {
            return new MovieListViewModel
                       {
                           Movies = movieService.All()
                       };
        }

        public MovieEditViewModel get_movies_edit_Id(MovieEditInputModel input)
        {
            var movie = movieService.Get(input.Id);
            return new MovieEditViewModel
                       {
                           Name = movie.Name,
                           Description = movie.Description
                       };
        }
    }

    public class MovieEditInputModel
    {
        public int Id { get; set; }
    }

    public class MovieEditViewModel
    {
        public string Description { get; set; }

        public string Name { get; set; }
    }

    public class MovieListInputModel
    {
    }

    public class MovieListViewModel
    {
        public ICollection<Movie> Movies { get; set; }
    }
}