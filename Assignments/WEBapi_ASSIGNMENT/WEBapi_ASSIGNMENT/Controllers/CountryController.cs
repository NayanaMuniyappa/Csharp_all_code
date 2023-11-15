using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBapi_ASSIGNMENT.Models;

namespace WEBapi_ASSIGNMENT.Controllers
{
    
    public class CountryController : ApiController
    {
        private static List<COUNTRYclass> countries = new List<COUNTRYclass>
    {
        new COUNTRYclass { ID = 1, CountryName = "Inadia", Capital = "Delhi" },
        new COUNTRYclass { ID = 2, CountryName = "Japan", Capital = "Tokyo" },
        new COUNTRYclass { ID = 3, CountryName = "Iran", Capital = "Tehran" }
    };

        // GET: api/Country
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        // GET: api/Country/1
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/Country
        public IHttpActionResult Post([FromBody] COUNTRYclass country)
        {
            country.ID = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }

        // PUT: api/Country/1
        public IHttpActionResult Put(int id, [FromBody] COUNTRYclass updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;

            return Ok(country);
        }

        // DELETE: api/Country/1
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);

            return Ok(country);
        }
    }
}
