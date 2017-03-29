using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class Sub_Interface
    {
        private string name { get; set; }
        private string ip { get; set; }
        private string subnet { get; set; }
        public Sub_Interface(string na, string address, string sub)
        {
            name = na;
            ip = address;
            subnet = sub;
        }
    }
}
