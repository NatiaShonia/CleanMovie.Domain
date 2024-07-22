﻿using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastucture
{
    public class MovieRepository : ImovieRepository
    {
        //public static List<Movie> movies = new List<Movie>()
        //{
        //    new Movie {Id=1, Name="Prison Break", Cost=1000},
        //    new Movie {Id=2, Name="Home Alone1", Cost=1000},


        //};

        private readonly MovieDbContext _movieDbContext;
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }



        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }
    }
}
