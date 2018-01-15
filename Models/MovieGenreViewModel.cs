using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HolaMundo.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set;}
    }
}