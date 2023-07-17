﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigations
        public ICollection<City> Cities { get; set; }
    }
}
