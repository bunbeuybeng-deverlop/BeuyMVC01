using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class Product
    {
        public int Id {get;set;}
        public String Name {get;set;} = string.Empty;
        public decimal Price {get;set;}
        public int Qty {get;set;}

        public Product(int id, String name,decimal price , int qty )
        {
            Id = id;
            Name = name ;
            Price = price;
            Qty = qty;
            
        }
        public decimal Calculator()=> Price * Qty;
    }
}