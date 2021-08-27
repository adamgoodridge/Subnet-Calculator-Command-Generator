using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace subnet
{
    class routers
    {
        private List<string> routers_name = new List<string>();
        private List<router> router_info = new List<router>();
        private static Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
        public void NewInput(string input, string networkname, ListBox listBoxRouter, DataGridView dataGridViewAddresses, ip ip_object, int oSPFArea)
        {
            input = regex.Replace(input, " ");
            String[] input_routers = input.Split(',');
            foreach (String item in input_routers)
            { 
                String[] router_split = item.Split(' ');
                String routerName = router_split[0];
                string @interface = router_split[1].TrimEnd(',');
                bool linkLocal = (ip_object.getIsIPV6() && router_split.Length == 3 && router_split[3] == "l");
                String ip = ip_object.GetAvailable();
                int row = dataGridViewAddresses.Rows.Add();
                dataGridViewAddresses.Rows[row].Cells["intRouterName"].Value = routerName;
                dataGridViewAddresses.Rows[row].Cells["intInterface"].Value = @interface;
                dataGridViewAddresses.Rows[row].Cells["intOSPFArea"].Value = oSPFArea;
                if (ip_object.IP_Type == 4)
                {
                    dataGridViewAddresses.Rows[row].Cells["intIP"].Value = ip;
                    dataGridViewAddresses.Rows[row].Cells["intSubnet"].Value = ip_object.GetCurrentSubnet();
                }
                else
                {
                    dataGridViewAddresses.Rows[row].Cells["intIP"].Value = ip + "/" + ip_object.GetCurrentSubnet();
                }
                dataGridViewAddresses.Rows[row].Cells["intNetwork"].Value = networkname;
               
                if (!routers_name.Contains(routerName))
                {
                    routers_name.Add(routerName);
                    router_info.Add(new router(routerName));
                    listBoxRouter.Items.Add(routerName);
                }
                router_info[routers_name.IndexOf(routerName)].AddInterface(@interface, ip, ip_object.GetCurrentSubnet(), oSPFArea, ip_object.getIsIPV6(), linkLocal, ip_object.GetcurrentNetwork(), "");


            }
        }
        public void SetRouterSettings(string name, String dr, bool oSPF, string oID, ListBox listBoxRouter)
        {
            if (!routers_name.Contains(name))
            {
                routers_name.Add(name);
                router_info.Add(new router(name));
                listBoxRouter.Items.Add(name);
            }
            router_info[routers_name.IndexOf(name)].SetSettings(dr, oSPF, oID);
        }

        public string GetRouterCommannd(string routerName)
        {
           string commands_textbox = "";
            List<string> commands = router_info[routers_name.IndexOf(routerName)].GetCommands();
            foreach (var command in commands)
            {
                commands_textbox += command + Environment.NewLine;
            }
            return commands_textbox;
        }
        public void GenterateCommands()
        {
            
            foreach (router router in router_info)
            {
                router.SetCommands();
            }
        }
    }
}