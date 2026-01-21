using CountryWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CountryWebAPI.Controllers
{
    [RoutePrefix("Country")]
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
        {
            new Country{ID=1, CountryName="India", Capital="New Delhi"},
            new Country{ID=2, CountryName="USA", Capital="Washington DC"},
            new Country{ID=3, CountryName="France", Capital="Paris"},
            new Country{ID=4, CountryName="United Kingdom", Capital="London"},
            new Country{ID=5, CountryName="Germany", Capital="Berlin"}
        };

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            return Ok(countries);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();
            return Ok(country);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(Country country)
        {
            countries.Add(country);
            return Ok(countries);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Update(int id, Country country)
        {
            var exist = countries.FirstOrDefault(c => c.ID == id);
            if (exist == null)
            {
                return NotFound();
            }
            exist.CountryName = country.CountryName;
            exist.Capital = country.Capital;

            return Ok(exist);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();
            countries.Remove(country);
            return Ok(countries);
        }
    }
}
