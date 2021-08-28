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
    public partial class Main_Form : Form
    {

        public Main_Form()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBoxRouter_SelectedIndexChanged(object sender, EventArgs e)
        {

            string commands = routers.GetRouterCommannd(listBoxRouter.SelectedItem.ToString());
            textBoxCommands.Text = commands;
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ui = Convert.ToString(tboxIP_Range.Text);
                ip ip_object = new ip();
                ip_object.SetUserinput(ui);
               IP_Type IP_Version = IP_TOOLS.Determine_Type(ui);
                //quick fix until ip classes becomes 2 classes
                ip_object.IP_Type = IP_Version == IP_Type.IPv4 ? 4 : 6;
                String message = ip_object.CheckVaildation();
                if (message != "-1")
                {
                    MessageBox.Show(message);
                    return;
                }
                int totalhosts;
                int un_named_network = 0;
                preparedGUIForOutput(IP_Version);
                
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
                                tablesysdata.Rows[new_row].Cells[0].Value = userrow.Cells["networkname"].Value;
                            else
                            {
                                tablesysdata.Rows[new_row].Cells[0].Value = "Un-named Network " + un_named_network.ToString();
                                un_named_network++;
                            }
                            tablesysdata.Rows[new_row].Cells[9].Value = userrow.Cells["user_routers"].Value;
                            if (!ip_object.getIsIPV6())
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
                            else
                            {
                                ip_object.SetCurrentInfo6(Convert.ToInt32(userrow.Cells["usermaxhosts"].Value));
                                tablesysdata.Rows[new_row].Cells[8].Value = ip_object.GetPrefix();
                            }
                            tablesysdata.Rows[new_row].Cells["sysOSPFArea"].Value = userrow.Cells["userOSPFArea"].Value;
                        }
                    }
                }
                else
                {
                    int wanted;
                    try
                    {
                        wanted = Convert.ToInt32(tableuserdata.Rows[0].Cells[1].Value);
                    }
                    catch
                    {
                        throw new Exception_Message("Numbers are only allowed in the maxinium of hosts field");
                    }
                    ip_object.SetNumOfNetworks(wanted);
                    string hosts = (ip_object.Checkiflarge() == false ||IP_Version == IP_Type.IPv4) ? ip_object.GetNumberofNetworks().ToString() : ">1000000";
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

                int hosts_needed2;
                routers = new routers();
                //bug add a blank one
                foreach (DataGridViewRow routerrow in GirdViewRouters.Rows)
                {
                    routers.SetRouterSettings(Convert.ToString(routerrow.Cells["routerName"].Value), Convert.ToString(routerrow.Cells["routerDefaultRoute"].Value), Convert.ToBoolean(routerrow.Cells["routerOSPFEnabled"].Value), Convert.ToString(routerrow.Cells["routerOSPFRouterID"].Value), listBoxRouter);
                }
                if (IP_Version == IP_Type.IPv4)
                {
                    foreach (DataGridViewRow row in tablesysdata.Rows)
                    {
                        // getting hosts_needed generated from lass loop
                        hosts_needed2 = Convert.ToInt32(row.Cells[3].Value);
                        ip_object.SetCurrentInfo4(hosts_needed2);
                        row.Cells["Network_ID"].Value = ip_object.GetcurrentNetwork();
                        row.Cells["BroadCast_ID"].Value = ip_object.GetcurrentBroadcast();
                        row.Cells["fusable"].Value = ip_object.GetcurrentFirstUsable();
                        row.Cells["lusable"].Value = ip_object.GetcurrentLastUsable();

                        try
                        {
                            int oSPFArea = Int32.Parse((string)row.Cells["sysOSPFArea"].Value);
                            String subnet = (string)row.Cells["submask"].Value;
                            routers.NewInput(Convert.ToString(row.Cells[9].Value), Convert.ToString(row.Cells[0].Value), listBoxRouter, dataGridViewAddresses, ip_object, oSPFArea, subnet,ip_object.GetcurrentFirstUsable());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    //get1
                    foreach (DataGridViewRow row in tablesysdata.Rows)
                    {
                        //https://www.experts-exchange.com/questions/24415413/double-to-binary-in-c.html.
                        ip_object.SetCurrentInfo6(Convert.ToInt32(row.Cells[8].Value));
                        row.Cells[(int)Table_Columns.Network_ID].Value = ip_object.GetcurrentNetwork();
                        //string totalbinary = IPV4_convertors.ToBinary(n);

                        ///network_id ip ip binary
                        //padleft makes it 8 bits//MessageBox.Show("ip_in_binary");

                        ///adding two numbers tother via deminal then turning the decimal into binary
                        // this gets the boardcast address and the 2nd line adds to the table.
                        row.Cells[(int)Table_Columns.Broadcast_ID].Value = ip_object.GetcurrentBroadcast();
                    }

                }

                routers.GenterateCommands();
            }
            catch (Exception_Message ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void preparedGUIForOutput(IP_Type iP_Version)
        {
            tablesysdata.Rows.Clear();
            dataGridViewAddresses.Rows.Clear();
            tableuserdata.Refresh();
            listBoxRouter.Items.Clear();
            textBoxCommands.Text = "";
            Boolean isVisble;
            int width;
            String headerText;
            if (iP_Version == IP_Type.IPv4)
            {
                 width = 100;
                 isVisble = true;
                 headerText = "Subnet";
            }
            else
            {
                width = 240;
                isVisble = false;
                headerText = "Prefix";
            }
            tablesysdata.Columns[4].Width = width;
            tablesysdata.Columns[5].Visible = isVisble;
            tablesysdata.Columns[6].Visible = isVisble;
            tablesysdata.Columns[7].Visible = isVisble;
            tablesysdata.Columns[8].HeaderText = headerText;
        }

        private void testDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
                tableuserdata.Rows.Clear();
                GirdViewRouters.Rows.Clear();
                tableuserdata.Rows.Add();
            int i = 0;
                tableuserdata.Rows[i].Cells[0].Value = "Office";
                tableuserdata.Rows[i].Cells[1].Value = "65";
                tableuserdata.Rows[i].Cells[2].Value = "R1 G0/2";
                tableuserdata.Rows[i].Cells[3].Value = "1";
            tableuserdata.Rows.Add();
            i = 1; 
            tableuserdata.Rows[i].Cells[0].Value = "Accounting";
            tableuserdata.Rows[i].Cells[1].Value = "605";
            tableuserdata.Rows[i].Cells[2].Value = "R2 G0/2";
            tableuserdata.Rows[i].Cells[3].Value = "2";
            tableuserdata.Rows.Add();
            i = 2;
            tableuserdata.Rows[i].Cells[0].Value = "Link point-to-point";
            tableuserdata.Rows[i].Cells[1].Value = "2";
            tableuserdata.Rows[i].Cells[2].Value = "R2 G0/2, R1 G0/1";
            tableuserdata.Rows[i].Cells[3].Value = "0";
            GirdViewRouters.Rows.Add();
            i = 0;
                GirdViewRouters.Rows[i].Cells[0].Value = "R1";
                GirdViewRouters.Rows[i].Cells[2].Value = true;
                GirdViewRouters.Rows[i].Cells[3].Value = "1.1.1.1";
                GirdViewRouters.Rows[i].Cells[4].Value = "1";
            i = 1;
                GirdViewRouters.Rows.Add();
                GirdViewRouters.Rows[i].Cells[0].Value = "R2";
                GirdViewRouters.Rows[i].Cells[2].Value = true;
                GirdViewRouters.Rows[i].Cells[3].Value = "1.1.1.2";
                GirdViewRouters.Rows[i].Cells[4].Value = "1";
            //MessageBox.Show(IP_TOOLS.Add_Binary("01", "1"));
           
        }
    }

    }
   