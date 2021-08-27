using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class Interface_Info
    {
        public string Name { get; set; }
        private string ipv4;
        private Boolean Is_IPV4 = false;
        private string subnet;
        public List<string> ips = new List<string>();
        public List<string> prefixes = new List<string>();
        public List<Boolean> linkLocal = new List<Boolean>();
        public int oSPFArea { get; set; }
        public string networkID { get; set; }
        public string wildcastMask { get; set; }
        private List<Sub_Interface> sub_interface = new List<Sub_Interface>();
        public void new_interface(string na) {
            Name = na;
        }
        public void new_interface(string na, string ip, string sub, int area, Boolean ipsix, Boolean lLocal, string netID, string wildcastMask)
        {
            Name = na;
            if (ipsix == false)
            {
                ipv4 = ip;
                subnet = sub;
                Is_IPV4 = true;
                oSPFArea = area;
                networkID = netID;
                this.wildcastMask = wildcastMask; 
            }
            else
            {
                ips.Add(ip);
                prefixes.Add(sub);
                linkLocal.Add(lLocal);
            }
            
                oSPFArea=area;
        }
        public void  New_Sub_Interface(string na, string ip, string subnet, int oSPFArea, Boolean linkLocal, string netID, string wildmask)
        {
            Name = na;
            sub_interface.Add(new Sub_Interface(na,ip,subnet,oSPFArea, linkLocal,netID,wildmask));
        }
        public Boolean isLinkLocal(int i)
        {
            return linkLocal[i]; 
        }
        public string Getipv4()
        {
            return ipv4;
        }
        public Boolean isIPv4()
        {
            return Is_IPV4;
        }
        public List<string> getIPs()
        {
            return ips;
        }
        public string GetSubnet()
        {
            return subnet;
        }
        public string GetPrefix(int index)
        {
            return prefixes[index];
        }
    }
}
