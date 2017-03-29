using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class binary_to_ipv4
    {
        public static string format(string currentip_bin)
        {
            /// making a array for octets 
            string[] nnetwork = new string[4];
            ///end

            string newip;
            ///adding the leading 0
            currentip_bin = currentip_bin.PadLeft(32, '0');
            ///end
            nnetwork[0] = currentip_bin.Substring(0, 8);
            nnetwork[1] = currentip_bin.Substring(8, 8);
            nnetwork[2] = currentip_bin.Substring(16, 8);
            nnetwork[3] = currentip_bin.Substring(24, 8);
            // converting each octet back to deminal
            newip = Convert.ToInt32(nnetwork[0], 2) + "." + Convert.ToInt32(nnetwork[1], 2) + "." + Convert.ToInt32(nnetwork[2], 2) + "." + Convert.ToInt32(nnetwork[3], 2);
            /// returin the new ip
            return newip;
        }
    }
}
