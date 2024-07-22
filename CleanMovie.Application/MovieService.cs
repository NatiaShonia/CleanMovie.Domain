using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : ImovieService
    {
        //Constructor Dependence Injection

        private readonly ImovieRepository _movieRepository;
        public MovieService(ImovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        //public ImovieRepository MovieRepository { get; }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies= _movieRepository.GetAllMovies();
            return movies;
        }
    }
}
