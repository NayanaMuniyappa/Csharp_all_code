using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;

namespace MVC_TEST_2.Models
{
    public class Movies:DbContext
    {
        [Key]
        int Mid { get; set; }
        [Required]
         string MoviesName { get; set; }
        [Required]
        DateTime Date { get; set; }

       

    }
    public class db : DbContext
    {
        public DbSet<Movies> mov { get; set; }
        public db() : base("MovieContext")
        {
        }
        


        
    }

}