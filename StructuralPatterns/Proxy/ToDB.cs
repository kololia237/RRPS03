﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Proxy
{
    public class ToDB : IToDB
    {
        public string PerformRWOperations()
        {
            return "Performing Read Write operation on the Shared Folder";
        }
    }
}
