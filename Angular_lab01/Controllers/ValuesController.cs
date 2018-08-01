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
        [HttpGet("{id?}")]
        public object Get(int? id, string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                string q = name.ToLower();
                return hs.GetHeroes().Where(p => p.name.ToLower().Contains(q));
            }

            if (!id.HasValue)
            {
                return null;
            }

            return hs.GetHeroes().FirstOrDefault(p => p.id == id);
        }

        // POST api/values
        [HttpPost]
        public Heroe Post([FromBody]Heroe heroe)
        {
            heroe.id = this.hs.heroes.Last().id + 1;
            this.hs.heroes.Add(heroe);

            return heroe;
        }

        // PUT api/values
        [HttpPut]
        public void Put([FromBody]Heroe heroe)
        {
            int index = this.hs.heroes.FindIndex(p => p.id == heroe.id);
            this.hs.heroes[index].name = heroe.name;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Heroe heroe = this.hs.heroes.First(p => p.id == id);
            this.hs.heroes.Remove(heroe);

        }
    }
}
