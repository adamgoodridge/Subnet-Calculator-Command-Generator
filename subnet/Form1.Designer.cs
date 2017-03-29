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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tablayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableuserdata = new System.Windows.Forms.DataGridView();
            this.NetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermaxhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_routers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.sysOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.intOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GirdViewRouters = new System.Windows.Forms.DataGridView();
            this.routerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerDefaultRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerOSPFEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.routerOSPFRouterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerOSPFProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.GirdViewRouters)).BeginInit();
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
            this.tabRouters.Location = new System.Drawing.Point(0, 24);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.SelectedIndex = 0;
            this.tabRouters.Size = new System.Drawing.Size(957, 543);
            this.tabRouters.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tablayout1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(949, 517);
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
            this.tablayout1.Location = new System.Drawing.Point(3, 6);
            this.tablayout1.Name = "tablayout1";
            this.tablayout1.RowCount = 2;
            this.tablayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.28084F));
            this.tablayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.71916F));
            this.tablayout1.Size = new System.Drawing.Size(952, 509);
            this.tablayout1.TabIndex = 1;
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
            this.tableuserdata.Location = new System.Drawing.Point(3, 19);
            this.tableuserdata.Name = "tableuserdata";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableuserdata.Size = new System.Drawing.Size(946, 487);
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
            // userOSPFArea
            // 
            this.userOSPFArea.HeaderText = "OSPF Area";
            this.userOSPFArea.Name = "userOSPFArea";
            // 
            // tbox1
            // 
            this.tbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox1.Location = new System.Drawing.Point(3, 3);
            this.tbox1.MaxLength = 255;
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(946, 20);
            this.tbox1.TabIndex = 1;
            this.tbox1.Text = "10.0.0.0/16";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tablesysdata);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(949, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.NetworkID,
            this.fusable,
            this.lusable,
            this.BroadCastID,
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
            this.tablesysdata.Location = new System.Drawing.Point(3, 3);
            this.tablesysdata.Name = "tablesysdata";
            this.tablesysdata.ReadOnly = true;
            this.tablesysdata.Size = new System.Drawing.Size(943, 512);
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
            // sysOSPFArea
            // 
            this.sysOSPFArea.HeaderText = "OSPF Area";
            this.sysOSPFArea.Name = "sysOSPFArea";
            this.sysOSPFArea.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(949, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxRouter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCommands);
            this.splitContainer1.Size = new System.Drawing.Size(943, 512);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxRouter
            // 
            this.listBoxRouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRouter.FormattingEnabled = true;
            this.listBoxRouter.Location = new System.Drawing.Point(0, 0);
            this.listBoxRouter.Name = "listBoxRouter";
            this.listBoxRouter.Size = new System.Drawing.Size(310, 512);
            this.listBoxRouter.TabIndex = 0;
            this.listBoxRouter.SelectedIndexChanged += new System.EventHandler(this.listBoxRouter_SelectedIndexChanged);
            // 
            // textBoxCommands
            // 
            this.textBoxCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCommands.Location = new System.Drawing.Point(0, 0);
            this.textBoxCommands.Multiline = true;
            this.textBoxCommands.Name = "textBoxCommands";
            this.textBoxCommands.Size = new System.Drawing.Size(629, 512);
            this.textBoxCommands.TabIndex = 0;
            // 
            // tabIPs
            // 
            this.tabIPs.Controls.Add(this.dataGridViewAddresses);
            this.tabIPs.Location = new System.Drawing.Point(4, 22);
            this.tabIPs.Name = "tabIPs";
            this.tabIPs.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabIPs.Size = new System.Drawing.Size(949, 518);
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
            this.intOSPFArea,
            this.intNetwork,
            this.intDescription});
            this.dataGridViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.ReadOnly = true;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(943, 512);
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
            // intOSPFArea
            // 
            this.intOSPFArea.HeaderText = "OSPF Area";
            this.intOSPFArea.Name = "intOSPFArea";
            this.intOSPFArea.ReadOnly = true;
            // 
            // intNetwork
            // 
            this.intNetwork.HeaderText = "Network Name";
            this.intNetwork.Name = "intNetwork";
            this.intNetwork.ReadOnly = true;
            // 
            // intDescription
            // 
            this.intDescription.HeaderText = "Description";
            this.intDescription.Name = "intDescription";
            this.intDescription.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GirdViewRouters);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(949, 518);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.GirdViewRouters.Location = new System.Drawing.Point(2, 2);
            this.GirdViewRouters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GirdViewRouters.Name = "GirdViewRouters";
            this.GirdViewRouters.RowTemplate.Height = 24;
            this.GirdViewRouters.Size = new System.Drawing.Size(945, 514);
            this.GirdViewRouters.TabIndex = 0;
            this.GirdViewRouters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GirdViewRouters_CellContentClick);
            // 
            // routerName
            // 
            this.routerName.HeaderText = "Router Name";
            this.routerName.Name = "routerName";
            // 
            // routerDefaultRoute
            // 
            this.routerDefaultRoute.HeaderText = "Default Route";
            this.routerDefaultRoute.Name = "routerDefaultRoute";
            // 
            // routerOSPFEnabled
            // 
            this.routerOSPFEnabled.HeaderText = "OSPF";
            this.routerOSPFEnabled.Name = "routerOSPFEnabled";
            // 
            // routerOSPFRouterID
            // 
            this.routerOSPFRouterID.HeaderText = "OSPF Router ID";
            this.routerOSPFRouterID.Name = "routerOSPFRouterID";
            // 
            // routerOSPFProcessID
            // 
            this.routerOSPFProcessID.HeaderText = "OSPF Process ID";
            this.routerOSPFProcessID.Name = "routerOSPFProcessID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.vToolStripMenuItem.Text = "Process";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 567);
            this.Controls.Add(this.tabRouters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            ((System.ComponentModel.ISupportInitialize)(this.GirdViewRouters)).EndInit();
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
        private System.Windows.Forms.DataGridView tablesysdata;
        private System.Windows.Forms.TableLayoutPanel tablayout1;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxRouter;
        private TabPage tabIPs;
        private DataGridView dataGridViewAddresses;
        private ToolStripMenuItem vToolStripMenuItem;
        private TextBox textBoxCommands;
        private TabPage tabPage4;
        private DataGridViewTextBoxColumn routers_name;
        private DataGridViewCheckBoxColumn router_OSPF;
        private DataGridViewTextBoxColumn NetworkName;
        private DataGridViewTextBoxColumn usermaxhosts;
        private DataGridViewTextBoxColumn user_routers;
        private DataGridViewTextBoxColumn userOSPFArea;
        private DataGridViewTextBoxColumn sysnetname;
        private DataGridViewTextBoxColumn hostsrequired;
        private DataGridViewTextBoxColumn minimumhosts;
        private DataGridViewTextBoxColumn maxhosts;
        private DataGridViewTextBoxColumn NetworkID;
        private DataGridViewTextBoxColumn fusable;
        private DataGridViewTextBoxColumn lusable;
        private DataGridViewTextBoxColumn BroadCastID;
        private DataGridViewTextBoxColumn submask;
        private DataGridViewTextBoxColumn sys_routers;
        private DataGridViewTextBoxColumn sysOSPFArea;
        private DataGridViewTextBoxColumn intRouterName;
        private DataGridViewTextBoxColumn intInterface;
        private DataGridViewTextBoxColumn intIP;
        private DataGridViewTextBoxColumn intSubnet;
        private DataGridViewTextBoxColumn intOSPFArea;
        private DataGridViewTextBoxColumn intNetwork;
        private DataGridViewTextBoxColumn intDescription;
        private DataGridView GirdViewRouters;
        private DataGridViewTextBoxColumn routerName;
        private DataGridViewTextBoxColumn routerDefaultRoute;
        private DataGridViewCheckBoxColumn routerOSPFEnabled;
        private DataGridViewTextBoxColumn routerOSPFRouterID;
        private DataGridViewTextBoxColumn routerOSPFProcessID;
    }
}

