﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone_Num { get; set; }
        public int Age { get; set; }
    }
}
