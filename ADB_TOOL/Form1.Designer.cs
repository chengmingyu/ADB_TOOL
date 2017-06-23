namespace ADB_TOOL
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                AdbHelper.KillServer();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbtn_unroot = new System.Windows.Forms.RadioButton();
            this.Rbtn_root = new System.Windows.Forms.RadioButton();
            this.tabWifiConn = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.txtApkPath = new System.Windows.Forms.TextBox();
            this.TxtDDMS = new System.Windows.Forms.TextBox();
            this.TxtTIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUSB_INFO = new System.Windows.Forms.TextBox();
            this.txtUSB_Serial = new System.Windows.Forms.TextBox();
            this.btnClearSelectedUSB = new System.Windows.Forms.Button();
            this.btnSelectUSB = new System.Windows.Forms.Button();
            this.btnUSBRefresh = new System.Windows.Forms.Button();
            this.listViewUSB = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeviceSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnWifiDis = new System.Windows.Forms.Button();
            this.btnCallDDMS = new System.Windows.Forms.Button();
            this.btnWifiConncetion = new System.Windows.Forms.Button();
            this.txtTPort = new System.Windows.Forms.TextBox();
            this.txtShowTIP = new System.Windows.Forms.TextBox();
            this.txtShowTDI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_apk = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewAPK = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMsg = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_wifi = new System.Windows.Forms.Label();
            this.lb_usb = new System.Windows.Forms.Label();
            this.lb_config = new System.Windows.Forms.Label();
            this.cb_WIFI = new System.Windows.Forms.CheckBox();
            this.cb_USB = new System.Windows.Forms.CheckBox();
            this.cb_conifg = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabWifiConn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbtn_unroot);
            this.groupBox1.Controls.Add(this.Rbtn_root);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WORK MODE";
            // 
            // Rbtn_unroot
            // 
            this.Rbtn_unroot.AutoSize = true;
            this.Rbtn_unroot.Checked = true;
            this.Rbtn_unroot.Location = new System.Drawing.Point(30, 30);
            this.Rbtn_unroot.Name = "Rbtn_unroot";
            this.Rbtn_unroot.Size = new System.Drawing.Size(121, 28);
            this.Rbtn_unroot.TabIndex = 1;
            this.Rbtn_unroot.TabStop = true;
            this.Rbtn_unroot.Text = "UNROOT";
            this.Rbtn_unroot.UseVisualStyleBackColor = true;
            // 
            // Rbtn_root
            // 
            this.Rbtn_root.AutoSize = true;
            this.Rbtn_root.Location = new System.Drawing.Point(182, 30);
            this.Rbtn_root.Name = "Rbtn_root";
            this.Rbtn_root.Size = new System.Drawing.Size(91, 28);
            this.Rbtn_root.TabIndex = 0;
            this.Rbtn_root.Text = "ROOT";
            this.Rbtn_root.UseVisualStyleBackColor = true;
            // 
            // tabWifiConn
            // 
            this.tabWifiConn.Controls.Add(this.tabPage1);
            this.tabWifiConn.Controls.Add(this.tabPage4);
            this.tabWifiConn.Controls.Add(this.tabPage2);
            this.tabWifiConn.Controls.Add(this.tabPage3);
            this.tabWifiConn.Location = new System.Drawing.Point(12, 205);
            this.tabWifiConn.Name = "tabWifiConn";
            this.tabWifiConn.SelectedIndex = 0;
            this.tabWifiConn.Size = new System.Drawing.Size(725, 351);
            this.tabWifiConn.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnApply);
            this.tabPage1.Controls.Add(this.BtnModify);
            this.tabPage1.Controls.Add(this.txtApkPath);
            this.tabPage1.Controls.Add(this.TxtDDMS);
            this.tabPage1.Controls.Add(this.TxtTIP);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnApply
            // 
            this.BtnApply.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnApply.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnApply.Location = new System.Drawing.Point(607, 282);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(104, 37);
            this.BtnApply.TabIndex = 3;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnModify.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnModify.Location = new System.Drawing.Point(497, 282);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(104, 37);
            this.BtnModify.TabIndex = 3;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // txtApkPath
            // 
            this.txtApkPath.Enabled = false;
            this.txtApkPath.Location = new System.Drawing.Point(185, 74);
            this.txtApkPath.Name = "txtApkPath";
            this.txtApkPath.Size = new System.Drawing.Size(485, 19);
            this.txtApkPath.TabIndex = 2;
            // 
            // TxtDDMS
            // 
            this.TxtDDMS.Enabled = false;
            this.TxtDDMS.Location = new System.Drawing.Point(185, 44);
            this.TxtDDMS.Name = "TxtDDMS";
            this.TxtDDMS.Size = new System.Drawing.Size(485, 19);
            this.TxtDDMS.TabIndex = 2;
            // 
            // TxtTIP
            // 
            this.TxtTIP.Enabled = false;
            this.TxtTIP.Location = new System.Drawing.Point(185, 15);
            this.TxtTIP.Name = "TxtTIP";
            this.TxtTIP.Size = new System.Drawing.Size(204, 19);
            this.TxtTIP.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "APK PATH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "DDMS FULL PATH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Target Device IP";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtUSB_INFO);
            this.tabPage4.Controls.Add(this.txtUSB_Serial);
            this.tabPage4.Controls.Add(this.btnClearSelectedUSB);
            this.tabPage4.Controls.Add(this.btnSelectUSB);
            this.tabPage4.Controls.Add(this.btnUSBRefresh);
            this.tabPage4.Controls.Add(this.listViewUSB);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(717, 325);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "USB connection";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUSB_INFO
            // 
            this.txtUSB_INFO.Enabled = false;
            this.txtUSB_INFO.Location = new System.Drawing.Point(123, 232);
            this.txtUSB_INFO.Name = "txtUSB_INFO";
            this.txtUSB_INFO.Size = new System.Drawing.Size(573, 19);
            this.txtUSB_INFO.TabIndex = 6;
            // 
            // txtUSB_Serial
            // 
            this.txtUSB_Serial.Enabled = false;
            this.txtUSB_Serial.Location = new System.Drawing.Point(123, 196);
            this.txtUSB_Serial.Name = "txtUSB_Serial";
            this.txtUSB_Serial.Size = new System.Drawing.Size(573, 19);
            this.txtUSB_Serial.TabIndex = 6;
            // 
            // btnClearSelectedUSB
            // 
            this.btnClearSelectedUSB.Location = new System.Drawing.Point(621, 267);
            this.btnClearSelectedUSB.Name = "btnClearSelectedUSB";
            this.btnClearSelectedUSB.Size = new System.Drawing.Size(75, 23);
            this.btnClearSelectedUSB.TabIndex = 5;
            this.btnClearSelectedUSB.Text = "Clear";
            this.btnClearSelectedUSB.UseVisualStyleBackColor = true;
            this.btnClearSelectedUSB.Click += new System.EventHandler(this.btnClearSelectedUSB_Click);
            // 
            // btnSelectUSB
            // 
            this.btnSelectUSB.Location = new System.Drawing.Point(371, 267);
            this.btnSelectUSB.Name = "btnSelectUSB";
            this.btnSelectUSB.Size = new System.Drawing.Size(75, 23);
            this.btnSelectUSB.TabIndex = 4;
            this.btnSelectUSB.Text = "Select";
            this.btnSelectUSB.UseVisualStyleBackColor = true;
            this.btnSelectUSB.Click += new System.EventHandler(this.btnSelectUSB_Click);
            // 
            // btnUSBRefresh
            // 
            this.btnUSBRefresh.Location = new System.Drawing.Point(123, 267);
            this.btnUSBRefresh.Name = "btnUSBRefresh";
            this.btnUSBRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnUSBRefresh.TabIndex = 3;
            this.btnUSBRefresh.Text = "Refresh";
            this.btnUSBRefresh.UseVisualStyleBackColor = true;
            this.btnUSBRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewUSB
            // 
            this.listViewUSB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderDeviceSerial});
            this.listViewUSB.FullRowSelect = true;
            this.listViewUSB.Location = new System.Drawing.Point(123, 16);
            this.listViewUSB.Name = "listViewUSB";
            this.listViewUSB.Size = new System.Drawing.Size(573, 151);
            this.listViewUSB.TabIndex = 2;
            this.listViewUSB.UseCompatibleStateImageBehavior = false;
            this.listViewUSB.View = System.Windows.Forms.View.Details;
            this.listViewUSB.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewUSB_ItemSelectionChanged);
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No.";
            this.columnHeaderNo.Width = 72;
            // 
            // columnHeaderDeviceSerial
            // 
            this.columnHeaderDeviceSerial.Text = "Device serial";
            this.columnHeaderDeviceSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDeviceSerial.Width = 495;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Device Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(11, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Device serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Device List";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnWifiDis);
            this.tabPage2.Controls.Add(this.btnCallDDMS);
            this.tabPage2.Controls.Add(this.btnWifiConncetion);
            this.tabPage2.Controls.Add(this.txtTPort);
            this.tabPage2.Controls.Add(this.txtShowTIP);
            this.tabPage2.Controls.Add(this.txtShowTDI);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WIFI connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnWifiDis
            // 
            this.btnWifiDis.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWifiDis.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnWifiDis.Location = new System.Drawing.Point(413, 273);
            this.btnWifiDis.Name = "btnWifiDis";
            this.btnWifiDis.Size = new System.Drawing.Size(104, 37);
            this.btnWifiDis.TabIndex = 10;
            this.btnWifiDis.Text = "DisConncete";
            this.btnWifiDis.UseVisualStyleBackColor = true;
            this.btnWifiDis.Click += new System.EventHandler(this.btnWifiDis_Click);
            // 
            // btnCallDDMS
            // 
            this.btnCallDDMS.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCallDDMS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCallDDMS.Location = new System.Drawing.Point(557, 273);
            this.btnCallDDMS.Name = "btnCallDDMS";
            this.btnCallDDMS.Size = new System.Drawing.Size(142, 37);
            this.btnCallDDMS.TabIndex = 10;
            this.btnCallDDMS.Text = "DDMS START";
            this.btnCallDDMS.UseVisualStyleBackColor = true;
            this.btnCallDDMS.Click += new System.EventHandler(this.btnCallDDMS_Click);
            // 
            // btnWifiConncetion
            // 
            this.btnWifiConncetion.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWifiConncetion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnWifiConncetion.Location = new System.Drawing.Point(269, 273);
            this.btnWifiConncetion.Name = "btnWifiConncetion";
            this.btnWifiConncetion.Size = new System.Drawing.Size(104, 37);
            this.btnWifiConncetion.TabIndex = 10;
            this.btnWifiConncetion.Text = "Conncete";
            this.btnWifiConncetion.UseVisualStyleBackColor = true;
            this.btnWifiConncetion.Click += new System.EventHandler(this.btnWifiConncetion_Click);
            // 
            // txtTPort
            // 
            this.txtTPort.Location = new System.Drawing.Point(178, 83);
            this.txtTPort.Name = "txtTPort";
            this.txtTPort.Size = new System.Drawing.Size(204, 19);
            this.txtTPort.TabIndex = 9;
            this.txtTPort.Text = "5555";
            // 
            // txtShowTIP
            // 
            this.txtShowTIP.Enabled = false;
            this.txtShowTIP.Location = new System.Drawing.Point(178, 16);
            this.txtShowTIP.Name = "txtShowTIP";
            this.txtShowTIP.Size = new System.Drawing.Size(204, 19);
            this.txtShowTIP.TabIndex = 9;
            // 
            // txtShowTDI
            // 
            this.txtShowTDI.Enabled = false;
            this.txtShowTDI.Location = new System.Drawing.Point(178, 49);
            this.txtShowTDI.Name = "txtShowTDI";
            this.txtShowTDI.Size = new System.Drawing.Size(516, 19);
            this.txtShowTDI.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(10, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Target Device Info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(10, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Target Device Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(10, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Target Device IP";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lb_apk);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.listViewAPK);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(717, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Install APK";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lb_apk
            // 
            this.lb_apk.AutoSize = true;
            this.lb_apk.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_apk.Location = new System.Drawing.Point(15, 265);
            this.lb_apk.Name = "lb_apk";
            this.lb_apk.Size = new System.Drawing.Size(37, 19);
            this.lb_apk.TabIndex = 5;
            this.lb_apk.Text = "null";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "INSTALL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listViewAPK
            // 
            this.listViewAPK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewAPK.FullRowSelect = true;
            this.listViewAPK.Location = new System.Drawing.Point(7, 6);
            this.listViewAPK.Name = "listViewAPK";
            this.listViewAPK.Size = new System.Drawing.Size(703, 243);
            this.listViewAPK.TabIndex = 3;
            this.listViewAPK.UseCompatibleStateImageBehavior = false;
            this.listViewAPK.View = System.Windows.Forms.View.Details;
            this.listViewAPK.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAPK_ItemSelectionChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "APK";
            this.columnHeader2.Width = 696;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtIP);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local IP";
            // 
            // TxtIP
            // 
            this.TxtIP.AutoSize = true;
            this.TxtIP.Location = new System.Drawing.Point(6, 34);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(121, 24);
            this.TxtIP.TabIndex = 0;
            this.TxtIP.Text = "192.168.1.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create by Tei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "V 1.0";
            // 
            // TxtMsg
            // 
            this.TxtMsg.AutoSize = true;
            this.TxtMsg.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMsg.ForeColor = System.Drawing.Color.Maroon;
            this.TxtMsg.Location = new System.Drawing.Point(13, 570);
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.Size = new System.Drawing.Size(41, 16);
            this.TxtMsg.TabIndex = 4;
            this.TxtMsg.Text = "MSG";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_wifi);
            this.groupBox3.Controls.Add(this.lb_usb);
            this.groupBox3.Controls.Add(this.lb_config);
            this.groupBox3.Controls.Add(this.cb_WIFI);
            this.groupBox3.Controls.Add(this.cb_USB);
            this.groupBox3.Controls.Add(this.cb_conifg);
            this.groupBox3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WORK STATUS";
            // 
            // lb_wifi
            // 
            this.lb_wifi.AutoSize = true;
            this.lb_wifi.ForeColor = System.Drawing.Color.Red;
            this.lb_wifi.Location = new System.Drawing.Point(605, 61);
            this.lb_wifi.Name = "lb_wifi";
            this.lb_wifi.Size = new System.Drawing.Size(24, 24);
            this.lb_wifi.TabIndex = 1;
            this.lb_wifi.Text = "X";
            // 
            // lb_usb
            // 
            this.lb_usb.AutoSize = true;
            this.lb_usb.ForeColor = System.Drawing.Color.Red;
            this.lb_usb.Location = new System.Drawing.Point(333, 61);
            this.lb_usb.Name = "lb_usb";
            this.lb_usb.Size = new System.Drawing.Size(24, 24);
            this.lb_usb.TabIndex = 1;
            this.lb_usb.Text = "X";
            // 
            // lb_config
            // 
            this.lb_config.AutoSize = true;
            this.lb_config.ForeColor = System.Drawing.Color.Green;
            this.lb_config.Location = new System.Drawing.Point(78, 61);
            this.lb_config.Name = "lb_config";
            this.lb_config.Size = new System.Drawing.Size(27, 24);
            this.lb_config.TabIndex = 1;
            this.lb_config.Text = "O";
            // 
            // cb_WIFI
            // 
            this.cb_WIFI.AutoSize = true;
            this.cb_WIFI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_WIFI.Location = new System.Drawing.Point(522, 31);
            this.cb_WIFI.Name = "cb_WIFI";
            this.cb_WIFI.Size = new System.Drawing.Size(192, 28);
            this.cb_WIFI.TabIndex = 0;
            this.cb_WIFI.Text = "WIFI Connection";
            this.cb_WIFI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_WIFI.UseVisualStyleBackColor = true;
            this.cb_WIFI.CheckStateChanged += new System.EventHandler(this.cb_WIFI_CheckStateChanged);
            // 
            // cb_USB
            // 
            this.cb_USB.AutoSize = true;
            this.cb_USB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_USB.Location = new System.Drawing.Point(250, 31);
            this.cb_USB.Name = "cb_USB";
            this.cb_USB.Size = new System.Drawing.Size(193, 28);
            this.cb_USB.TabIndex = 0;
            this.cb_USB.Text = "USB Connection";
            this.cb_USB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_USB.UseVisualStyleBackColor = true;
            this.cb_USB.CheckStateChanged += new System.EventHandler(this.cb_USB_CheckStateChanged);
            // 
            // cb_conifg
            // 
            this.cb_conifg.AutoSize = true;
            this.cb_conifg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_conifg.Location = new System.Drawing.Point(11, 31);
            this.cb_conifg.Name = "cb_conifg";
            this.cb_conifg.Size = new System.Drawing.Size(160, 28);
            this.cb_conifg.TabIndex = 0;
            this.cb_conifg.Text = "Configuration";
            this.cb_conifg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_conifg.UseVisualStyleBackColor = true;
            this.cb_conifg.CheckStateChanged += new System.EventHandler(this.cb_conifg_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 595);
            this.Controls.Add(this.TxtMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabWifiConn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ADB_TOOL";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabWifiConn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbtn_unroot;
        private System.Windows.Forms.RadioButton Rbtn_root;
        private System.Windows.Forms.TabControl tabWifiConn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TxtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxtMsg;
        private System.Windows.Forms.TextBox TxtDDMS;
        private System.Windows.Forms.TextBox TxtTIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.TextBox txtApkPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listViewUSB;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderDeviceSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUSBRefresh;
        private System.Windows.Forms.TextBox txtUSB_Serial;
        private System.Windows.Forms.Button btnClearSelectedUSB;
        private System.Windows.Forms.Button btnSelectUSB;
        private System.Windows.Forms.TextBox txtUSB_INFO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_WIFI;
        private System.Windows.Forms.CheckBox cb_USB;
        private System.Windows.Forms.CheckBox cb_conifg;
        private System.Windows.Forms.Button btnWifiConncetion;
        private System.Windows.Forms.TextBox txtShowTIP;
        private System.Windows.Forms.TextBox txtShowTDI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnWifiDis;
        private System.Windows.Forms.Label lb_wifi;
        private System.Windows.Forms.Label lb_usb;
        private System.Windows.Forms.Label lb_config;
        private System.Windows.Forms.Button btnCallDDMS;
        private System.Windows.Forms.TextBox txtTPort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listViewAPK;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lb_apk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

