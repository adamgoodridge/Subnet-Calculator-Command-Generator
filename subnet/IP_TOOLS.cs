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
    }
    }
