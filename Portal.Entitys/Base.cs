﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Entities
{
    public class Base(bool state = true)
    {
        public int Id { get; set; }
        public bool State { get; set; } = state;
    }
}
