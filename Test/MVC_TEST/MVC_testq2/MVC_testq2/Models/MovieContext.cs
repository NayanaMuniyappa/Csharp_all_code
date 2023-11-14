using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_testq2.Models
{
    public class MovieContext:DbContext
    {
       public DbSet<Movie> dbmov { get; set; }
    }
}