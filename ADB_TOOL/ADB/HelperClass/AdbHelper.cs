using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using log4net;
using System.Diagnostics;
namespace ADB_TOOL
{
    /// <summary>
    /// Android Debug Bridge | Android Developers
    /// http://developer.android.com/tools/help/adb.html
    /// </summary>
    public class AdbHelper
    {

        static ILog m_log = LogManager.GetLogger(typeof(AdbHelper));

        /// <summary>
        /// adb.exe文件的路径，默认相对于当前应用程序目录取。
        /// </summary>
        public static string AdbExePath
        {
            get
            {
                return Path.Combine(Application.StartupPath, "AdbBin\\adb.exe");
            }
        }

        /// <summary>
        /// 当前ADB状态：
        /// adb get-state                - prints: offline | bootloader | device | unknown
        /// </summary>
        public enum AdbState
        {
            Offline, Bootloader, Device, Unknown, Error
        }

        /// <summary>
        /// 获取设备状态；多态设备时，获取的状态始终为unknwon
        /// adb get-state                - prints: offline | bootloader | device | unknown
        /// </summary>
        public static AdbState GetState()
        {
            //获取设备名称
            var result = ProcessHelper.Run(AdbExePath, "get-state");

            System.Diagnostics.Debug.WriteLine(result.ToString());

            if (result.Success)
            {
                switch (result.OutputString.Trim())
                {
                    case "offline":
                        return AdbState.Offline;
                    case "bootloader":
                        return AdbState.Bootloader;
                    case "device":
                        return AdbState.Device;
                    case "unknown":
                        return AdbState.Unknown;
                }
            }
            return AdbState.Error;
        }

        /// <summary>
        /// 启动ADB服务
        /// </summary>
        /// <returns></returns>
        public static bool StartServer()
        {
            return ProcessHelper.Run(AdbExePath, "start-server").Success;
        }

