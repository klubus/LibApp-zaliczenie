﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
		[Required(ErrorMessage = "Name is required")]
		[StringLength(255)]
		public string Name { get; set; }
		[Required(ErrorMessage = "AuthorName is required")]
		public string AuthorName { get; set; }
		[Required(ErrorMessage = "Genre is required")]
		public Genre Genre { get; set; }
		public byte GenreId { get; set; }
		public DateTime DateAdded { get; set; }
		[Required(ErrorMessage = "ReleaseDate is required")]
		public DateTime ReleaseDate { get; set; }
		[Required(ErrorMessage = "NumberInStock is required")]
		public int NumberInStock { get; set; }
		[Required(ErrorMessage = "NumberAvailable is required")]
		public int NumberAvailable { get; set; }
	}
      
}
