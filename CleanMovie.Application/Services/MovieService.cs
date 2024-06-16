using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }
        public List<Movie> GetAllMovies()
        {
            var moviesList = _repository.GetAllMovies();

            return moviesList;
        }

        public Movie CreateMovie(Movie movie)
        {
            var newMovie = _repository.CreateMovie(movie);

            return newMovie;
        }

       
    }
}
