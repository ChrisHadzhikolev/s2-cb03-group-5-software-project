using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMB
{
    public class Department
    {
        public string Name { get; private set; }
        public Department(string name)
        {
            Name = name;
        }
        
    }
}
