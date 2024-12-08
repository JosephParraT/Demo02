using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Product
    {
        //propiedades

        public int Id { get; }
        public string Name { get; }
        public string UnitPrice { get; }
        public string UnitsInStock { get; }
    
    //Constructor
    public Product(int id, string name, decimal unitPrice, int unitsInStock)
        {
            Id = id;
            Name = name;
            UnitPrice = UnitPrice;
            UnitsInStock = UnitsInStock;

        }
}
}