        /// <summary>
        /// 多态设备时，获取的状态始终为unknwon
        /// </summary>
        /// <returns></returns>
        public static string GetSerialNo()
        {
            return ProcessHelper.Run(AdbExePath, "get-serialno").OutputString.Trim();
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetDevices()
        {
            var result = ProcessHelper.Run(AdbExePath, "devices");

            var itemsString = result.OutputString;
            var items = itemsString.Split(new[] { "$", "#", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var itemsList = new List<String>();
            foreach (var item in items)
            {
                var tmp = item.Trim();

                //第一行不含\t所以排除
                if (tmp.IndexOf("\t") == -1)
                    continue;
                var tmps = item.Split('\t');
                itemsList.Add(tmps[0]);
            }

            itemsList.Sort();

            return itemsList.ToArray();
        }

        /// <summary>
        /// 列举ls /data/data目录下的文件和目录
        /// </summary>
        /// <returns></returns>
        public static List<string> ListDataFolder(string deviceNo)
        {
            var moreArgs = new[] { "su", "ls /data/data", "exit", "exit" };
            var result = ProcessHelper.RunAsContinueMode(AdbExePath, string.Format("-s {0} shell", deviceNo), moreArgs);

            var itemsString = result.MoreOutputString[1];
            var items = itemsString.Split(new[] { "$", "#", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var itemsList = new List<String>();
            foreach (var item in items)
            {
                var tmp = item.Trim();
                //移除第一行，输入的命令
                if (tmp.Contains(moreArgs[1]))
                    continue;
                //移除空白行
                if (string.IsNullOrEmpty(tmp))
                    continue;
                //移除最后两行的root@android
                if (tmp.ToLower().Contains("root@"))
                    continue;
                itemsList.Add(tmp);
            }

            itemsList.Sort();

            return itemsList;
        }

        /// <summary>
        /// 获取指定的目录
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string>  ListDataFolder(string deviceNo, string path)
        {
            var moreArgs = new[] { "su", "ls " + path, "exit", "exit" };
            var result = ProcessHelper.RunAsContinueMode(AdbExePath, string.Format("-s {0} shell", deviceNo), moreArgs);

            m_log.Info("获取路径结果：" + result.ToString());

            var itemsString = result.MoreOutputString[1];
            var items = itemsString.Split(new[] { "$", "#", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var itemsList = new List<String>();
            foreach (var item in items)
            {
                var tmp = item.Trim();
                //移除第一行，输入的命令
                if (tmp.Contains(moreArgs[1]))
                    continue;
                //若有Permission denied证明没有该路径，直接退出
                if (tmp.Contains(path + ": Permission denied"))
                    break;
                //移除空白行
                if (string.IsNullOrEmpty(tmp))
                    continue;
                //移除最后两行的root@android
                if (tmp.ToLower().Contains("root@") || tmp.ToLower().Contains("shell@"))
                    continue;
                if (tmp.Equals("su") || tmp.Contains("su: not found"))//移除su
                    continue;
                itemsList.Add(path + "/" + tmp);
            }

            itemsList.Sort();

            return itemsList;
        }


        /// <summary>
        /// 指定“包名”后，就将其目录下的数据库文件遍历出来。
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="packageName"></param>
        /// <returns></returns>
        public static List<string> ListDatabasesFolder(string deviceNo, string packageName)
        {
            var path = string.Format("ls /data/data/{0}/databases", packageName);

            var moreArgs = new[] { "su", path, "exit", "exit" };
            var result = ProcessHelper.RunAsContinueMode(AdbExePath, string.Format("-s {0} shell", deviceNo), moreArgs);

            var itemsString = result.MoreOutputString[1];
            var items = itemsString.Split(new[] { "$", "#", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var itemsList = new List<String>();
            foreach (var item in items)
            {
                var tmp = item.Trim();
                //移除第一行，输入的命令
                if (tmp.Contains(moreArgs[1]))
                    continue;
                //移除空白行
                if (string.IsNullOrEmpty(tmp))
                    continue;
                //移除最后两行的root@android
                if (tmp.ToLower().Contains("root@"))
                    continue;
                itemsList.Add(tmp);
            }

            itemsList.Sort();

            return itemsList;
        }

        /// <summary>
        /// 拷贝文件到PC上
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="devPath"></param>
        /// <param name="pcPath"></param>
        /// <returns></returns>
        public static bool CopyFromDevice(string deviceNo, string devPath, string pcPath)
        {
            //使用Pull命令将数据库拷贝到Pc上
            //adb pull [-p] [-a] <remote> [<local>]
            var result = ProcessHelper.Run(AdbExePath, string.Format("-s {0} pull {1} {2}", deviceNo, devPath, pcPath));
            m_log.Info("推送PC时结果：" + result.ToString());
            if (!result.Success
                || result.ExitCode != 0
                || (result.OutputString != null && result.OutputString.Contains("failed")))
            {
                return false;
                throw new Exception("pull 执行返回的结果异常：" + result.OutputString);
            }
            return true;
        }

        /// <summary>
        /// 将文件拷贝到设备上（不适用于文件夹）
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="pcPath"></param>
        /// <param name="devPath"></param>
        /// <returns></returns>
        public static bool CopyToDevice(string deviceNo, string pcPath, string devPath)
        {
            //adb push [-p] <local> <remote> 
            //- copy file/dir to device
            var result = ProcessHelper.Run(AdbExePath, string.Format("-s {0} push {1} {2}", deviceNo, pcPath, devPath));
            m_log.Info("推送PAD时结果：" + result.ToString());

            if (result.ExitCode != 0
                || (result.OutputString.Contains("failed")
                && result.OutputString.Contains("No such file or directory")))//若出现设备文件夹不存在的情况，则创建该文件夹
            {
                //构建拷贝后设备路径
                int index1 = result.OutputString.IndexOf("failed to copy ");
                //输出字符串：" failed to copy 'F:\padData\image\1.jpg' to 'sdcard/21at/output/image/1.jpg': No such file or directory"
                string temp = result.OutputString.Substring(index1);
                int index2 = temp.IndexOf(devPath);
                int index3 = temp.IndexOf("': No such file or directory");
                string devPath2 = temp.Substring(index2, index3 - index2);//设备图片路径
                devPath2 = devPath2.Substring(0, devPath2.LastIndexOf('/'));
                var moreArgs = new[] { "su", "mkdir -p "+ devPath2, "exit", "exit" };
                //shell 方式创建文件夹
                result = ProcessHelper.RunAsContinueMode(AdbExePath, string.Format("-s {0} shell", deviceNo), moreArgs);
                m_log.Info("创建文件夹：" + devPath2);
                m_log.Info("创建文件夹结果：" + result.ToString());
                //再次推送该文件
                result = ProcessHelper.Run(AdbExePath, string.Format("-s {0} push {1} {2}", deviceNo, pcPath, devPath));
                m_log.Info("再次推送PAD结果：" + result.ToString());
            }
            if (!result.Success
                || result.ExitCode != 0
                || (result.OutputString != null && result.OutputString.Contains("failed")))
            {
                return false;
                throw new Exception("push 执行返回的结果异常：" + result.OutputString);
            }

            return true;
        }
        /// <summary>
        /// MakeWifiConn
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="IP"></param>
        /// <param name="portNo"></param>
        /// <returns></returns>
        public static bool MakeWifiConn(string deviceNo, string IP,string portNo) {
            try
            {
                string strCmd = "tcpip " + portNo;
                var result = ProcessHelper.Run(AdbExePath, strCmd);
                if (!result.Success
                    || result.ExitCode != 0
                    || (result.OutputString != null && result.OutputString.Contains("error")))
                {
                    return false;
                    throw new Exception("push 执行返回的结果异常：" + result.OutputString);
                }

                strCmd = "connect " + IP + ":" + portNo;
                result = ProcessHelper.Run(AdbExePath, strCmd);
                if (!result.Success
                    || result.ExitCode != 0
                    || (result.OutputString != null && result.OutputString.Contains("unable")))
                {
                    return false;
                    throw new Exception("push 执行返回的结果异常：" + result.OutputString);
                }

            }
            catch (Exception e) {
                return false;
            }
            return true;
        }
        /// <summary>
        /// KillWifiConn
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="IP"></param>
        /// <param name="portNo"></param>
        /// <returns></returns>
        public static bool KillWifiConn(string deviceNo, string IP, string portNo)
        {
            try
            {
                string strCmd = "disconnect";
                var result = ProcessHelper.Run(AdbExePath, strCmd);
                if (!result.Success
                    || result.ExitCode != 0
                    || (result.OutputString != null && result.OutputString.Contains("error")))
                {
                    return false;
                    throw new Exception("push 执行返回的结果异常：" + result.OutputString);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// kill adb service
        /// </summary>
        public static void KillServer() {
            var result = ProcessHelper.Run(AdbExePath, "kill-server");
        }

        /// <summary>
        /// install apk
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="apkFile"></param>
        /// <returns>install result</returns>
        public static bool InstallApk(string deviceNo,string apkFile) {
            try
            {
                string strCmd = "install "+ apkFile;
                var result = ProcessHelper.Run(AdbExePath, strCmd);
                if ( (!result.OutputString.Contains("Success")))
                {
                    Debug.WriteLine("install failed");
                    return false;
                    //throw new Exception("push 执行返回的结果异常：" + result.OutputString);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("install failed!!!!");
                return false;
            }


            return true;
        }


        #region 获取设备相关信息
        /// <summary>
        /// -s 0123456789ABCDEF shell getprop ro.product.brand
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <param name="propKey"></param>
        /// <returns></returns>
        public static string GetDeviceProp(string deviceNo, string propKey)
        {
            var result = ProcessHelper.Run(AdbExePath, string.Format("-s {0} shell getprop {1}", deviceNo, propKey));
            return result.OutputString.Trim();
        }
        /// <summary>
        /// 型号：[ro.product.model]: [Titan-6575]
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <returns></returns>
        public static string GetDeviceModel(string deviceNo)
        {
            return GetDeviceProp(deviceNo, "ro.product.model");
        }
        /// <summary>
        /// 牌子：[ro.product.brand]: [Huawei]
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <returns></returns>
        public static string GetDeviceBrand(string deviceNo)
        {
            return GetDeviceProp(deviceNo, "ro.product.brand");
        }
        /// <summary>
        /// 设备指纹：[ro.build.fingerprint]: [Huawei/U8860/hwu8860:2.3.6/HuaweiU8860/CHNC00B876:user/ota-rel-keys,release-keys]
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <returns></returns>
        public static string GetDeviceFingerprint(string deviceNo)
        {
            return GetDeviceProp(deviceNo, "ro.build.fingerprint");
        }
        /// <summary>
        /// 系统版本：[ro.build.version.release]: [4.1.2]
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <returns></returns>
        public static string GetDeviceVersionRelease(string deviceNo)
        {
            return GetDeviceProp(deviceNo, "ro.build.version.release");
        }
        /// <summary>
        /// SDK版本：[ro.build.version.sdk]: [16]
        /// </summary>
        /// <param name="deviceNo"></param>
        /// <returns></returns>
        public static string GetDeviceVersionSdk(string deviceNo)
        {
            return GetDeviceProp(deviceNo, "ro.build.version.sdk");
        }
        #endregion
    }
}
