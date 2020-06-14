﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CovidMovieMadness___Tenta.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50), RegularExpression(@"[a-zA-Z0-9]")]
        public string Name { get; set; }
        [Required]
        [StringLength(50), RegularExpression(@"[a-zA-Z0-9]")]
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }

        public virtual Post Post { get; set; }
    }
}