using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    //repository-ბაზიდან მომაქ
    public interface ImovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }
}
