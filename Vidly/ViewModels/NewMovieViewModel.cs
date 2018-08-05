using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewMovieViewModel
    {
        //public Movie Movie { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
      
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 25)]
        [Required]
        public short? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }


        public IEnumerable<Genre> Genres { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }


        public NewMovieViewModel()
        {
            this.Id = 0;        
        }


        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            DateAdded = movie.DateAdded;
            GenreId = movie.GenreId;
        }

    }
}