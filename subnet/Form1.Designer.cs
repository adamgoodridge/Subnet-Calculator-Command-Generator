using System;
using System.Windows.Forms;

namespace subnet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRouters = new System.Windows.Forms.TabControl();
            this.input1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GirdViewRouters = new System.Windows.Forms.DataGridView();
            this.routerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerDefaultRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerOSPFEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.routerOSPFRouterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerOSPFProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxIP_Range = new System.Windows.Forms.TextBox();
            this.tableuserdata = new System.Windows.Forms.DataGridView();
            this.NetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermaxhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_routers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabIPs = new System.Windows.Forms.TabPage();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.intRouterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intInterface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSubnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheme = new System.Windows.Forms.TabPage();
            this.tablesysdata = new System.Windows.Forms.DataGridView();
            this.sysnetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostsrequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Network_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fusable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lusable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroadCast_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sys_routers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commands = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxRouter = new System.Windows.Forms.ListBox();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRouters.SuspendLayout();
            this.input1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirdViewRouters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableuserdata)).BeginInit();
            this.tabIPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.scheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesysdata)).BeginInit();
            this.commands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(this.input1);
            this.tabRouters.Controls.Add(this.tabIPs);
            this.tabRouters.Controls.Add(this.scheme);
            this.tabRouters.Controls.Add(this.commands);
            this.tabRouters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRouters.Location = new System.Drawing.Point(0, 33);
            this.tabRouters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.SelectedIndex = 0;
            this.tabRouters.Size = new System.Drawing.Size(1436, 839);
            this.tabRouters.TabIndex = 3;
            // 
            // input1
            // 
            this.input1.AccessibleName = "";
            this.input1.Controls.Add(this.tableLayoutPanel1);
            this.input1.Location = new System.Drawing.Point(4, 29);
            this.input1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input1.Name = "input1";
            this.input1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.input1.Size = new System.Drawing.Size(1428, 806);
            this.input1.TabIndex = 0;
            this.input1.Text = "Input";
            this.input1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GirdViewRouters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxIP_Range, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableuserdata, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1420, 796);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GirdViewRouters
            // 
            this.GirdViewRouters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GirdViewRouters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routerName,
            this.routerDefaultRoute,
            this.routerOSPFEnabled,
            this.routerOSPFRouterID,
            this.routerOSPFProcessID});
            this.GirdViewRouters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GirdViewRouters.Location = new System.Drawing.Point(3, 630);
            this.GirdViewRouters.Name = "GirdViewRouters";
            this.GirdViewRouters.RowHeadersWidth = 62;
            this.GirdViewRouters.RowTemplate.Height = 24;
            this.GirdViewRouters.Size = new System.Drawing.Size(1414, 163);
            this.GirdViewRouters.TabIndex = 6;
            // 
            // routerName
            // 
            this.routerName.HeaderText = "Router Name";
            this.routerName.MinimumWidth = 8;
            this.routerName.Name = "routerName";
            this.routerName.Width = 150;
            // 
            // routerDefaultRoute
            // 
            this.routerDefaultRoute.HeaderText = "Default Route";
            this.routerDefaultRoute.MinimumWidth = 8;
            this.routerDefaultRoute.Name = "routerDefaultRoute";
            this.routerDefaultRoute.Width = 150;
            // 
            // routerOSPFEnabled
            // 
            this.routerOSPFEnabled.HeaderText = "OSPF";
            this.routerOSPFEnabled.MinimumWidth = 8;
            this.routerOSPFEnabled.Name = "routerOSPFEnabled";
            this.routerOSPFEnabled.Width = 150;
            // 
            // routerOSPFRouterID
            // 
            this.routerOSPFRouterID.HeaderText = "OSPF Router ID";
            this.routerOSPFRouterID.MinimumWidth = 8;
            this.routerOSPFRouterID.Name = "routerOSPFRouterID";
            this.routerOSPFRouterID.Width = 150;
            // 
            // routerOSPFProcessID
            // 
            this.routerOSPFProcessID.HeaderText = "OSPF Process ID";
            this.routerOSPFProcessID.MinimumWidth = 8;
            this.routerOSPFProcessID.Name = "routerOSPFProcessID";
            this.routerOSPFProcessID.Width = 150;
            // 
            // tboxIP_Range
            // 
            this.tboxIP_Range.Dock = System.Windows.Forms.DockStyle.Top;
            this.tboxIP_Range.Location = new System.Drawing.Point(4, 5);
            this.tboxIP_Range.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxIP_Range.MaxLength = 255;
            this.tboxIP_Range.Name = "tboxIP_Range";
            this.tboxIP_Range.Size = new System.Drawing.Size(1412, 26);
            this.tboxIP_Range.TabIndex = 3;
            this.tboxIP_Range.Text = "10.0.0.0/16";
            // 
            // tableuserdata
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableuserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableuserdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NetworkName,
            this.usermaxhosts,
            this.user_routers,
            this.userOSPFArea});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableuserdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableuserdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableuserdata.Location = new System.Drawing.Point(4, 46);
            this.tableuserdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableuserdata.Name = "tableuserdata";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableuserdata.RowHeadersWidth = 62;
            this.tableuserdata.Size = new System.Drawing.Size(1412, 576);
            this.tableuserdata.TabIndex = 5;
            // 
            // NetworkName
            // 
            this.NetworkName.HeaderText = "Network Name";
            this.NetworkName.MinimumWidth = 8;
            this.NetworkName.Name = "NetworkName";
            this.NetworkName.Width = 150;
            // 
            // usermaxhosts
            // 
            this.usermaxhosts.HeaderText = "Maxinum Of Hosts";
            this.usermaxhosts.MinimumWidth = 8;
            this.usermaxhosts.Name = "usermaxhosts";
            this.usermaxhosts.Width = 150;
            // 
            // user_routers
            // 
            this.user_routers.HeaderText = "Routers";
            this.user_routers.MinimumWidth = 8;
            this.user_routers.Name = "user_routers";
            this.user_routers.Width = 150;
            // 
            // userOSPFArea
            // 
            this.userOSPFArea.HeaderText = "OSPF Area";
            this.userOSPFArea.MinimumWidth = 8;
            this.userOSPFArea.Name = "userOSPFArea";
            this.userOSPFArea.Width = 150;
            // 
            // tabIPs
            // 
            this.tabIPs.Controls.Add(this.dataGridViewAddresses);
            this.tabIPs.Location = new System.Drawing.Point(4, 29);
            this.tabIPs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabIPs.Name = "tabIPs";
            this.tabIPs.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabIPs.Size = new System.Drawing.Size(1428, 806);
            this.tabIPs.TabIndex = 3;
            this.tabIPs.Text = "Input of Router\'s information";
            this.tabIPs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAddresses
            // 
            this.dataGridViewAddresses.AllowUserToAddRows = false;
            this.dataGridViewAddresses.AllowUserToDeleteRows = false;
            this.dataGridViewAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intRouterName,
            this.intInterface,
            this.intIP,
            this.intSubnet,
            this.intOSPFArea,
            this.intNetwork,
            this.intDescription});
            this.dataGridViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewAddresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.ReadOnly = true;
            this.dataGridViewAddresses.RowHeadersWidth = 62;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(1420, 796);
            this.dataGridViewAddresses.TabIndex = 0;
            // 
            // intRouterName
            // 
            this.intRouterName.HeaderText = "Router Name";
            this.intRouterName.MinimumWidth = 8;
            this.intRouterName.Name = "intRouterName";
            this.intRouterName.ReadOnly = true;
            this.intRouterName.Width = 150;
            // 
            // intInterface
            // 
            this.intInterface.HeaderText = "Interface";
            this.intInterface.MinimumWidth = 8;
            this.intInterface.Name = "intInterface";
            this.intInterface.ReadOnly = true;
            this.intInterface.Width = 150;
            // 
            // intIP
            // 
            this.intIP.HeaderText = "IP Address";
            this.intIP.MinimumWidth = 8;
            this.intIP.Name = "intIP";
            this.intIP.ReadOnly = true;
            this.intIP.Width = 150;
            // 
            // intSubnet
            // 
            this.intSubnet.HeaderText = "Subnet";
            this.intSubnet.MinimumWidth = 8;
            this.intSubnet.Name = "intSubnet";
            this.intSubnet.ReadOnly = true;
            this.intSubnet.Width = 150;
            // 
            // intOSPFArea
            // 
            this.intOSPFArea.HeaderText = "OSPF Area";
            this.intOSPFArea.MinimumWidth = 8;
            this.intOSPFArea.Name = "intOSPFArea";
            this.intOSPFArea.ReadOnly = true;
            this.intOSPFArea.Width = 150;
            // 
            // intNetwork
            // 
            this.intNetwork.HeaderText = "Network Name";
            this.intNetwork.MinimumWidth = 8;
            this.intNetwork.Name = "intNetwork";
            this.intNetwork.ReadOnly = true;
            this.intNetwork.Width = 150;
            // 
            // intDescription
            // 
            this.intDescription.HeaderText = "Description";
            this.intDescription.MinimumWidth = 8;
            this.intDescription.Name = "intDescription";
            this.intDescription.ReadOnly = true;
            this.intDescription.Width = 150;
            // 
            // scheme
            // 
            this.scheme.AccessibleName = "";
            this.scheme.Controls.Add(this.tablesysdata);
            this.scheme.Location = new System.Drawing.Point(4, 29);
            this.scheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheme.Name = "scheme";
            this.scheme.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheme.Size = new System.Drawing.Size(1428, 806);
            this.scheme.TabIndex = 1;
            this.scheme.Text = "IP Scheme Output";
            this.scheme.UseVisualStyleBackColor = true;
            // 
            // tablesysdata
            // 
            this.tablesysdata.AllowUserToAddRows = false;
            this.tablesysdata.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesysdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablesysdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesysdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sysnetname,
            this.hostsrequired,
            this.minimumhosts,
            this.maxhosts,
            this.Network_ID,
            this.fusable,
            this.lusable,
            this.BroadCast_ID,
            this.submask,
            this.sys_routers,
            this.sysOSPFArea});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesysdata.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablesysdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesysdata.Location = new System.Drawing.Point(4, 5);
            this.tablesysdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablesysdata.Name = "tablesysdata";
            this.tablesysdata.ReadOnly = true;
            this.tablesysdata.RowHeadersWidth = 62;
            this.tablesysdata.Size = new System.Drawing.Size(1420, 796);
            this.tablesysdata.TabIndex = 1;
            // 
            // sysnetname
            // 
            this.sysnetname.HeaderText = "Network Name";
            this.sysnetname.MinimumWidth = 8;
            this.sysnetname.Name = "sysnetname";
            this.sysnetname.ReadOnly = true;
            this.sysnetname.Width = 150;
            // 
            // hostsrequired
            // 
            this.hostsrequired.HeaderText = "Hosts Required";
            this.hostsrequired.MinimumWidth = 8;
            this.hostsrequired.Name = "hostsrequired";
            this.hostsrequired.ReadOnly = true;
            this.hostsrequired.Width = 150;
            // 
            // minimumhosts
            // 
            this.minimumhosts.HeaderText = "Minimum Of Hosts";
            this.minimumhosts.MinimumWidth = 8;
            this.minimumhosts.Name = "minimumhosts";
            this.minimumhosts.ReadOnly = true;
            this.minimumhosts.Width = 150;
            // 
            // maxhosts
            // 
            this.maxhosts.HeaderText = "Maxinum Of Hosts";
            this.maxhosts.MinimumWidth = 8;
            this.maxhosts.Name = "maxhosts";
            this.maxhosts.ReadOnly = true;
            this.maxhosts.Width = 150;
            // 
            // Network_ID
            // 
            this.Network_ID.HeaderText = "Network ID";
            this.Network_ID.MinimumWidth = 8;
            this.Network_ID.Name = "Network_ID";
            this.Network_ID.ReadOnly = true;
            this.Network_ID.Width = 150;
            // 
            // fusable
            // 
            this.fusable.HeaderText = "First Usable Address";
            this.fusable.MinimumWidth = 8;
            this.fusable.Name = "fusable";
            this.fusable.ReadOnly = true;
            this.fusable.Width = 150;
            // 
            // lusable
            // 
            this.lusable.HeaderText = "Last Useable Address";
            this.lusable.MinimumWidth = 8;
            this.lusable.Name = "lusable";
            this.lusable.ReadOnly = true;
            this.lusable.Width = 150;
            // 
            // BroadCast_ID
            // 
            this.BroadCast_ID.HeaderText = "BroadCast ID";
            this.BroadCast_ID.MinimumWidth = 8;
            this.BroadCast_ID.Name = "BroadCast_ID";
            this.BroadCast_ID.ReadOnly = true;
            this.BroadCast_ID.Width = 150;
            // 
            // submask
            // 
            this.submask.HeaderText = "Submask";
            this.submask.MinimumWidth = 8;
            this.submask.Name = "submask";
            this.submask.ReadOnly = true;
            this.submask.Width = 150;
            // 
            // sys_routers
            // 
            this.sys_routers.HeaderText = "Routers";
            this.sys_routers.MinimumWidth = 8;
            this.sys_routers.Name = "sys_routers";
            this.sys_routers.ReadOnly = true;
            this.sys_routers.Width = 150;
            // 
            // sysOSPFArea
            // 
            this.sysOSPFArea.HeaderText = "OSPF Area";
            this.sysOSPFArea.MinimumWidth = 8;
            this.sysOSPFArea.Name = "sysOSPFArea";
            this.sysOSPFArea.ReadOnly = true;
            this.sysOSPFArea.Width = 150;
            // 
            // commands
            // 
            this.commands.Controls.Add(this.splitContainer1);
            this.commands.Location = new System.Drawing.Point(4, 29);
            this.commands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commands.Name = "commands";
            this.commands.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commands.Size = new System.Drawing.Size(1428, 806);
            this.commands.TabIndex = 2;
            this.commands.Text = "Commands";
            this.commands.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxRouter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCommands);
            this.splitContainer1.Size = new System.Drawing.Size(1420, 796);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxRouter
            // 
            this.listBoxRouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRouter.FormattingEnabled = true;
            this.listBoxRouter.ItemHeight = 20;
            this.listBoxRouter.Location = new System.Drawing.Point(0, 0);
            this.listBoxRouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRouter.Name = "listBoxRouter";
            this.listBoxRouter.Size = new System.Drawing.Size(466, 796);
            this.listBoxRouter.TabIndex = 0;
            this.listBoxRouter.SelectedIndexChanged += new System.EventHandler(this.listBoxRouter_SelectedIndexChanged);
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCommands.Location = new System.Drawing.Point(0, 0);
            this.textBoxCommands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCommands.Multiline = true;
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(948, 796);
            this.textBoxCommands.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem,
            this.testDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1436, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.vToolStripMenuItem.Text = "Process";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // testDataToolStripMenuItem
            // 
            this.testDataToolStripMenuItem.Name = "testDataToolStripMenuItem";
            this.testDataToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.testDataToolStripMenuItem.Text = "Test Data";
            this.testDataToolStripMenuItem.Click += new System.EventHandler(this.testDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 872);
            this.Controls.Add(this.tabRouters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRouters.ResumeLayout(false);
            this.input1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirdViewRouters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableuserdata)).EndInit();
            this.tabIPs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.scheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesysdata)).EndInit();
            this.commands.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableuserdata_KeyPressEventHandler(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TabControl tabRouters;
        private System.Windows.Forms.TabPage input1;
        private System.Windows.Forms.TabPage scheme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView tablesysdata;
        private System.Windows.Forms.TabPage commands;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxRouter;
        private TabPage tabIPs;
        private ToolStripMenuItem vToolStripMenuItem;
        private TextBox textBoxCommands;
        private DataGridView dataGridViewAddresses;
        private DataGridViewTextBoxColumn intRouterName;
        private DataGridViewTextBoxColumn intInterface;
        private DataGridViewTextBoxColumn intIP;
        private DataGridViewTextBoxColumn intSubnet;
        private DataGridViewTextBoxColumn intOSPFArea;
        private DataGridViewTextBoxColumn intNetwork;
        private DataGridViewTextBoxColumn intDescription;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView GirdViewRouters;
        private DataGridViewTextBoxColumn routerName;
        private DataGridViewTextBoxColumn routerDefaultRoute;
        private DataGridViewCheckBoxColumn routerOSPFEnabled;
        private DataGridViewTextBoxColumn routerOSPFRouterID;
        private DataGridViewTextBoxColumn routerOSPFProcessID;
        private TextBox tboxIP_Range;
        private DataGridView tableuserdata;
        private DataGridViewTextBoxColumn NetworkName;
        private DataGridViewTextBoxColumn usermaxhosts;
        private DataGridViewTextBoxColumn user_routers;
        private DataGridViewTextBoxColumn userOSPFArea;
        private DataGridViewTextBoxColumn sysnetname;
        private DataGridViewTextBoxColumn hostsrequired;
        private DataGridViewTextBoxColumn minimumhosts;
        private DataGridViewTextBoxColumn maxhosts;
        private DataGridViewTextBoxColumn Network_ID;
        private DataGridViewTextBoxColumn fusable;
        private DataGridViewTextBoxColumn lusable;
        private DataGridViewTextBoxColumn BroadCast_ID;
        private DataGridViewTextBoxColumn submask;
        private DataGridViewTextBoxColumn sys_routers;
        private DataGridViewTextBoxColumn sysOSPFArea;
        private ToolStripMenuItem testDataToolStripMenuItem;
    }
}

