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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRouters = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tablayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableuserdata = new System.Windows.Forms.DataGridView();
            this.NetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermaxhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_routers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tablesysdata = new System.Windows.Forms.DataGridView();
            this.sysnetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostsrequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetworkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fusable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lusable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BroadCastID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sys_routers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxRouter = new System.Windows.Forms.ListBox();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.tabIPs = new System.Windows.Forms.TabPage();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.intRouterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intInterface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSubnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GirdView = new System.Windows.Forms.DataGridView();
            this.routers_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.router_default_route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.router_OSPF = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.router_OSPF_router_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.butrun = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRouters.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tablayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableuserdata)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesysdata)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabIPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirdView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(this.tabPage1);
            this.tabRouters.Controls.Add(this.tabPage2);
            this.tabRouters.Controls.Add(this.tabPage3);
            this.tabRouters.Controls.Add(this.tabIPs);
            this.tabRouters.Controls.Add(this.tabPage4);
            this.tabRouters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRouters.Location = new System.Drawing.Point(0, 28);
            this.tabRouters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.SelectedIndex = 0;
            this.tabRouters.Size = new System.Drawing.Size(1500, 771);
            this.tabRouters.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tablayout1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1492, 742);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tablayout1
            // 
            this.tablayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablayout1.ColumnCount = 1;
            this.tablayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayout1.Controls.Add(this.tableuserdata, 0, 1);
            this.tablayout1.Controls.Add(this.tbox1, 0, 0);
            this.tablayout1.Location = new System.Drawing.Point(4, 7);
            this.tablayout1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablayout1.Name = "tablayout1";
            this.tablayout1.RowCount = 2;
            this.tablayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.28084F));
            this.tablayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.71916F));
            this.tablayout1.Size = new System.Drawing.Size(1492, 728);
            this.tablayout1.TabIndex = 1;
            // 
            // tableuserdata
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableuserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableuserdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NetworkName,
            this.usermaxhosts,
            this.user_routers});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableuserdata.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableuserdata.Location = new System.Drawing.Point(4, 27);
            this.tableuserdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableuserdata.Name = "tableuserdata";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableuserdata.Size = new System.Drawing.Size(1475, 695);
            this.tableuserdata.TabIndex = 0;
            this.tableuserdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableuserdata_CellContentClick);
            // 
            // NetworkName
            // 
            this.NetworkName.HeaderText = "Network Name";
            this.NetworkName.Name = "NetworkName";
            // 
            // usermaxhosts
            // 
            this.usermaxhosts.HeaderText = "Maxinum Of Hosts";
            this.usermaxhosts.Name = "usermaxhosts";
            // 
            // user_routers
            // 
            this.user_routers.HeaderText = "Routers";
            this.user_routers.Name = "user_routers";
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(4, 4);
            this.tbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox1.MaxLength = 255;
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(1063, 22);
            this.tbox1.TabIndex = 1;
            this.tbox1.Text = "200::/16";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tablesysdata);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1492, 742);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tablesysdata
            // 
            this.tablesysdata.AllowUserToAddRows = false;
            this.tablesysdata.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesysdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablesysdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesysdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sysnetname,
            this.hostsrequired,
            this.minimumhosts,
            this.maxhosts,
            this.NetworkID,
            this.fusable,
            this.lusable,
            this.BroadCastID,
            this.submask,
            this.sys_routers});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesysdata.DefaultCellStyle = dataGridViewCellStyle10;
            this.tablesysdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesysdata.Location = new System.Drawing.Point(4, 4);
            this.tablesysdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablesysdata.Name = "tablesysdata";
            this.tablesysdata.ReadOnly = true;
            this.tablesysdata.Size = new System.Drawing.Size(1484, 734);
            this.tablesysdata.TabIndex = 1;
            // 
            // sysnetname
            // 
            this.sysnetname.HeaderText = "Network Name";
            this.sysnetname.Name = "sysnetname";
            this.sysnetname.ReadOnly = true;
            // 
            // hostsrequired
            // 
            this.hostsrequired.HeaderText = "Hosts Required";
            this.hostsrequired.Name = "hostsrequired";
            this.hostsrequired.ReadOnly = true;
            // 
            // minimumhosts
            // 
            this.minimumhosts.HeaderText = "Minimum Of Hosts";
            this.minimumhosts.Name = "minimumhosts";
            this.minimumhosts.ReadOnly = true;
            // 
            // maxhosts
            // 
            this.maxhosts.HeaderText = "Maxinum Of Hosts";
            this.maxhosts.Name = "maxhosts";
            this.maxhosts.ReadOnly = true;
            // 
            // NetworkID
            // 
            this.NetworkID.HeaderText = "Network ID";
            this.NetworkID.Name = "NetworkID";
            this.NetworkID.ReadOnly = true;
            // 
            // fusable
            // 
            this.fusable.HeaderText = "First Usable Address";
            this.fusable.Name = "fusable";
            this.fusable.ReadOnly = true;
            // 
            // lusable
            // 
            this.lusable.HeaderText = "Last Useable Address";
            this.lusable.Name = "lusable";
            this.lusable.ReadOnly = true;
            // 
            // BroadCastID
            // 
            this.BroadCastID.HeaderText = "BroadCast ID";
            this.BroadCastID.Name = "BroadCastID";
            this.BroadCastID.ReadOnly = true;
            // 
            // submask
            // 
            this.submask.HeaderText = "Submask";
            this.submask.Name = "submask";
            this.submask.ReadOnly = true;
            // 
            // sys_routers
            // 
            this.sys_routers.HeaderText = "Routers";
            this.sys_routers.Name = "sys_routers";
            this.sys_routers.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1492, 742);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxRouter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCommands);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 734);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxRouter
            // 
            this.listBoxRouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRouter.FormattingEnabled = true;
            this.listBoxRouter.ItemHeight = 16;
            this.listBoxRouter.Location = new System.Drawing.Point(0, 0);
            this.listBoxRouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxRouter.Name = "listBoxRouter";
            this.listBoxRouter.Size = new System.Drawing.Size(491, 734);
            this.listBoxRouter.TabIndex = 0;
            this.listBoxRouter.SelectedIndexChanged += new System.EventHandler(this.listBoxRouter_SelectedIndexChanged);
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCommands.Location = new System.Drawing.Point(0, 0);
            this.textBoxCommands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCommands.Multiline = true;
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(988, 734);
            this.textBoxCommands.TabIndex = 0;
            // 
            // tabIPs
            // 
            this.tabIPs.Controls.Add(this.dataGridViewAddresses);
            this.tabIPs.Location = new System.Drawing.Point(4, 25);
            this.tabIPs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIPs.Name = "tabIPs";
            this.tabIPs.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIPs.Size = new System.Drawing.Size(1492, 742);
            this.tabIPs.TabIndex = 3;
            this.tabIPs.Text = "IP addresses";
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
            this.intNetwork});
            this.dataGridViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewAddresses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.ReadOnly = true;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(1484, 734);
            this.dataGridViewAddresses.TabIndex = 0;
            // 
            // intRouterName
            // 
            this.intRouterName.HeaderText = "Router Name";
            this.intRouterName.Name = "intRouterName";
            this.intRouterName.ReadOnly = true;
            // 
            // intInterface
            // 
            this.intInterface.HeaderText = "Interface";
            this.intInterface.Name = "intInterface";
            this.intInterface.ReadOnly = true;
            // 
            // intIP
            // 
            this.intIP.HeaderText = "IP Address";
            this.intIP.Name = "intIP";
            this.intIP.ReadOnly = true;
            // 
            // intSubnet
            // 
            this.intSubnet.HeaderText = "Subnet";
            this.intSubnet.Name = "intSubnet";
            this.intSubnet.ReadOnly = true;
            // 
            // intNetwork
            // 
            this.intNetwork.HeaderText = "Network Name";
            this.intNetwork.Name = "intNetwork";
            this.intNetwork.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GirdView);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1492, 742);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GirdView
            // 
            this.GirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GirdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routers_name,
            this.router_default_route,
            this.router_OSPF,
            this.router_OSPF_router_id});
            this.GirdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GirdView.Location = new System.Drawing.Point(3, 2);
            this.GirdView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GirdView.Name = "GirdView";
            this.GirdView.RowTemplate.Height = 24;
            this.GirdView.Size = new System.Drawing.Size(1486, 738);
            this.GirdView.TabIndex = 0;
            // 
            // routers_name
            // 
            this.routers_name.HeaderText = "Router Name";
            this.routers_name.Name = "routers_name";
            // 
            // router_default_route
            // 
            this.router_default_route.HeaderText = "Default Route";
            this.router_default_route.Name = "router_default_route";
            // 
            // router_OSPF
            // 
            this.router_OSPF.HeaderText = "OSPF";
            this.router_OSPF.Name = "router_OSPF";
            // 
            // router_OSPF_router_id
            // 
            this.router_OSPF_router_id.HeaderText = "OSPF Router ID";
            this.router_OSPF_router_id.Name = "router_OSPF_router_id";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butrun,
            this.vToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1500, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // butrun
            // 
            this.butrun.Name = "butrun";
            this.butrun.Size = new System.Drawing.Size(46, 24);
            this.butrun.Text = "Run";
            this.butrun.Click += new System.EventHandler(this.butrun_Click);
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(28, 24);
            this.vToolStripMenuItem.Text = "v";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.testToolStripMenuItem.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 799);
            this.Controls.Add(this.tabRouters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRouters.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tablayout1.ResumeLayout(false);
            this.tablayout1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableuserdata)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesysdata)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabIPs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GirdView)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tableuserdata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem butrun;
        private System.Windows.Forms.DataGridView tablesysdata;
        private System.Windows.Forms.TableLayoutPanel tablayout1;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxRouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetworkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn usermaxhosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_routers;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysnetname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostsrequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumhosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxhosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetworkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fusable;
        private System.Windows.Forms.DataGridViewTextBoxColumn lusable;
        private System.Windows.Forms.DataGridViewTextBoxColumn BroadCastID;
        private System.Windows.Forms.DataGridViewTextBoxColumn submask;
        private System.Windows.Forms.DataGridViewTextBoxColumn sys_routers;
        private TabPage tabIPs;
        private DataGridView dataGridViewAddresses;
        private DataGridViewTextBoxColumn intRouterName;
        private DataGridViewTextBoxColumn intInterface;
        private DataGridViewTextBoxColumn intIP;
        private DataGridViewTextBoxColumn intSubnet;
        private DataGridViewTextBoxColumn intNetwork;
        private ToolStripMenuItem vToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private TextBox textBoxCommands;
        private TabPage tabPage4;
        private DataGridView GirdView;
        private DataGridViewTextBoxColumn routers_name;
        private DataGridViewTextBoxColumn router_default_route;
        private DataGridViewCheckBoxColumn router_OSPF;
        private DataGridViewTextBoxColumn router_OSPF_router_id;
    }
}

