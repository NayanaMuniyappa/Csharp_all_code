using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_TEST_Q2.Models
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext():base("connectionstr")
        {

        }
    }
}