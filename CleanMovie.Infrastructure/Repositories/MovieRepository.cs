using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using CleanMovie.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataDbContext _context;

        public MovieRepository(DataDbContext context)
        {
            _context = context;
        }

        public Movie CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            return movie;
        }

        List<Movie> IMovieRepository.GetAllMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
