using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC_TEST_2.Models
{
    public partial class Model1 : DbContext
    {

        public Model1()
            : base("name=MovieContext")
        {
        }
        public DbSet<Movies> Movies { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
