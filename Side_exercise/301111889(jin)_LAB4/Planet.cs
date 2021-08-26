using System;
using System.Collections.Generic;
using System.Text;

namespace _301111889_jin__LAB4
{
    class Planet : System.Data.Entity.DbContext
    {
        public int PlanetId { get; set; }
        public string Name2 { get; set; }
        public string Color2 { get; set; }
    }
}
