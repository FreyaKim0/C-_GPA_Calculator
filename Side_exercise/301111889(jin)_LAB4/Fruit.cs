using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace _301111889_jin__LAB4
{
    class Fruit: System.Data.Entity.DbContext
    {
        public int FruitId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
