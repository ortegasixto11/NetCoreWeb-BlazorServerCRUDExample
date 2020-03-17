using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerCRUDExample.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
