﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using ArkController.Data;
using ArkController.Kit;

namespace ArkController.Task
{
    /// <summary>
    /// 通信任务线程
    /// </summary>
    public class ConnectTaskThread : BaseTaskThread
    {
        private static ConnectTaskThread instance = null;

        private Log log = null;
        private AdbConnect connect = null;
        private DeviceManager manager = null;

        /// <summary>
        /// 单例模式
        /// </summary>
        /// <returns></returns>
        public static ConnectTaskThread GetInstance()
        {
            if (instance == null)
            {
                instance = new ConnectTaskThread();
            }
            return instance;
        }

        private ConnectTaskThread()
        {
            connect = new AdbConnect();
            manager = new DeviceManager(connect);
        }

        /// <summary>
        /// 显示的log
        /// </summary>
        public Log Log
        {
            set
            {
                this.log = value;
                this.connect.Log = value;
            }
        }

        /// <summary>
        /// 具体实现任务队列
        /// </summary>
        /// <param name="task"></param>
        public override void handleTask(TaskInfo task)
        {
            switch (task.What)
            {
                case TaskType.ExecuteCommand:
                    handleExecuteCommand(task);
                    break;
                case TaskType.SendKey:
                    handleInputKey((int)task.Data);
                    break;
                case TaskType.DeviceList:
                    handleDeviceList(task);
                    break;
                case TaskType.PackageList:
                    handlePackageList(task);
                    break;
                case TaskType.ProcessList:
                    handleProcessList(task);
                    break;
                case TaskType.DumpHeap:
                    handleDumpHeap(task);
                    break;
                case TaskType.CurrentDeviceInfo:
                    handleCurrentDeviceInfo(task);
                    break;
                case TaskType.BatteryInfo:
                    handleBatteryInfo(task);
                    break;
                case TaskType.StartAM:
                    handleStartAm(task);
                    break;
                case TaskType.StartAction:
                    handleStartAction(task);
                    break;
                case TaskType.Install:
                    handleInstall(task);
                    break;
                case TaskType.Unintall:
                    handleUninstall(task);
                    break;
                case TaskType.InputText:
                    handleInputText(task);
                    break;
                case TaskType.ScreenRecord:
                    handleScreenRecord(task);
                    break;
                case TaskType.ScreenShot:
                    handleScreenShot(task);
                    break;
                case TaskType.ScreenSizeDensity:
                    handleScreenSizeDensity(task);
                    break;
                case TaskType.PullFile:
                    handlePullFile(task);
                    break;
                case TaskType.PushFile:
                    handlePushFile(task);
                    break;
            }
        }

        /// <summary>
        /// 写入log
        /// </summary>
        /// <param name="log"></param>
        private void writeLog(string content)
        {
            if (log != null)
            {
                log.Write(content);
            }
        }

        /// <summary>
        /// 执行命令，返回结果
        /// </summary>
        /// <param name="task"></param>
        private void handleExecuteCommand(TaskInfo task)
        {
            if (task.Data != null)
            {
                string result = connect.ExecuteAdb(task.Data.ToString(), task.Args == 1 ? false : true);
                if (task.ResultHandler != null)
                {
                    task.ResultHandler.Invoke(result, task.Tag);
                }
                writeLog(string.Format("执行命令：{0}", task.Data));
            }
            else if (task.DataArray != null)
            {
                foreach (string cmd in task.DataArray)
                {
                    string result = connect.ExecuteAdb(cmd, task.Args == 1 ? false : true);
                    writeLog(string.Format("执行命令：{0}\n{1}", cmd, result));
                }
            }
        }

        /// <summary>
        /// 发送按键
        /// </summary>
        /// <param name="keyCode"></param>
        private void handleInputKey(int keyCode)
        {
            bool result = connect.InputKey(keyCode);
            writeLog(string.Format("发送按键{0}{1}", keyCode, result ? "成功" : "失败"));
        }

        /// <summary>
        /// 设备列表
        /// </summary>
        private void handleDeviceList(TaskInfo task)
        {
            string[] devices = manager.DeviceLink.DeviceList();
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(devices);
            }
            writeLog(string.Format("设备列表：{0}", string.Join(",", devices, 0, devices.Length)));
        }

