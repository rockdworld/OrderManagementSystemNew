using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMgmtSystem.UI.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public string Packing { get; set; }
        public int Rating { get; set; }
    }
}
