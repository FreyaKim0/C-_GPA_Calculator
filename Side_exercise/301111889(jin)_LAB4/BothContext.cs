using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace _301111889_jin__LAB4
{
    class BothContext : DbContext
    {
        public BothContext() : base() { }

        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Planet> Planets { get; set; }
    }
}
