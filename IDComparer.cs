﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4PrototypeStrategy
{
    class IDComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
          return x.ID-y.ID;
        }
    }
}
