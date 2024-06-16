using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public MovieRepository()
        {

        }
        List<Movie> IMovieRepository.GetAllMovies()
        {
            throw new NotImplementedException();
        }
    }
}
