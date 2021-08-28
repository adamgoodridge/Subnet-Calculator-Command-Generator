namespace subnet
{
    using System;

    class ip
    {
        public int IP_Type { get; set; }
        private int hostsneeded;
        private string userinput;
        private int mask;
        public String wildcardMask { set; get; }
        private string orginal_networkid;
        private string hostsBinary;
        private string networkBinary;
        private string binary;
        private int hostsDecimnal;
        //what is used to put the gui table
        string currentNetwork, nextNetworkid, currentFirstUsable, currentLastUsable, currentBroadcast, currentSubnet;
        //end
        private int hosts_assigned = 0;
        private int currentHostDecimal;
        private string currentNetworkBinary;
        public void SetUserinput(string ni)
        {
            userinput = ni;
        }
        public string GenerateWildcardMask()
        {
            string subnet_binary = "".PadLeft(mask, '0').PadLeft(32, '1');
            return IP_TOOLS.BinaryTOIPv4(subnet_binary);
        }
        // no exception means the input is vaild
        public string CheckVaildation()
        {
            string[] input = userinput.Split('/');
            orginal_networkid = input[0];
            try
            {
                mask = int.Parse(input[1]);
            }
            catch
            {
                throw new Exception_Message(mask + " isn't a invalid mask.");
            }
            if (IP_Type == 4)
            {
                if (mask < 32)
                {
                    binary = IP_TOOLS.IPv4ToBinary(orginal_networkid);
                    try
                    {
                        networkBinary = binary.Substring(0, mask);
                        //with referring mask right bellow it take off the first character off of the amount of mask
                        hostsBinary = binary.Substring(mask, 32 - mask);
                    }
                    catch (Exception_Message)
                    {
                        throw new Exception_Message(mask + " isn\'t a invalid mask.");
                    }
                }
                else
                    throw new Exception_Message(mask + " can\'t higher than 32.");
                if (Determine_vaild_id() == false)
                    throw new Exception_Message(orginal_networkid + " isn\'t a vaild network ID.");
            }
            else
            {
                if (mask > 128)
                {
                    return mask + " isn't a invaild mask.";
                }
                binary = ipv6.check(orginal_networkid);

            }
            nextNetworkid = orginal_networkid;

            return "-1";

        }
        double numofhosts;
        bool toobig;
        int interest_bit;
        int numofnetworks;
        public int prefix;
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
                    currentSubnet = interest_bit.ToString();
                    numofnetworks = pow;
                }
                if (IP_Type == 4)
                {
                    string subnet_binary = "".PadLeft(interest_bit, '0').PadLeft(max + 2, '1');
                    currentSubnet = IP_TOOLS.BinaryTOIPv4(subnet_binary);
                }
            }
        }

        internal bool getIsIPV6()
        {
            return IP_Type == 6;
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
            return (IP_Type == 4) ? 32 : 128;
        }
        public bool Determine_vaild_id()
        {
            string good = "".PadLeft((((IP_Type == 4) ? 32 : 128) - mask), '0');
            return (hostsBinary == good);
        }
        private double calculate_available_hosts()
        {
            return Math.Pow(2, CalculateMaxMask() - mask);
        }
        public void add_hosts(int hosts)
        {
            hostsneeded += hosts;
        }
        public string Compare_Hosts()
        {
            if (hostsneeded <= calculate_available_hosts())
                return "-1";
            else if (hostsneeded == 0)
                throw new Exception_Message("You don't have any networks defined.");
            else
            {
                //-(formula) removes "-" from the negative.
                double missing = -(calculate_available_hosts() - hostsneeded);
                return "You don't have enough hosts to meet requirements by " + missing + " hosts.";
            }
        }


        public int CalculateSpaceRequired(int hosts)
        {
            int pow;
            for (int i = 1; i <= 32; i++)
            {
                pow = Convert.ToInt32(Math.Pow(2, i));
                if (pow >= hosts)
                {
                    int hosts_bits = i - pow;
                    string subnet_binary = "".PadLeft(i, '0').PadLeft(32, '1');
                    mask = i;
                    currentSubnet = IP_TOOLS.BinaryTOIPv4(subnet_binary);

                    return pow;

                }
            }
            return -1;
        }
        public string GetCurrentSubnet()
        {
            return currentSubnet;
        }
        public void SetCurrentInfo6(int wanted_networks)

        {
            int i = 0;
            while (Math.Pow(2, i) < wanted_networks)
            {
                i++;
            }
            currentNetwork = IPV6_Convertors.binarytoipv6(binary);
            currentNetworkBinary = binary;
            networkBinary = binary.Substring(0, mask);
            binary = AddIPV6(64 - i);
            prefix = 64 - i;


        }
        public int GetPrefix()
        {
            return prefix;
        }
        public string AddIPV6(int interest_bit)
        {
            string int_binary = binary.Substring(mask, 64);
            string add_binary = "1".PadLeft(interest_bit, '0');
            string sum = "";
            int sub_sum;
            int reminder = 0;
            for (int ii = add_binary.Length - 1; ii >= 0; ii--)
            {
                sub_sum = (int)(reminder + char.GetNumericValue(int_binary[ii]) + Char.GetNumericValue(add_binary[ii]));
                if (sub_sum == 3)
                    reminder = 1;
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
                    reminder = 0;
                    ii = -1;
                }
            }
            sum = binary.Substring(0, 64 - sum.Length) + sum;
            return sum.PadRight(128, '0');
        }
        public void SetCurrentInfo4(int hosts_needed)
        {
            currentNetwork = nextNetworkid;
            //end 
            // works out First Usable
            binary = Convert.ToString(hostsDecimnal + 1, 2).PadLeft(32 - networkBinary.Length, '0');
            currentFirstUsable = IP_TOOLS.BinaryTOIPv4(networkBinary + binary);
            //end
            // works out Last Usable
            binary = Convert.ToString(hostsDecimnal + (hosts_needed - 2), 2).PadLeft(32 - networkBinary.Length, '0');
            currentLastUsable = IP_TOOLS.BinaryTOIPv4(networkBinary + binary);
            //end
            // works out Broadcast ID
            binary = Convert.ToString(hostsDecimnal + (hosts_needed - 1), 2).PadLeft(32 - networkBinary.Length, '0');
            currentBroadcast = IP_TOOLS.BinaryTOIPv4(networkBinary + binary);
            //end
            wildcardMask = GenerateWildcardMask();
            //set next NetworkID
            binary = Convert.ToString(hostsDecimnal + (hosts_needed), 2).PadLeft(32 - networkBinary.Length, '0');
            nextNetworkid = IP_TOOLS.BinaryTOIPv4(networkBinary + binary);
            // getting ready to assign hosts.
            binary = Convert.ToString(hostsDecimnal, 2).PadLeft(32 - networkBinary.Length, '0');
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
            if (IP_Type == 4)
            {
                binary = Convert.ToString(currentHostDecimal + hosts_assigned, 2).PadLeft(32 - mask, '0');
                return IP_TOOLS.BinaryTOIPv4(networkBinary + binary);
            }
            else
            {
                return IPV6_Convertors.binarytoipv6(currentNetworkBinary);
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
    }
}
