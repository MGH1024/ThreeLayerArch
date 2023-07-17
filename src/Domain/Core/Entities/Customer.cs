using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigations
        public virtual int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
