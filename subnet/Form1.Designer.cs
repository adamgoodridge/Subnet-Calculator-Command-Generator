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
            this.input1 = new System.Windows.Forms.TabPage();
            this.tabIPs = new System.Windows.Forms.TabPage();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.intRouterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intInterface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSubnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commands = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxRouter = new System.Windows.Forms.ListBox();
            this.textBoxCommands = new System.Windows.Forms.TextBox();
            this.scheme = new System.Windows.Forms.TabPage();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.tableuserdata = new System.Windows.Forms.DataGridView();
            this.NetworkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermaxhosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_routers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userOSPFArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirdViewRouters = new System.Windows.Forms.DataGridView();
            this.routerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerDefaultRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerOSPFEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.routerOSPFRouterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerOSPFProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRouters.SuspendLayout();
            this.input1.SuspendLayout();
            this.tabIPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.commands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.scheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesysdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableuserdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirdViewRouters)).BeginInit();
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
            this.dataGridViewAddresses.Location = new System.Drawing.Point(79, 262);
            this.dataGridViewAddresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.ReadOnly = true;
            this.dataGridViewAddresses.RowHeadersWidth = 62;
            this.dataGridViewAddresses.Size = new System.Drawing.Size(923, 399);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesysdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesysdata.DefaultCellStyle = dataGridViewCellStyle7;
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
            // NetworkID
            // 
            this.NetworkID.HeaderText = "Network ID";
            this.NetworkID.MinimumWidth = 8;
            this.NetworkID.Name = "NetworkID";
            this.NetworkID.ReadOnly = true;
            this.NetworkID.Width = 150;
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
            // BroadCastID
            // 
            this.BroadCastID.HeaderText = "BroadCast ID";
            this.BroadCastID.MinimumWidth = 8;
            this.BroadCastID.Name = "BroadCastID";
            this.BroadCastID.ReadOnly = true;
            this.BroadCastID.Width = 150;
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
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem});
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GirdViewRouters, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbox1, 0, 0);
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
            // tbox1
            // 
            this.tbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbox1.Location = new System.Drawing.Point(4, 5);
            this.tbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbox1.MaxLength = 255;
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(1412, 26);
            this.tbox1.TabIndex = 3;
            this.tbox1.Text = "10.0.0.0/16";
            // 
            // tableuserdata
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableuserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableuserdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NetworkName,
            this.usermaxhosts,
            this.user_routers,
            this.userOSPFArea});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableuserdata.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableuserdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableuserdata.Location = new System.Drawing.Point(4, 46);
            this.tableuserdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableuserdata.Name = "tableuserdata";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableuserdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            this.tabIPs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.commands.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablesysdata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableuserdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirdViewRouters)).EndInit();
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
        private DataGridViewTextBoxColumn routers_name;
        private DataGridViewCheckBoxColumn router_OSPF;
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
        private TextBox tbox1;
        private DataGridView tableuserdata;
        private DataGridViewTextBoxColumn NetworkName;
        private DataGridViewTextBoxColumn usermaxhosts;
        private DataGridViewTextBoxColumn user_routers;
        private DataGridViewTextBoxColumn userOSPFArea;
    }
}

