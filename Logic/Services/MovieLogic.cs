using Data.Interfaces;
using Logic.Interfaces;
using MediaApp_Models;

namespace Logic.Services
{
    public class MovieLogic : IMovieLogic
    {
        IMovieRepository movieRepo;
        public MovieLogic(IMovieRepository movieRepo)
        {
            this.movieRepo = movieRepo;
        }

        public void Create(Movie movie)
        {
            movieRepo.Create(movie);
        }

        public void Delete(int id)
        {
            movieRepo.Delete(id);
        }

        public Movie Read(int id)
        {
            Movie movie = movieRepo.Read(id);
            if(movie == null)
            {
                throw new ArgumentException("Invalid ID");
            }
            return movie;
        }

        public IEnumerable<Movie> ReadAll()
        {
            return movieRepo.ReadAll();
        }

        public void Update(Movie movie)
        {
            movieRepo.Update(movie);
        }
    }
}