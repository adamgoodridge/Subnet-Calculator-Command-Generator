namespace subnet
{
    using System;

    class ip
    {
        private int ipType;
        private int hostsneeded;
        private string message;
        private string userinput;
        private int mask;
        private string orginal_networkid;
        private string hostsBinary;
        private string networkBinary;
        private string binary;
        private int hostsDecimnal;
        //what is used to put the gui table
        string currentNetwork, nextNetworkid;
        string currentFirstUsable;
        string currentLastUsable;
        string currentBroadcast;
        string currentsubnet;
        //end
        private int hosts_assigned = 0;
        private int currentHostDecimal;
        private int networkMask;
        private Boolean isIPV6;
        public void SetUserinput(string ni)
        {
            userinput = ni;
        }
        public string determine_type()
        {
            if (userinput.Contains("/"))
            {
                if (userinput.Contains("."))
                {
                    ipType = 4;
                    isIPV6 = false;
                }
                else if (userinput.Contains(":"))
                {
                    ipType = 6;
                    isIPV6 = true;
                }
                else
                {
                    return "IP is in the right format, it should contain \".\" or \":\"";
                }
            }
            else
            {
                return "IP is in the right format, it should something like ip/mask";
            }
            return "-1";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CheckVaildation()
        {
            string[] input = userinput.Split('/');
            orginal_networkid = input[0];
            try
            {
                mask = Convert.ToInt32(input[1]);
            }
            catch
            {
                return mask + " isn't a invaild mask.";
            }
            if (ipType == 4)
            {
                if (mask < 32)
                {
                    message = ipv4.check(orginal_networkid);
                    if (!(message.Contains("-1/")))
                    {
                        return message;
                    }
                    //meaning remove -1/ from the start
                    binary = message.Substring(3);
                    try
                    {
                        networkBinary = binary.Substring(0, mask);
                        //with referring mask right bellow it take off the first character off of the amount of mask
                        hostsBinary = binary.Substring(mask, 32 - mask);
                    }
                    catch
                    {
                        return mask + " isn't a invaild mask.";
                    }
                }
                else
                {
                    return mask + " can't higher than 32.";
                }

                if (Determine_vaild_id() == false)
                {
                    return orginal_networkid + " isn't a vaild network ID.";
                }
            }
            else
            {
                if (mask > 128)
                {
                    return mask + " isn't a invaild mask.";
                }

                binary = subnet.ipv6.check(orginal_networkid);

            }
            nextNetworkid = orginal_networkid;
            return "-1";

        }
        double numofhosts;
        bool toobig;
        int interest_bit;
        int numofnetworks;
        public void SetNumOfNetworks(int wanted)
        {
            int pow;
            int max = (CalculateMaxMask() - mask);
            for (int i = 1; i <= max; i++)
            {
                pow = Convert.ToInt32(Math.Pow(2, i));
                if (pow >= wanted)
                {
                    if (numofhosts > 1000000)
                    {
                        numofhosts = Math.Pow(2, (max - i));
                        toobig = false;
                    }
                    else
                    {
                        numofhosts = 0;
                        toobig = true;

                    }
                    interest_bit = i + mask;
                    //get out of the loop quickly as it is pointless now
                    i = max + 1;
                    currentsubnet = interest_bit.ToString();
                    numofnetworks = pow;
                }
                if (ipType == 4)
                {
                    string subnet_binary = "".PadLeft(interest_bit, '0').PadLeft(max + 2, '1');
                    currentsubnet = binary_to_ipv4.format(subnet_binary);
                }
            }
        }
        public int GetInterestBit()
        {
            return interest_bit;
        }
        public bool Checkiflarge()
        {
            return toobig;
        }
        public int GetNumberofNetworks()
        {
            return numofnetworks;
        }
        public double GetNumofHosts()
        {
            return numofhosts;
        }
        public int CalculateMaxMask()
        {
            if (ipType == 4)
            {
                return 32;
            }
            return 128;
        }
        public bool Determine_vaild_id()
        {
            string good = "";
            if (ipType == 4)
            {
                good = good.PadLeft((32 - mask), '0');
            }
            else
            {
                good = good.PadLeft((128 - mask), '0');
            }
            if (hostsBinary == good)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private double calculate_available_hosts()
        {
            double ava;
            ava = (Math.Pow(2, (CalculateMaxMask() - mask)));
            return ava;
        }
        public void add_hosts(int hosts)
        {
            hostsneeded += hosts;
        }
        public string Compare_Hosts()
        {
            if (hostsneeded <= calculate_available_hosts())
            {
                return "-1";
            }
            else if (hostsneeded == 0)
            {
                return "You don't have any networks defined.";
            }
            else
            {
                //-(formula) removes "-" from the negative.
                double missing = -(calculate_available_hosts() - hostsneeded);
                return "You don't have enough hosts to meet requirements by " + missing + " hosts.";
            }
        }
        int current_subnet;
        public int CalculateSpaceRequired6(int hosts)
        {
            int pow;
            int max = CalculateMaxMask();
            for (int i = 1; i <= max; i++)
            {
                pow = Convert.ToInt32(Math.Pow(2, i));
                if (pow >= hosts)
                {
                    if (max == 30)
                    {
                        int hosts_bits = i - pow;
                        string subnet_binary = "".PadLeft(i, '0').PadLeft(max + 2, '1');
                        currentsubnet = binary_to_ipv4.format(subnet_binary);
                    }
                    else
                    {
                        currentsubnet = (128 - i).ToString();
                    }
                    interest_bit = i;
                    return pow;
                }
            }
            return -1;
        }
        public bool getIsIPV6()
        {
            return isIPV6;
        }
        public int CalculateSpaceRequired(int hosts)
        {
            int pow;
            int max = CalculateMaxMask();
            for (int i = 1; i <= max; i++)
            {
                pow = Convert.ToInt32(Math.Pow(2, i));
                if (pow >= hosts)
                {
                    if (max == 32)
                    {
                        int hosts_bits = i - pow;
                        string subnet_binary = "".PadLeft(i, '0').PadLeft(max + 2, '1');
                        currentsubnet = binary_to_ipv4.format(subnet_binary);
                    }
                    else
                    {
                        currentsubnet = (128 - i).ToString();
                    }
                    return pow;
                }
            }
            return -1;
        }
        public string GetCurrentSubnet()
        {
            return currentsubnet;
        }
        public void SetCurrentInfo6(int interest_bit)
        {
            networkMask = interest_bit;
            currentNetwork = IPV6_Convertors.binarytoipv6(binary);
            binary = binary.Substring(0, interest_bit);
            currentBroadcast = IPV6_Convertors.binarytoipv6(binary.PadRight(128, '1'));
            networkBinary = binary.Substring(0, mask);

        }
        public string AddIPV6(int interest_bit)
        {
            string add_binary = "1".PadLeft(interest_bit - mask, '0');
            string sum = "";
            int sub_sum;
            int reminder = 0;
            string int_binary = binary.Substring(mask, interest_bit - mask);
            for (int ii = add_binary.Length - 1; ii >= 0; ii--)
            {
                sub_sum = (int)(reminder + char.GetNumericValue(int_binary[ii]) + Char.GetNumericValue(add_binary[ii]));
                if (sub_sum == 3)
                {
                    reminder = 1;
                    sub_sum = 1;
                }
                else if (sub_sum == 2)
                {
                    reminder = 1;
                    sub_sum = 0;
                    sum = sub_sum.ToString() + sum;
                }
                else if (sub_sum == 1)
                {
                    reminder = 0;
                    ii = -1;
                    sub_sum = 1;
                    sum = sub_sum.ToString() + sum;
                }
                else
                {
                    sub_sum = 0;
                    reminder = 0;
                    ii = -1;
                }
            }
            sum = binary.Substring(0, interest_bit - sum.Length) + sum;
            return sum;
        }
        
        public void SetCurrentInfo4(int hosts_needed)
        {
           
            // works out network id
            currentNetwork = nextNetworkid;
            //end 
            // works out First Usable
            binary = Convert.ToString(hostsDecimnal + 1, 2).PadLeft(32 - mask,'0');
            currentFirstUsable = binary_to_ipv4.format(networkBinary + binary);
            //end
            // works out Last Usable
            binary = Convert.ToString(hostsDecimnal + (hosts_needed - 2),2).PadLeft(32 - mask,'0');
            currentLastUsable = binary_to_ipv4.format(networkBinary + binary);
            //end
            // works out Broadcast ID
            binary = Convert.ToString(hostsDecimnal + (hosts_needed - 1),2).PadLeft(32 - mask,'0');
            currentBroadcast = binary_to_ipv4.format(networkBinary + binary);
            //end

            //set next NetworkID
            binary = Convert.ToString(hostsDecimnal + (hosts_needed),2).PadLeft(32 - mask, '0');
            nextNetworkid = binary_to_ipv4.format(networkBinary + binary);
            // getting ready to assign hosts.
            binary = Convert.ToString(hostsDecimnal, 2).PadLeft(32 - mask, '0');
            currentHostDecimal = hostsDecimnal;
            hostsDecimnal += hosts_needed;
             


        }
        public string GetcurrentNetwork()
        {
            return currentNetwork;
        }

        public string GetcurrentFirstUsable()
        {
            return currentFirstUsable;
        }

        public string GetAvailable()
        {
            hosts_assigned++;
            if(ipType==4)
            {
                binary = Convert.ToString(currentHostDecimal + hosts_assigned,2).PadLeft(32-mask,'0');
                return binary_to_ipv4.format(networkBinary + binary);
            } else {
                binary = Convert.ToString((hosts_assigned), 2).PadLeft(128 - networkBinary.Length, '0');
                return IPV6_Convertors.binarytoipv6(networkBinary + binary);
            }
        } 
        public string GetcurrentLastUsable()
        {
            return currentLastUsable;
        }

        public string GetcurrentBroadcast()
        {
            return currentBroadcast;
        }
        public int GetIPType()
        {
            return ipType;
        }
    }
}
