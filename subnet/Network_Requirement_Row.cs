using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class Network_Requirement_Row
    {
        public String name { get; set; }
        public int Amount_Host { get; set; }

        public String routers { get; set; }
        public int OSPF_Area { get; set; }
    }
}
