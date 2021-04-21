namespace NewMovieAPI.Service
{
    using NewMovieAPI.Entities;
    using NewMovieAPI.Repository.Interfaces;
    using NewMovieAPI.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public async Task<Movie> GetMovie(int id)
        {
            var movie = _movieRepository.GetMovie(id);
            return await movie;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = _movieRepository.GetMovies();
            return await movies;
        }

        public void Remove(int id)
        {
            _movieRepository.Remove(id);
        }

        public void Update(Movie movie)
        {
            _movieRepository.Update(movie);
        }
    }
}
