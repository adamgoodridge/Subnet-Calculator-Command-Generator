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
        public List<string> ips = new List<string>();
        private List<string> subnets = new List<string>();
        private List<Boolean> linkLocal = new List<bool>();
        private int oSPFArea { get; set; }

        public string networkID { get; set; }
        public string networkwildmask { get; set; }
        public Sub_Interface(string na, string address, string sub, int area, Boolean linkLocal, string net, string wild)
        {
            name = na;
            ips.Add(address);
            subnets.Add(sub);
            oSPFArea = area;
            networkID = net;
            networkwildmask = wild;
        }
    }
}
