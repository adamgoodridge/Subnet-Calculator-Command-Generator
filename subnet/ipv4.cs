using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    class ipv4 : ip
    {
        private int interestingOctet;
        
        /*
        public void CheckVaildation()
        {
            base.CheckVaildation();
            if (mask < 32)
            {
                message = ipv4.check(orginal_networkid);
                if (!(message.Contains("-1/")))
                    return message;

                //meaning remove -1/ from the start
                binary = message.Substring(3);
                try
                {
                    networkBinary = binary.Substring(0, mask);
                    //with referring mask right bellow it take off the first character off of the amount of mask
                    hostsBinary = binary.Substring(mask, 32 - mask);
                }
                catch (Exception_Message)
                {
                    throw new Exception_Message(mask + " isn't a invaild mask.");
                }
            }
        */
        }


}
    
