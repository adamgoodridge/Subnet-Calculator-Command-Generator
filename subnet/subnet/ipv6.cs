using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class ipv6
    {
        public static string check(string ipv6)
        {
            string delimiter = "::";
            //http://stackoverflow.com/questions/1254577/string-split-by-multiple-character-delimiter
            string[] double_col = ipv6.Split(new[] { delimiter }, StringSplitOptions.None);
            if (double_col.Length > 2)
            {
                return "You can only use \"::\" once.";
            }
            delimiter = ":";
            string[] hexoctet_input = ipv6.Split(new[] { delimiter }, StringSplitOptions.None);
            //checking if it is a full IPV6 address  by ensuring there is only one :: if it is SHORTED OR has 8 :
            if (hexoctet_input.Length != 8 && (!ipv6.Contains("::")))
            {
                return ipv6 + "is a incomplete IPV6 address.";
            }
            else
            {
                int hexoctet = 0;

                string[] binary_result;

                string total_binary = "";
                string[] hexoctets = new string[8];
                for (int hexoctet_input_l = 0; hexoctet_input_l < hexoctet_input.Length; hexoctet_input_l++)
                {
                    if (hexoctet_input[hexoctet_input_l] != "")
                    {
                        hexoctets[hexoctet] = hexoctet_input[hexoctet_input_l];
                        binary_result = IPV6_Convertors.binary(hexoctet_input[hexoctet_input_l]);
                        if (binary_result[0] == "0")
                        {
                            return binary_result[1];
                        }
                        else
                        {
                            total_binary = total_binary + binary_result[1];
                        }
                        hexoctet++; 
                    }
                    else { 
                        //filling hexoctet if there is nothing in there
                        int empty = 8 - hexoctet_input_l;
                        for (int ii = 1; ii < empty; ii++)
                        {
                            hexoctets[hexoctet] = "0";
                            total_binary = total_binary + "0000000000000000";
                            hexoctet++;
                        }
                        hexoctet_input_l++;
                        if (hexoctet_input[hexoctet_input_l] == null)
                        {
                            hexoctets[hexoctet] = "0";
                            total_binary = total_binary + "0000000000000000";
                            hexoctet++;
                        }
                        else
                        {
                            hexoctets[hexoctet] = hexoctet_input[hexoctet_input_l];
                            binary_result = IPV6_Convertors.binary(hexoctet_input[hexoctet_input_l]);
                            if (binary_result[0] == "0")
                            {
                                return binary_result[1];
                            }
                            else
                            {
                                total_binary = total_binary + binary_result[1];
                            }
                            hexoctet++;
                        }
                        hexoctet_input_l++;
                    }
                }
                return total_binary;
            }



        }

        public string iptobinary(string ip)
        {
            string[] hexadecatets = ip.Split(':');
            int i = 3;
            int count = 1;
            string binary = "";
            foreach (string hexadecatet in hexadecatets)
            {
                if (count <= i)
                {
                    binary = binary + Convert.ToString(Convert.ToInt32(hexadecatet, 16), 2);
                }
            }
            return binary;
        }
        //public string binarytoip(string binary, int mask)
        //{
            //string[] hexadecatets = new[8];
        //}
    }
}
