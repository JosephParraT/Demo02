using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLibrary
{
    public class Book : Product
    {
        public string  Title { get; }
        public Book(int id, string name, decimal UnitPrice, int unitInStock, string title) : base(id,name,UnitPrice,unitInStock)
        {
            Title = title;
        }
    }

    public class Book2(int id, string name, decimal UnitPrice, int unitInStock, string title) : Product(id, name, UnitPrice, unitInStock)
    {
        public string Title => title;




    }



}
