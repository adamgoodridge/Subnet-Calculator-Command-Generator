using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class IPV4_convertors
    { 
        public static string ToBinary(int dem)
        {
            string binary = Convert.ToString(dem, 2).PadLeft(8, '0');
          return binary;
          }
          
        }
    }
