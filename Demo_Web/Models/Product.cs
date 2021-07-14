using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CatId { get; set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, string name, int catId) : this(id, name)
        {
            CatId = catId;
        }
    }
}
