using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subnet
{
    [Flags]
    enum TableColums
    {



        ///1  network name - sysnetname = 1
        Network_Name = 1,
        ///2 hosts required -hostsrequired
        Hosts_Required = 2,
        ///3 minimum hosts – minimumhosts
        Minimum_Hosts = 3,
        ///4 maximum hosts – maxhosts
        ///5 network id -NetworkID
        ///6 broadcast ID – BroadCastID
        ///7 first - fusable    
        ///8 last - lusable                                                                              

    }
}
