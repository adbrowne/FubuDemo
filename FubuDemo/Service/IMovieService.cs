using System;
using System.Collections.Generic;
using FubuDemo.Core;

namespace FubuDemo.Service
{
    public interface IMovieService
    {
        Movie Get(int id);
        void Add(Movie movie);
        void Update(Movie movie);
        ICollection<Movie> All();
    }
}