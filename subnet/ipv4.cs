using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class ipv4
    {
        private int[] octects = new int[4];
        private int hosts_bits;
        private int interestingOctet;
        private string binary;
        public static string check(string ip)
        {
            String message = "";
            // checking  if ip have 4 octets
            string[] octects = ip.Split('.');
            if (octects.Length != 4)
            {
                message = (ip + " is a Invaild IP as not having 4 octets.");
                return message;
            }
            //end
            string totalbinary = "";
            foreach (string octet_check in octects)
            {
                //try needed incase of the convert fail
                try
                {
                    if (Convert.ToInt32(octet_check) >= 256)
                    {
                        message = (ip + " is a Invaild IP, as " + octet_check + " is higher than 255.");
                        return message;
                    }
                    else
                    {
                        totalbinary += IPV4_convertors.ToBinary(Convert.ToInt32(octet_check));
                    }

                }
                catch
                {
                    return ip + " is a invaild IP.";
                }
            }
            return "-1/" + totalbinary;
        }

        private void processInterestingOctet()
        {
            //finding which octet is the start of host bits
            if (hosts_bits <= 8)
            {
                interestingOctet = 3;
            }
            else if (hosts_bits <= 16)
            {
                interestingOctet = 2;
            }
            else if (hosts_bits <= 24)
            {
                interestingOctet = 1;
            }
            else
            {
                interestingOctet = 0;
            }
        }
        public int getInterestingOctet()
        {
            return interestingOctet;
        }

        }
    }
