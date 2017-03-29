using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class IPV6_Convertors
    {
        public static string[] binary(string hexoctet)
        {
            string binary = "";
            string char_binary = "";
            int num;
            string[] message = new string[2];
            foreach (char hex_char in hexoctet)
            {
                try
                {
                    string hex = Convert.ToString(hex_char);
                    //http://stackoverflow.com/questions/25933590/check-if-string-is-valid-represantion-of-hex-number
                    num = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                    //
                    char_binary = Convert.ToString(num, 2).PadLeft(4, '0');
                    binary = binary + char_binary;
                }
                catch
                {
                    message[0] = "0";
                    message[1] = hex_char + " is invaild hex";
                    return message;
                }
            }

            // 0 spot in the array, is 1 as it was successfull
            message[0] = "1";
            //end
            message[1] = binary.PadLeft(16, '0');
            return message;
        }
        public static bool Binary_length(string binary)
        {
            if (binary.Length == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string binarytoipv6(string binary)
        {
            string hex = "", sub_hex = "", sub_binary = "";
            int j = 4, oct = 0, k;
            string[] hexoct = new string[8];
            for (k = 0; k < 128; k += 4)
            {
                if ((k != 0) & (k % 16 == 0))
                {
                    hexoct[oct] = hex;
                    hex = "";
                    oct++;
                }
                sub_binary = binary.Substring(k, 4);
                //X rsays it make hex and capital
                sub_hex = Convert.ToInt32(sub_binary, 2).ToString("X");
                hex += sub_hex;

            }
            hexoct[oct] = hex;
            hex = "";
            oct++;
            int highest_zero = 0;
            int highest_zero_s = -1;
            int highest_zero_e = -1;
            int current_s = 9;
            int current_c = 0;
            for (int ii = 0; ii < 8; ii++)
            {
                hexoct[ii] = hexoct[ii].TrimStart('0');
                if (hexoct[ii] == "")
                {
                    current_c++;
                    hexoct[ii] = "0";
                    if (current_s == 9)
                    {
                        current_s = ii;
                    }
                }
                else
                {
                    if (current_c > highest_zero)
                    {

                        string hexoct_string = hexoct[0] + ":" + hexoct[1] + ":" + hexoct[2] + ":" + hexoct[3] + ":" + hexoct[4] + ":" + hexoct[5] + ":" + hexoct[6] + ":" + hexoct[7];

                        highest_zero = current_c;
                        highest_zero_s = current_s;
                        highest_zero_e = ii;
                    }
                }
            }
            k = 0;
            string ip = "";
            while (k < 8)
            {
                if (k == highest_zero_s)
                {
                    ip = ip + ":";
                    k = highest_zero_e;
                }
                else
                {
                    ip = ip + ":" + hexoct[k];
                    k++;
                }
                ip = ip.TrimStart(':');
            }
            return ip;
        }
    }
}
