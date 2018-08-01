using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_lab01.Models
{
    public class HeroesService
    {

        public List<Heroe> heroes = new List<Heroe>() {
              new Heroe { id= 11, name= "Mr. Nice" },
              new Heroe { id= 12, name= "Narco" },
              new Heroe { id= 13, name= "Bombasto" },
              new Heroe { id= 14, name= "Celeritas" },
              new Heroe { id= 15, name= "Magneta" },
              new Heroe { id= 16, name= "RubberMan" },
              new Heroe { id= 17, name= "Dynama" },
              new Heroe { id= 18, name= "Dr IQ" },
              new Heroe { id= 19, name= "Magma" },
              new Heroe { id= 20, name= "Tornado" }

            };


       public IEnumerable<Heroe> GetHeroes()
        {
            return heroes;
        }



    }
}
