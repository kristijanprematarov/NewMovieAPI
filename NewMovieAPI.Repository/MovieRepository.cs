namespace NewMovieAPI.Repository
{
    using NewMovieAPI.Data;
    using NewMovieAPI.Entities;
    using NewMovieAPI.Repository.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public async Task<Movie> GetMovie(int id)
        {
            //var result = _context.Movies.Find(id);
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movies = _context.Movies.AsEnumerable();
            return movies;
        }

        public async void Remove(int id)
        {
            var movie = await GetMovie(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
    }
}
