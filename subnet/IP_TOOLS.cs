using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class IP_TOOLS
    {
        private static readonly string WRONG_FORMAT = "IP is in the wrong format, it should contain \".\" or \":\"";
        public static string ToBinary(int dem)
        {
            return Convert.ToString(dem, 2).PadLeft(8, '0');
        }

        public static IP_Type Determine_Type(String userinput)
        {
            if (!userinput.Contains("/"))
                throw new Exception_Message(WRONG_FORMAT);
            if (userinput.Contains("."))
                return IP_Type.IPv4;
            else if (userinput.Contains(":"))
                return IP_Type.IPv4;
            else
                throw new Exception_Message(WRONG_FORMAT);
        }
        public static String Add_Binary(String binA, String binB)
        {
            if (binA.Length > binB.Length)
                binB = binB.PadLeft(binA.Length, '0');
            else
                binA = binA.PadLeft(binB.Length, '0');
            int carry = 0;
            char[] a = binA.ToCharArray(), b = binB.ToCharArray();
            char[] charOutput = new char[a.Length];
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int a0 = Convert.ToInt32(char.GetNumericValue(a[i]));
                int b0 = Convert.ToInt32(char.GetNumericValue(b[i]));
                int sum = carry + a0 + b0;
                int rem = sum % 2;
                carry = sum - rem;
                if (carry == 2)
                    carry = 1;
                charOutput[i] = rem.ToString().ToCharArray()[0];
            }
                return new string(charOutput);
        }
        public static string BinaryTOIPv4(string currentip_bin)
        {
            /// making a array for octets 
            string[] nnetwork = new string[4];
            string newip;
            ///adding the leading 0
            currentip_bin = currentip_bin.PadLeft(32, '0');
            nnetwork[0] = currentip_bin.Substring(0, 8);
            nnetwork[1] = currentip_bin.Substring(8, 8);
            nnetwork[2] = currentip_bin.Substring(16, 8);
            nnetwork[3] = currentip_bin.Substring(24, 8);
            // converting each octet back to deminal
            newip = Convert.ToInt32(nnetwork[0], 2) + "." + Convert.ToInt32(nnetwork[1], 2) + "." + Convert.ToInt32(nnetwork[2], 2) + "." + Convert.ToInt32(nnetwork[3], 2);
            /// returin the new ip
            return newip;
        }

        public static String IPv4ToBinary(string ip)
        {
            // checking  if ip have 4 octets
            string[] octects = ip.Split('.');
            if (octects.Length != 4)
                throw new Exception_Message(ip + " is a Invaild IP as not having 4 octets.");
            //end
            string totalbinary = "";
            foreach (string octect in octects)
            {
                //try needed incase of the convert fail
                try
                {
                    if (Convert.ToInt32(octect) >= 256)
                        throw new Exception_Message(ip + " is a Invaild IP, as " + octect + " is higher than 255.");
                    else
                        totalbinary += IP_TOOLS.ToBinary(Convert.ToInt32(octect));
                }
                catch
                {
                    throw new Exception_Message(ip + " is an invaild IP.");
                }
            }
            return totalbinary;
        }
    }
    }
