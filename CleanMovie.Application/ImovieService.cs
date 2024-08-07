﻿using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    //service-კონტროლიდან სერვიცი, სერვისიდან რეპოზიტორი იძახებახ
    //This is a use case
    public interface ImovieService
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
    }
}
