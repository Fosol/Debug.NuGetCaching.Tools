using NuGetCaching.Tool2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCaching.Tool1
{
    public class Employee : Person
    {
        public int Number { get; set; }

        public Employee()
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()}: {this.Number}";
        }
    }
}
