namespace NewMovieAPI.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