        /// <summary>
        /// 包名列表
        /// </summary>
        /// <param name="task"></param>
        private void handlePackageList(TaskInfo task)
        {
            string[] packages = connect.GetPackageList(task.Data.ToString());
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(packages);
            }
            writeLog(string.Format("获取安装包名{0}个", packages.Length));
        }

        /// <summary>
        /// 进程列表
        /// </summary>
        /// <param name="task"></param>
        private void handleProcessList(TaskInfo task)
        {
            List<ProcessData.Data> processList = manager.Process.GetCurrentProcessList();
            if (task.ResultHandler != null)
            {

                task.ResultHandler.Invoke(processList);
            }
            writeLog(string.Format("获取进程列表{0}个", processList.Count));
        }

        /// <summary>
        /// 获取内存镜像
        /// </summary>
        /// <param name="task"></param>
        private void handleDumpHeap(TaskInfo task)
        {
            if (task.DataArray.Length < 2)
            {
                return;
            }
            string processName = task.DataArray[0].ToString();
            string path = task.DataArray[1].ToString();
            string heap_cmd = string.Format("shell am dumpheap {0} /data/local/tmp/{1}.hprof", processName, processName);
            string pull_cmd = string.Format("pull /data/local/tmp/{0}.hprof {1}", processName, Path.Combine(path, processName));
            string remove_cmd = string.Format("shell rm /data/local/tmp/{0}.hprof", processName);

            string heap_log = connect.ExecuteAdb(heap_cmd);
            writeLog("获取内存镜像：" + heap_log);
            string pull_log = connect.ExecuteAdb(pull_cmd);
            writeLog("获取文件:" + pull_log);
            connect.ExecuteAdb(remove_cmd);
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(Path.Combine(path, processName));
            }
        }

        /// <summary>
        /// 获取当前设备列表
        /// </summary>
        /// <param name="task"></param>
        private void handleCurrentDeviceInfo(TaskInfo task)
        {
            this.connect.SetDeviceSerial(task.Data.ToString());
            string[] values = manager.DeviceLink.GetCurrentDeviceInfo();
            if (values != null)
            {
                if (task.ResultHandler != null)
                {
                    task.ResultHandler.Invoke(values);
                }
                writeLog(string.Format("获取到设备信息:{0}", string.Join(",", values, 0, values.Length)));
            }
        }

        /// <summary>
        /// 获取电池信息
        /// </summary>
        /// <param name="task"></param>
        private void handleBatteryInfo(TaskInfo task)
        {
            string cmd = "shell dumpsys battery";
            string result = connect.ExecuteAdb(cmd);
            if (!String.IsNullOrEmpty(result) && !result.Contains("daemon started successfully "))
            {
                manager.BatteryParser = BatteryParser.Parser(result);
                if (task.ResultHandler != null)
                {
                    Image image = manager.BatteryParser.BatteryImage;
                    string info = manager.BatteryParser.BatteryFormatInfo;
                    task.ResultHandler.Invoke(image, info);
                }
                writeLog(string.Format("获取到电池信息"));
            }
        }

        /// <summary>
        /// 启动一个action
        /// </summary>
        /// <param name="task"></param>
        private void handleStartAm(TaskInfo task)
        {
            if (task.Data != null)
            {
                string action = (string)task.Data;
                connect.StartAm(action);
                writeLog(string.Format("启动{0}", action));
            }
            else if (task.DataArray != null)
            {
                string[] actions = (string[])task.DataArray;
                connect.StartAm(actions[0], actions[1]);
                writeLog(string.Format("启动{0}/{1}", actions[0], actions[1]));
            }
        }

        /// <summary>
        /// 启动action
        /// </summary>
        /// <param name="task"></param>
        private void handleStartAction(TaskInfo task)
        {
            if (task.Data != null)
            {
                string action = (string)task.Data;
                connect.StartAmAction(action);
                writeLog(string.Format("启动{0}", action));
            }
        }

        /// <summary>
        /// 安装程序
        /// </summary>
        /// <param name="task"></param>
        private void handleInstall(TaskInfo task)
        {
            string path = (string)task.Data;
            writeLog(string.Format("开始安装{0}", path));
            bool result = connect.Install(path);
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(new string[] { result.ToString(), path });
            }
            writeLog(string.Format("安装{0}{1}", path, result ? "成功" : "失败"));
        }

        /// <summary>
        /// 卸载程序
        /// </summary>
        /// <param name="task"></param>
        private void handleUninstall(TaskInfo task)
        {
            string packageName = (string)task.Data;
            connect.Uninstall(packageName);
        }

        /// <summary>
        /// 输入文本
        /// </summary>
        /// <param name="task"></param>
        private void handleInputText(TaskInfo task)
        {
            string text = (string)task.Data;
            connect.InputText(text);
            writeLog(string.Format("输入文本：{0}", text));
        }

        /// <summary>
        /// 屏幕截图
        /// </summary>
        /// <param name="task"></param>
        private void handleScreenShot(TaskInfo task)
        {
            string path = task.Data.ToString();
            Image result = connect.GetScreenShot(path);
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(result);
            }
            writeLog(string.Format("获取屏幕截图{0}", result != null? "成功" : "失败"));
        }

        /// <summary>
        /// 录制屏幕
        /// </summary>
        /// <param name="task"></param>
        private void handleScreenRecord(TaskInfo task)
        {
            string tempFilename = "/sdcard/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".mp4";
            string cmd_record = "shell screenrecord";
            if (!string.IsNullOrEmpty(task.DataArray[0].ToString()))
            {
                cmd_record = cmd_record + " --size " + task.DataArray[0];
            }
            if (!string.IsNullOrEmpty(task.DataArray[1].ToString()))
            {
                cmd_record = cmd_record + " --time-limit " + task.DataArray[1];
            }
            cmd_record = cmd_record + " --verbose " + tempFilename;
            string cmd_pull = string.Format("pull {0} {1}", tempFilename, task.Data);
            string cmd_delete = string.Format("shell rm ", tempFilename);
            writeLog(string.Format("开始录制屏幕,分辨率{0},时长{1}秒...", task.DataArray[0], task.DataArray[1]));
            string record_log = connect.ExecuteAdb(cmd_record);
            writeLog(record_log);
            writeLog("录制完成，开始导出文件");
            string pull_log = connect.ExecuteAdb(cmd_pull);
            writeLog("导出完成：" + tempFilename);
            connect.ExecuteAdb(cmd_delete);
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(record_log, pull_log);
            }
        }

        /// <summary>
        /// 屏幕尺寸和像素密度
        /// </summary>
        /// <param name="task"></param>
        private void handleScreenSizeDensity(TaskInfo task)
        {
            ScreenData.Action action = (ScreenData.Action)Enum.Parse(typeof(ScreenData.Action), (string)task.DataArray[0]);
            object result = null;
            switch (action)
            {
                case ScreenData.Action.GetDensity:
                    int density = manager.ScreenData.GetScreenDensity();
                    result = density;
                    writeLog(string.Format("获取屏幕像素密度：{0}", density));
                    break;
                case ScreenData.Action.GetSize:
                    // 获取屏幕像素密度和分辨率
                    Size size = manager.ScreenData.GetScreenSize();
                    result = size;
                    writeLog(string.Format("获取屏幕分辨率：{0}", size.ToString()));
                    break;
                case ScreenData.Action.SetDensity:
                    int setdensity = (int)task.DataArray[1];
                    bool r = manager.ScreenData.SetScreenDensity(setdensity);
                    result = r;
                    writeLog(string.Format("设置屏幕像素密度{0}{1}", setdensity, r ? "成功" : "失败"));
                    break;
                case ScreenData.Action.SetSize:
                    int width = (int)task.DataArray[1];
                    int height = (int)task.DataArray[2];
                    bool setSizeResult = manager.ScreenData.SetScreenSize(width, height);
                    result = setSizeResult;
                    writeLog(string.Format("设置屏幕分辨率{0}x{1}{2}", width, height, setSizeResult ? "成功" : "失败"));
                    break;
                case ScreenData.Action.ResetSize:
                    bool resetSizeResult = manager.ScreenData.ResetScreenSize();
                    result = resetSizeResult;
                    writeLog(string.Format("重置屏幕分辨率{0}", resetSizeResult ? "成功" : "失败"));
                    break;
                case ScreenData.Action.ResetDensity:
                    bool resetDensityResult = manager.ScreenData.ResetScreenDensity();
                    result = resetDensityResult;
                    writeLog(string.Format("重置屏幕像素密度{0}", resetDensityResult ? "成功" : "失败"));
                    break;
            }
            if (result != null)
            {
                task.ResultHandler.Invoke(result);
            }
        }

        /// <summary>
        /// 从设备端导出文件
        /// </summary>
        /// <param name="task"></param>
        private void handlePullFile(TaskInfo task)
        {
            if (task.DataArray == null || task.DataArray.Length < 2)
            {
                return;
            }
            string appPath = (string)task.DataArray[0];
            string localPath = (string)task.DataArray[1];
            string cmd = Package.GetPullAppInstallApkCommand(appPath, localPath);
            string log = connect.ExecuteAdb(cmd);
            writeLog(string.Format("Pull路径:\"{0}\"到\"{1}\"完成", appPath, localPath));
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(log);
            }
        }

        /// <summary>
        /// 推送文件到设备上
        /// </summary>
        /// <param name="task"></param>
        private void handlePushFile(TaskInfo task)
        {
            if (task.DataArray == null || task.DataArray.Length < 2)
            {
                return;
            }
            string localPath = (string)task.DataArray[0];
            string devicePath = (string)task.DataArray[1];
            string cmd = Package.GetPushFileCommand(devicePath, localPath);
            string log = connect.ExecuteAdb(cmd);
            writeLog(string.Format("Push路径:\"{0}\"到\"{1}\"完成", localPath, devicePath));
            if (task.ResultHandler != null)
            {
                task.ResultHandler.Invoke(log);
            }
        }

    }
}
