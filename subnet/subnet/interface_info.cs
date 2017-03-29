using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class @interface_info
    {
        public string name { get; set; }
        public List<string> ips = new List<string>();
        public List<string> subnets = new List<string>();
        private List<Sub_Interface> sub_interface = new List<Sub_Interface>();
        public void new_interface(string na) {
            name = na;
        }
        public void new_interface(string na, string ip, string sub)
        {
            name = na;
            ips.Add(ip);
            subnets.Add(sub);
        }
        public void new_address(string ip, string sub)
        {
            ips.Add(ip);
            subnets.Add(sub);
        }
        public void  New_Sub_Interface(string na, string ip, string subnet)
        {
            name = na;
            sub_interface.Add(new Sub_Interface(na,ip,subnet));
        }
        public string getName()
        {
            return name;
        }
        public List<string> getIPs()
        {
            return ips;
        }
        public List<string> getSubnet()
        {
            return subnets;
        }
        public string GetSubnet(int index)
        {
            return subnets[index];
        }
        public Boolean isSub()
        {
            if (sub_interface.Any())
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
