using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class IPV6_Vaildation
    {

        private int mask;
        private string networkBinary;
        private string hostsBinary;
        private string total_binary = "";
        private long hostsneeded;
        public bool CheckNetworkID(string input)
        {
            string good = "";
            good = good.PadLeft((128 - mask), '0');
            if (input == good)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getNetworkBinary()
        {
            return networkBinary;
        }
        public int GetOrginalMask()
        {
            return mask;
        }
        public String GetCurrentHostsBits()
        {
            return hostsBinary;
        }
        public long AddHosts(int hosts)
        {
            ///works out how hosts are needed in-order to sucessful subnet
            hosts += 2;
            long hosts_needed = 0;
            int power = 1;

            while ((long)Math.Pow(2, power) <= hosts)
            {
                // just increase the value until there is enough hosts avabille
                power++;
            }
            hosts_needed = (long)Math.Pow(2, power);
            ///end of code
            hostsneeded += hosts_needed;
            //cleaning up for the next time we go through the row.
            return hosts_needed;
        }
        public string[] checkifavilabile()
        {
            string[] message = new string[2];
            long hosts_available = 2 ^ (128 - mask);
            if(hosts_available >= hostsneeded)
            {
                message[0] = "1";
                return message;
            }
            message[0] = "0";
            long more_hosts = hostsneeded - hosts_available;
            message[1] = "There is no enough hosts available to fill your requirements by " + more_hosts + "hosts.";
            return message;
        }
    }
}
