using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //navigations
        public ICollection<Customer> Customers { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
