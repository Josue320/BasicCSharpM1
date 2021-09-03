using System;
using System.Collections.Generic;
using System.Text;

namespace Domainzzz
{
    public class Producto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Caducity { get; set; }
    }
}
