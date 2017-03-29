using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
///using System.Linq;

namespace subnet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //this.tableuserdata.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(tableuserdata.EditingControlShowing);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private routers routers;
        private void butrun_Click(object sender, EventArgs e)
        {
            string ui = Convert.ToString(tbox1.Text);
            ip ip_object = new ip();
            ip_object.SetUserinput(ui);
            string message = ip_object.determine_type();
            routers = new routers();
            if (message != "-1")
            {
                MessageBox.Show(message);
                return;
            }
            int mask;
            string hostbits = "";
            message = ip_object.CheckVaildation();
            if (message != "-1")
            {
                MessageBox.Show(message);
                return;
            }
            tablesysdata.Rows.Clear();
            dataGridViewAddresses.Rows.Clear();
            tableuserdata.Refresh();
            listBoxRouter.Items.Clear();
            textBoxCommands.Text = "";
            int totalhosts;
            int un_named_network = 0;
            if (ip_object.GetIPType() == 4)
            {
                if (tablesysdata.Columns[5].Visible == false)
                {
                    tablesysdata.Columns[4].Width = 100;
                    tablesysdata.Columns[5].Visible = true;
                    tablesysdata.Columns[6].Visible = true;
                    tablesysdata.Columns[7].Width = 100;
                    tablesysdata.Columns[8].HeaderText = "Subnet";
                }
            }
            else
            {
                tablesysdata.Columns[4].Width = 240;
                tablesysdata.Columns[5].Visible = false;
                tablesysdata.Columns[6].Visible = false;
                tablesysdata.Columns[7].Width = 240;
                tablesysdata.Columns[8].HeaderText = "Prefix";
            }
            // putting the user's input in systemstable
            if (Convert.ToString(tableuserdata.Rows[0].Cells[0].Value) != "EQUAL=")
            {

                foreach (DataGridViewRow userrow in tableuserdata.Rows)
                {
                    ///first line check if the user has put a value for the amount of hosts
                    if (userrow.Cells["usermaxhosts"].Value != null)
                    {
                        int new_row = tablesysdata.Rows.Add();
                        if (userrow.Cells["networkname"].Value != null)
                        {
                            tablesysdata.Rows[new_row].Cells[0].Value = userrow.Cells["networkname"].Value;
                        }
                        else
                        {
                            tablesysdata.Rows[new_row].Cells[0].Value = "Network " + un_named_network.ToString();
                            un_named_network++;
                        }
                        if ((userrow.Cells["usermaxhosts"].Value).ToString() == "0")
                        {

                            tablesysdata.Rows[new_row].Cells[1].Value = "64^2";
                            tablesysdata.Rows[new_row].Cells[2].Value = "64^2";
                            tablesysdata.Rows[new_row].Cells[3].Value = "64^2";
                            tablesysdata.Rows[new_row].Cells[8].Value = "64";

                        }
                        else
                        {
                            int hostsmin = Convert.ToInt32(userrow.Cells["usermaxhosts"].Value) + 2;
                            ///cells refers to which column
                            ///num refers to row that we creatted

                            tablesysdata.Rows[new_row].Cells[1].Value = userrow.Cells["usermaxhosts"].Value;
                            tablesysdata.Rows[new_row].Cells[2].Value = hostsmin;
                            totalhosts = ip_object.CalculateSpaceRequired(hostsmin);
                            tablesysdata.Rows[new_row].Cells[3].Value = totalhosts;
                            tablesysdata.Rows[new_row].Cells[8].Value = ip_object.GetCurrentSubnet();
                            ip_object.add_hosts(totalhosts);

                        }
                        tablesysdata.Rows[new_row].Cells[9].Value = userrow.Cells["user_routers"].Value;
                }
                    }
                }  else {
                int wanted;
                try
                {
                    wanted = Convert.ToInt32(tableuserdata.Rows[0].Cells[1].Value);
                }
                catch
                {
                    MessageBox.Show("Numbers are only allowed in the maxinium of hosts field");
                    return;
                }
                ip_object.SetNumOfNetworks(wanted);
                                   string hosts;
                    if (ip_object.Checkiflarge() == false || ip_object.GetIPType() == 4)
                    {
                        hosts = ip_object.GetNumberofNetworks().ToString();
                    }
                    else
                    {
                        hosts = ">1000000";
                    }
                    for (int i = 1; i <= ip_object.GetNumberofNetworks(); i++)
                    {
                        int new_row = tablesysdata.Rows.Add();
                        tablesysdata.Rows[new_row].Cells[0].Value = "Network " + un_named_network.ToString();
                        un_named_network++;
                        tablesysdata.Rows[new_row].Cells[1].Value = hosts;
                        tablesysdata.Rows[new_row].Cells[2].Value = hosts;
                        tablesysdata.Rows[new_row].Cells[3].Value = hosts;
                        tablesysdata.Rows[new_row].Cells[8].Value = ip_object.GetCurrentSubnet();
                    }
                
                }

                    //end
                    tablesysdata.Sort(tablesysdata.Columns[3], ListSortDirection.Descending);
                    //check if hosts are able to fit within the subnet given
                    message = ip_object.Compare_Hosts();
                    if (message != "-1")
                    {
                        MessageBox.Show(message);
                        return;
                    }
                
                int system_row_number = -1;
                int hosts_needed2;
            //DataGridViewColumn col = new DataGridViewColumn();
            
                if (ip_object.GetIPType() == 4)
                {
                foreach (DataGridViewRow sysrow in tablesysdata.Rows)
                {
                    system_row_number++;
                    // getting hosts_needed generated from lass loop
                    hosts_needed2 = Convert.ToInt32(sysrow.Cells[3].Value);
                        ip_object.SetCurrentInfo4(hosts_needed2);

                        tablesysdata.Rows[system_row_number].Cells[4].Value = ip_object.GetcurrentNetwork();
                        //string totalbinary = IPV4_convertors.ToBinary(n);


                        ///network_id ip ip binary
                        //padleft makes it 8 bits//MessageBox.Show("ip_in_binary");

                        ///end
                        ///1  network name - sysnetname
                        ///2 hosts required -hostsrequired
                        ///3 minimum hosts – minimumhosts
                        ///4 maximum hosts – maxhosts
                        ///5 network id -NetworkID
                        ///6 broadcast ID – BroadCastID
                        ///7 first - fusable    
                        ///8 last - lusable                                                                              

                        ///adding two numbers tother via deminal then turning the decimal into binary
                        // this gets the boardcast address and the 2nd line adds to the table.
                        tablesysdata.Rows[system_row_number].Cells["BroadCastID"].Value = ip_object.GetcurrentBroadcast();
                        //binary_to_ip(broadcast);
                        ///end
                        ///// this gets the first use address and the 2nd line adds to the table.
                        tablesysdata.Rows[system_row_number].Cells["fusable"].Value = ip_object.GetcurrentFirstUsable();

                        tablesysdata.Rows[system_row_number].Cells["lusable"].Value = ip_object.GetcurrentLastUsable();
                    ///end
                    ///
                    try { 
                    routers.NewInput(tablesysdata.Rows[system_row_number].Cells["sys_routers"].Value.ToString(),tablesysdata.Rows[system_row_number].Cells[0].Value.ToString(), listBoxRouter,dataGridViewAddresses,ip_object);
                        } catch
                    {

                    }
                }
            }
                else
                {
             //get1
                    foreach (DataGridViewRow sysrow in tablesysdata.Rows)
                    {
                        system_row_number++;
                        // getting hosts_needed generated from lass loop



                        //https://www.experts-exchange.com/questions/24415413/double-to-binary-in-c.html.
                        ip_object.SetCurrentInfo6(Convert.ToInt32(tablesysdata.Rows[system_row_number].Cells[8].Value));
                        tablesysdata.Rows[system_row_number].Cells[4].Value = ip_object.GetcurrentNetwork();
                    //string totalbinary = IPV4_convertors.ToBinary(n);


                    ///network_id ip ip binary
                    //padleft makes it 8 bits//MessageBox.Show("ip_in_binary");

                    ///adding two numbers tother via deminal then turning the decimal into binary
                    // this gets the boardcast address and the 2nd line adds to the table.
                    tablesysdata.Rows[system_row_number].Cells["BroadCastID"].Value = ip_object.GetcurrentBroadcast();
                    try
                    {
                        routers.NewInput(tablesysdata.Rows[system_row_number].Cells["sys_routers"].Value.ToString(), tablesysdata.Rows[system_row_number].Cells[0].Value.ToString(), listBoxRouter, dataGridViewAddresses, ip_object);
                    }
                    catch
                    {

                    }
                }
                }



            //end

        }
            
        private void tableuserdata_KeyUp (object sender, KeyPressEventArgs e)
        {

            MessageBox.Show("test");
         //   if (tableuserdata.Columns[e.].Name == "user_routers")
            {
           //     MessageBox.Show((tableuserdata.Rows[e.RowIndex].Cells[2].Value).ToString());


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxRouter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string commands = routers.GetRouterCommannd(listBoxRouter.SelectedItem.ToString());
            textBoxCommands.Text = commands;
        }

        private void tableuserdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
   