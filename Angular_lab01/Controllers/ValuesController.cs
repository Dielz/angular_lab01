using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_lab01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Angular_lab01.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private HeroesService hs;

        public ValuesController(HeroesService heroesService) {

            this.hs = heroesService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Heroe> Get()
        {
            return hs.GetHeroes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Heroe Get(int id)
        {
            return hs.GetHeroes().FirstOrDefault(p => p.id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
