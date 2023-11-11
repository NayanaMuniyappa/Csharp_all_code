using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_TEST_Q2.Models
{
   // [Table("tbl_movies")]
    public class Movie
    {
        [Key]
        public int mid { get; set; }
        public string MoviesName {get; set;}
        public DateTime date { get; set; }
    }
}