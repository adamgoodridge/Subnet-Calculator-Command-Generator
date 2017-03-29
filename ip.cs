 if (available_hosts > totalhostsrequired | available_hosts == totalhostsrequired)
            {
                foreach (DataGridViewRow sysrow in tablesysdata.Rows)
                {
                    system_row_number++;
                    // getting hosts_needed generated from lass loop
                    hosts_needed2 = Convert.ToInt32(sysrow.Cells[3].Value);
                    //problem
                    tablesysdata.Rows[system_row_number].Cells[4].Value = networkid;
                    //string totalbinary = IPV4_convertors.ToBinary(n);
                 

                    ///network_id ip ip binary
                    long ip_in_decimal = Convert.ToInt64(totalbinary, 2);
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
                    string broadcast = Convert.ToString(ip_in_decimal + hosts_needed2 - 1, 2);
                    broadcast = broadcast.PadLeft(32, '0');
                    tablesysdata.Rows[system_row_number].Cells["BroadCastID"].Value = binary_to_ipv4.format(broadcast);
                    //binary_to_ip(broadcast);
                    ///end
                    ///// this gets the first use address and the 2nd line adds to the table.
                    string network_usable_first = Convert.ToString(ip_in_decimal + 1, 2);
                    tablesysdata.Rows[system_row_number].Cells["fusable"].Value = binary_to_ipv4.format(network_usable_first).ToString();

                    ///end
                    ///
                    ///// this gets the first use address and the 2nd line adds to the table.
                    string network_usable_last = Convert.ToString(ip_in_decimal + hosts_needed2 - 2, 2);
                    tablesysdata.Rows[system_row_number].Cells["lusable"].Value = binary_to_ipv4.format(network_usable_last);
                    ///end

                    /// getting for next netwokid
                    ///networkid = binary_to_ip(network_broadcast + 1);
                    /// end
                    ///  this gets the network ID address whatever the next subnet will next
                    networkid = binary_to_ipv4.format(Convert.ToString(ip_in_decimal + hosts_needed2, 2));
                }
            }