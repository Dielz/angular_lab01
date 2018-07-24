using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_lab01.Models
{
    public class LabContext : DbContext
    {
        public DbSet<Heroe> Heroes { get; set; }


    }
}
