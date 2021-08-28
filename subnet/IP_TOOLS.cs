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
    }
    }
