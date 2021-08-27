using System;
using System.Collections.Generic;
namespace subnet
{
    class router
    {
        private string name;
        private List<string> interfaces = new List<string>();
        private List<Interface_Info> interfaces_info = new List<Interface_Info>();
        private List<string> Commands = new List<string>();
        private List<string> networkIDs = new List<string>();
        private List<string> wildmasks = new List<string>();
        private List<string> areas = new List<string>();
        private string defaultRoute;
        private Boolean ospf_enable;
        private string oSPFID;
        private string oSPFProcess = "100";
        public router(string na)
        {
            name = na;
            Commands.Add("configure terminal");
            Commands.Add("hostname " + name);
        }

        public void AddInterface(string inter, string ip, string subnet, int oSPFArea, bool is_ipv6, bool linkLocal, string netID, string wildmask)
        {
            if (inter.Contains("."))
            {
                string[] vlan = inter.Split('.');
                if (interfaces.Contains(vlan[0]))
                {
                    interfaces.Add(vlan[0]);
                }
                interfaces_info[interfaces_info.Count - 1].New_Sub_Interface(inter, ip, subnet, oSPFArea, linkLocal, netID, wildmask);
            }
            else
            {
                if (!interfaces.Contains(inter))
                {
                    interfaces.Add(inter);
                    interfaces_info.Add(new Interface_Info() { Name = inter });
                    interfaces_info[interfaces.IndexOf(inter)].new_interface(inter, ip, subnet, oSPFArea, is_ipv6, linkLocal, netID, wildmask);
                }
            }
        }
        public void SetCommands()
        {
            
            if (defaultRoute != "")
                Commands.Add("ip route 0.0.0.0 0.0.0.0 " + defaultRoute);
            foreach (Interface_Info info in interfaces_info)
            {
                Commands.Add("interface " + info.Name);
                int i = 0;
                if (info.isIPv4() == true)
                {
                    addIP(info.Getipv4(), info.GetSubnet(), false, false);
                }
                foreach (string ip in info.getIPs())
                {

                    addIP(ip, info.GetPrefix(i), true, info.isLinkLocal(i));

                }
                Commands.Add("no shutdown");
            }
            if (ospf_enable == true)
            {
                Commands.Add("ip router ospf " + oSPFProcess); Commands.Add("  passive-interface default");
                foreach (Interface_Info info in interfaces_info)
                {
                    if (oSPFID != "")
                        Commands.Add(String.Format(" router-id {0}", oSPFID));
                    Commands.Add(String.Format("  network {0} {1} area {2}", info.networkID, info.wildcastMask, info.oSPFArea));
                    Commands.Add(String.Format("  no passive-interface {0}", info.Name));
                }
            }


        }
        public void SetSettings(String dr, bool oSPF, string oID)
        {
            defaultRoute = dr;
            ospf_enable = oSPF;
            oSPFID = oID;
        }

        public List<string> GetCommands()
        {
            return Commands;
        }
        private void addIP(string ip, string subnet, bool isIPV6, bool linkLocal)
        {
            if (!isIPV6)
            {
                Commands.Add("ip address " + ip + " " + subnet);
            }
            else
            {
                Commands.Add("ipv6 address " + ip + "/" + subnet);
                if (linkLocal)
                {
                    Commands.Add("ipv6 address FE01::1 link-local");
                }
            }
        }
    }
}