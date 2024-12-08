using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Product(int id, string name, decimal unitPrice, int unitsInStock)
    {
        //propiedades

        public int Id { get; } = id;
        public string Name { get; } = name;
        public decimal UnitPrice { get; } = unitPrice;
        public int UnitsInStock { get; } = unitsInStock;
    
        public bool Discontinued { get; private set; }
        public bool SetDiscontinued() => Discontinued = true;

        public bool GetStatus() => Discontinued = Discontinued;
    }
}