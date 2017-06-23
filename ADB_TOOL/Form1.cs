using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ADB_TOOL
{
    public partial class Form1 : Form
    {
        public String StrTargetIP;
        public String StrDDMS;
        public String StrApkPaht;

        public Form1()
        {
            InitializeComponent();
            // get local ip
            GetLocalIPAddress();
            // init
            init();

        }


        #region 共通関数

        /// <summary>
        /// コンフィグファイル読取
        /// </summary>
        /// <returns>読取結果</returns>
        public bool ReadCfgFile()
        {
            // 読み込み結果
            bool reFlg = true;
            try
            {
                XmlDocument cfg_file = new XmlDocument();
                XmlReaderSettings settings = new XmlReaderSettings();
                // コメントを無視する
                settings.IgnoreComments = true;
                // 設定ファイルの名前：cfg.xml
                //20170130
                XmlReader reader = XmlReader.Create(@"adb_tool_cfg.xml", settings);
                cfg_file.Load(reader);
                XmlNode xn = cfg_file.SelectSingleNode("setting");
                XmlNodeList xnl = xn.ChildNodes;

                // パラメータの取得と設定
                foreach (XmlNode xn1 in xnl)
                {
                    XmlElement xe = (XmlElement)xn1;
                    if (xe.Name == "TIP")
                    {
                        this.TxtTIP.Text = xe.InnerText;
                        StrTargetIP = xe.InnerText;
                        this.txtShowTIP.Text = xe.InnerText;
                    }
                    if (xe.Name == "DDMS")
                    {
                        this.TxtDDMS.Text = xe.InnerText;
                        StrDDMS = xe.InnerText;
                    }
                    if (xe.Name == "APK")
                    {
                        this.txtApkPath.Text = xe.InnerText;
                        StrApkPaht = xe.InnerText;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                reFlg = false;
                return false;
            }

            this.cb_conifg.CheckState = CheckState.Checked;
            return reFlg;
        }


        /// <summary>
        ///get IP
        /// </summary>
        /// <returns></returns>
        private void GetLocalIPAddress()
        {
            //System.Net.IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            //string strNativeIP = "";
            //string strServerIP = "";
            //if (addressList.Length > 1)
            //{
            //    strNativeIP = addressList[0].ToString();
            //    strServerIP = addressList[1].ToString();
            //}
            //else if (addressList.Length == 1)
            //{
            //    strServerIP = addressList[0].ToString();
            //}

            IPAddress[] localIPs;
            localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            StringCollection IpCollection = new StringCollection();
            foreach (IPAddress ip in localIPs)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    IpCollection.Add(ip.ToString());
            }
            string[] IpArray = new string[IpCollection.Count];
            IpCollection.CopyTo(IpArray, 0);

            this.TxtIP.Text = IpArray[0];
        }

        /// <summary>
        /// SHOW MSG  Method
        /// </summary>
        /// <param name="msg"></param>
        public void ShowMsg(String msg)
        {
            this.TxtMsg.Text = msg;
            Refresh();
        }

        /// <summary>
        /// starting init
        /// </summary>
        /// <returns></returns>
        public bool init()
        {
            // UI init
            bool reFlg = true;
            this.BtnModify.Enabled = true;
            this.BtnApply.Enabled = false;
            this.cb_conifg.Enabled = false;
            this.cb_USB.Enabled = false;
            this.cb_WIFI.Enabled = false;
            this.txtShowTIP.Enabled = false;
            this.txtShowTDI.Enabled = false;

            return reFlg;
        }

        /// <summary>
        ///  Setting Modifty
        /// </summary>
        public void ModiftySetting()
        {
            // clear setting
            StrDDMS = null;
            StrTargetIP = null;

            // UI Change
            this.TxtDDMS.Enabled = true;
            this.TxtTIP.Enabled = true;
            this.txtApkPath.Enabled = true;
            this.BtnModify.Enabled = false;
            this.BtnApply.Enabled = true;
            this.cb_conifg.CheckState = CheckState.Unchecked;
            ShowMsg("type into setting information");
        }

        /// <summary>
        /// Setting Apply
        /// </summary>
        public void ApplySetting()
        {
            // setting apply
            StrDDMS = this.TxtDDMS.Text;
            StrTargetIP = this.TxtTIP.Text;

            //UI Change
            this.TxtDDMS.Enabled = false;
            this.TxtTIP.Enabled = false;
            this.txtApkPath.Enabled = false;
            this.BtnModify.Enabled = true;
            this.BtnApply.Enabled = false;
            this.cb_conifg.CheckState = CheckState.Checked;
            this.txtShowTIP.Text = this.TxtTIP.Text;
            //this.btnWifiDis.Enabled = false;
            ShowMsg("setting was changed");
        }

        /// <summary>
        /// USB connection tab 
        /// </summary>
        public void GetUSBInfoList()
        {
            ShowMsg("Loading USB Connection Information");
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //start services
                if (!AdbHelper.StartServer())
                {
                    ShowMsg("USB ADB Service start is failed  !!!");
                    return;
                }

                //get devices list
                var devs = AdbHelper.GetDevices();
                if (devs.Length == 0)
                {
                    ShowMsg("not found Device！");
                    return;
                }
                if (txtUSB_INFO.Text.Contains("error: device offline"))
                {
                    ShowMsg("ERROR Try again");
                    return;
                }

                this.listViewUSB.Items.Clear();
                this.txtUSB_INFO.Clear();
                this.txtUSB_Serial.Clear();
                int iUSB_Devices_NO = 1;
                // insert item to list
                foreach (var dev in devs)
                {
                    ListViewItem item = new ListViewItem(new string[] { iUSB_Devices_NO.ToString(), dev.ToString() });
                    this.listViewUSB.Items.Add(item);
                    iUSB_Devices_NO++;
                }
            }
            catch (Exception e)
            {
                ShowMsg("USB Connection ERROR");
            }
            ShowMsg("USB Connection Information was refreshed");
        }

        /// <summary>
        ///  access wifi
        /// </summary>
        public void WIFI_CON()
        {
            ShowMsg("Connecting devices by WIFI");
            Cursor.Current = Cursors.WaitCursor;
            if (AdbHelper.MakeWifiConn(this.txtUSB_Serial.Text, StrTargetIP, this.txtTPort.Text))
            {
                this.btnWifiDis.Enabled = true;
                this.btnWifiConncetion.Enabled = false;
                this.cb_WIFI.CheckState = CheckState.Checked;
                ShowMsg("WIFI Connection OK!!!!");
            }
            else {
                ShowMsg("WIFI Connection Failed!!!!");
            }
        }

        public void WIFI_DIS()
        {

            if (AdbHelper.KillWifiConn(this.txtUSB_Serial.Text, StrTargetIP, this.txtTPort.Text))
            {
                this.btnWifiDis.Enabled = false;
                this.btnWifiConncetion.Enabled = true;
                this.cb_WIFI.CheckState = CheckState.Unchecked;

            }
            else {
                ShowMsg("WIFI DisConnection Failed!!!!");
            }
        }


        /// <summary>
        /// call ddms
        /// </summary>
        public void CallDDMS()
        {

            try {
                Process.Start(StrDDMS);
            } catch (Exception e) {
                ShowMsg("Can't start DDMS");
            }

        }

        /// <summary>
        /// get apk list
        /// </summary>
        public void GetAPKlist() {
            try
            {
                var files = Directory.GetFiles(StrApkPaht, "*.apk");
                this.listViewAPK.Items.Clear();
                foreach (var file in files)
                {
                    ListViewItem item = new ListViewItem(new string[] { file.ToString()});
                    this.listViewAPK.Items.Add(item);
                }
            }
            catch (Exception e) {

            }

        }

        public void InstallApk() {
            ShowMsg("APK installing......");
            Cursor.Current = Cursors.WaitCursor;
            if (AdbHelper.InstallApk(this.txtUSB_Serial.Text,this.lb_apk.Text))
            {
                ShowMsg("APK was Installed");
            }
            else
            {
                ShowMsg("ERROR : APK was not Installed");
            }
        }

       

        #endregion

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!ReadCfgFile())
            {
                ShowMsg("Configuration Infomation ERROR");
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ModiftySetting();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ApplySetting();
        }

        //USB connection refresh button
        private void button1_Click(object sender, EventArgs e)
        {
            GetUSBInfoList();
        }
        // USB list change event

        private void listViewUSB_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var deviceNo = Convert.ToString(e.Item.SubItems[1].Text);
            this.txtUSB_Serial.Text = deviceNo.ToString();
            this.txtUSB_INFO.Text = string.Format("{0} {1} {2} ({3})"
                , AdbHelper.GetDeviceBrand(deviceNo)
                , AdbHelper.GetDeviceModel(deviceNo)
                , AdbHelper.GetDeviceVersionRelease(deviceNo)
                , AdbHelper.GetDeviceVersionSdk(deviceNo));
        }

        private void btnClearSelectedUSB_Click(object sender, EventArgs e)
        {
            this.txtUSB_INFO.Clear();
            this.txtUSB_Serial.Clear();
            this.cb_USB.CheckState = CheckState.Unchecked;
        }

        private void btnSelectUSB_Click(object sender, EventArgs e)
        {
            if (this.txtUSB_INFO.Text != "" && this.txtUSB_Serial.Text != "")
            {
                this.cb_USB.CheckState = CheckState.Checked;
                String strShow = this.txtUSB_INFO.Text + " was selected";
                this.txtShowTDI.Text = this.txtUSB_INFO.Text;
                ShowMsg(strShow);
            }
            else
            {
                ShowMsg("select a device please");
            }

        }
        /// <summary>
        /// wifi connection button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWifiConncetion_Click(object sender, EventArgs e)
        {
            WIFI_CON();
        }
        /// <summary>
        /// wifi disconnecition button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWifiDis_Click(object sender, EventArgs e)
        {
            WIFI_DIS();
        }

        private void cb_conifg_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.cb_conifg.Checked)
            {
                this.lb_config.ForeColor = Color.Green;
                this.lb_config.Text = "O";
            }
            else
            {
                this.lb_config.ForeColor = Color.Red;
                this.lb_config.Text = "X";
            }
        }

        private void cb_USB_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.cb_USB.Checked)
            {
                this.lb_usb.ForeColor = Color.Green;
                this.lb_usb.Text = "O";
            }
            else
            {
                this.lb_usb.ForeColor = Color.Red;
                this.lb_usb.Text = "X";
            }
        }

        private void cb_WIFI_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.cb_WIFI.Checked)
            {
                this.lb_wifi.ForeColor = Color.Green;
                this.lb_wifi.Text = "O";
            }
            else
            {
                this.lb_wifi.ForeColor = Color.Red;
                this.lb_wifi.Text = "X";
            }
        }
        /// <summary>
        /// call DDMS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallDDMS_Click(object sender, EventArgs e)
        {
            CallDDMS();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetAPKlist();
        }

        private void listViewAPK_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.lb_apk.Text = e.Item.SubItems[0].Text;
        }

        /// <summary>
        /// install button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            InstallApk();
        }
    }
}
