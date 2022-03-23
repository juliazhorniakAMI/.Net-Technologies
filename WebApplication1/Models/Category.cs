using System;
using System.Collections.Generic;

#nullable disable

namespace TaxiServiceBD.Models
{
    public partial class Category
    {
        public Category()
        {
           
        }

        public int Id { get; set; }
        public string FullName { get; set; }

      
    }
}
