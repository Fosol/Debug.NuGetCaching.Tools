using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetCaching.Tool2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
