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
        private string ipv4;
        private Boolean is_ipv4 = false;
        private string subnet;
        public List<string> ips = new List<string>();
        public List<string> prefixes = new List<string>();
                public List<Boolean> linkLocal = new List<Boolean>();
        public int oSPFArea { get; set; }
        public string networkID { get; set; }
        public string networkwildmask { get; set; }
        private List<Sub_Interface> sub_interface = new List<Sub_Interface>();
        public void new_interface(string na) {
            name = na;
        }
        public void new_interface(string na, string ip, string sub, int area, Boolean ipsix, Boolean lLocal, string netID, string wildmask)
        {
            name = na;
            if (ipsix == false)
            {
                ipv4 = ip;
                subnet = sub;
                is_ipv4 = true;
                oSPFArea = area;
                networkID = netID;
                
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
            name = na;
            sub_interface.Add(new Sub_Interface(na,ip,subnet,oSPFArea, linkLocal,netID,wildmask));
        }
        public Boolean isLinkLocal(int i)
        {
            return linkLocal[i]; 
        }
        public string getName()
        {
            return name;
        }
        public string Getipv4()
        {
            return ipv4;
        }
        public Boolean isIPv4()
        {
            return is_ipv4;
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
