﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BL
{
    public class Names
    {
        public string MakeFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
