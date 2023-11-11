using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MVC_TEST_Q2.Models
{
   public interface IMovie
    {
        IEnumerable<Movie> getall();
        Movie getbyid(Movie id);
        void insert(Movie obj);
        void update(Movie obj);
        void delete(Movie obj);
        void save();
    }
    public class Repository : IMovie
    {
        MovieContext mc;
        DbSet<Movie> dbset;
        public Repository()
        {
            mc = new MovieContext();
            dbset = mc.Set<Movie>();
        }
        public IEnumerable<Movie> getall()
        {
            return dbset.ToList();
        }
        public void insert(Movie obj)
        {
            dbset.Add(obj);
        }
        public void update(Movie obj)
        {
            mc.Entry(obj).State = EntityState.Modified;
        }
        public void delete(Movie id)
        {
            Movie getbyid = dbset.Find(id);
            dbset.Remove(getbyid);
        }
        public void save()
        {
            mc.SaveChanges();
        }
        public Movie getbyid(Movie id)
        {
           return  dbset.Find(id);
          
        }
    }
}
