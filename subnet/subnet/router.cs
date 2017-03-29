using System;
using System.Collections.Generic;
namespace subnet
{
    class router
    {
        private string name;
        private List<string> interfaces = new List<string>();
        private List<interface_info> interfaces_info = new List<interface_info>();
        private List<string> Commands = new List<string>();
        public router(string na)
        {
            name = na;
            Commands.Add("configure terminal");
            Commands.Add("hostname " + name);
        }

        public void AddInterface(string inter, string ip, string subnet)
        {
            if (inter.Contains("."))
            {
                string[] vlan = inter.Split('.');
                if (interfaces.Contains(vlan[0]))
                {
                    interfaces.Add(vlan[0]);
                }
                interfaces_info[interfaces_info.Count - 1].New_Sub_Interface(inter, ip, subnet);
            } else
            {
                if (!interfaces.Contains(inter)) {
                    interfaces.Add(inter);
                    interfaces_info.Add(new interface_info() { name = inter });
                }
                interfaces_info[interfaces.IndexOf(inter)].new_address(ip, subnet);
            }
        }
        public void SetCommands(bool isIPV6, bool linkLocal)
        {
            foreach (interface_info info in interfaces_info)
            {
                Commands.Add("interface " + info.name);
                int i = 0;
                foreach (string ip in info.getIPs())
                {

                    addIP(ip, info.GetSubnet(i), isIPV6, linkLocal);

                }
                Commands.Add("no shutdown");
            }
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
