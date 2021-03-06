namespace NewMovieAPI.Repository.Interfaces
{
    using NewMovieAPI.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMovieRepository
    {
        void Add(Movie movie);

        void Remove(int id);

        void Update(Movie movie);

        Task<Movie> GetMovie(int id);

        Task<IEnumerable<Movie>> GetMovies();
    }
}
