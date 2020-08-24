﻿using AutoTool.AutoCommons;
using AutoTool.Constants;
using AutoTool.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace AutoTool.AutoMethods
{
    public class LDPlayerFunc : IEmulatorFunc
    {
        public List<EmulatorInfo> GetDevices()
        {
            List<EmulatorInfo> devices = new List<EmulatorInfo>();
            string output = CmdFunc.RunCMD(LDPlayerConsts.LIST_DEVICES);
            if (output != null)
            {
                var matchs = Regex.Matches(output, @"^(\d+),(.+),[0-9\-]+,[0-9\-]+,(\d+),[0-9\-]+,[0-9\-]+", RegexOptions.Multiline);
                int index = 1;
                foreach (Match match in matchs)
                {
                    var id = match.Groups[1].ToString();
                    var name = match.Groups[2].ToString();
                    int status = -1;
                    int.TryParse(match.Groups[3].ToString(), out status);
                    devices.Add(new EmulatorInfo(id, name)
                    {
                        Status = (DeviceStatus)status,
                        Index = index++
                    });
                }
            }
            return devices;
        }

        public string GetSerialNo(EmulatorInfo device)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.GET_SERIAL_NO, device.Id));
            if (string.IsNullOrEmpty(output))
            {
                return null;
            }
            return output.Trim();
        }

        public bool ClearAppData(EmulatorInfo device, string appPackage)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.CLEAR_APP_DATA, device.Id, appPackage));
            return output != null;
        }

        public bool CloneDevice(EmulatorInfo sourceDevice, string newDeviceName)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.CLONE_DEVICE, newDeviceName, sourceDevice.Id));
            return output != null;
        }

        public bool Input(EmulatorInfo device, string text)
        {
            text = _standardizeText(text);

            // get serial no
            var serialno = GetSerialNo(device);

            if (!string.IsNullOrEmpty(serialno))
            {
                var output = CmdFunc.RunCMD(string.Format(AdbConstants.INPUT, serialno, text));
                return output != null;
            }
            else
            {
                var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.INPUT, device.Id, text));
                return output != null;
            }
        }

        private string _standardizeText(string text)
        {
            return text.Replace(" ", "%s").Replace("&", "\\&").Replace("<", "\\<")
                .Replace(">", "\\>")
                .Replace("?", "\\?")
                .Replace(":", "\\:")
                .Replace("{", "\\{")
                .Replace("}", "\\}")
                .Replace("[", "\\[")
                .Replace("]", "\\]")
                .Replace("|", "\\|");
        }

        public bool Input(EmulatorInfo device, char[] text)
        {
            // get serial no
            var serialno = CmdFunc.RunCMD(string.Format(LDPlayerConsts.GET_SERIAL_NO, device.Id));

            if (!string.IsNullOrEmpty(serialno))
            {
                for (var i = 0; i < text.Length; i++)
                {
                    var t = _standardizeText(text[i].ToString());
                    CmdFunc.RunCMD(string.Format(AdbConstants.INPUT, serialno, t));
                }
            }
            else
            {
                for (var i = 0; i < text.Length; i++)
                {
                    var t = _standardizeText(text[i].ToString());
                    CmdFunc.RunCMD(string.Format(LDPlayerConsts.INPUT, device.Id, t));
                }
            }
            return true;
        }

        public bool LongPress(EmulatorInfo device, int x, int y, int duration = 1000)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.SWIPE_LONG, device.Id, x, y, x, y, duration));
            return output != null;
        }

        public bool LongPress(EmulatorInfo device, Point point, int duration = 1000)
        {
            return LongPress(device, point.X, point.Y, duration);
        }

        public bool RemoveDevice(EmulatorInfo device)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.REMOVE_DEVICE, device.Id));
            return output != null;
        }

        public bool RenameDevice(EmulatorInfo device, string deviceName)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.RENAME_DEVICE, device.Id, deviceName));
            return output != null;
        }

        public bool RestoreDevice(string source)
        {
            // list new device
            var newDevices = _addNewDevice();
            foreach(var device in newDevices)
            {
                var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.RESTORE_DEVICE, device.Id, source));
            }
            return true;
        }

        private List<EmulatorInfo> _addNewDevice()
        {
            var listBefore = GetDevices();
            var outputAdd = CmdFunc.RunCMD(LDPlayerConsts.ADD_DEVICE);
            var listAfter = GetDevices();
            return listAfter.FindAll(aemu =>
            {
                return !listBefore.Exists(bemu => bemu.Id.Equals(aemu.Id));
            });
        }

        public bool ScreenShot(EmulatorInfo device, string destination)
        {
            var tempScreenshot = string.Format("/sdcard/{0}.png", DateTime.Now.Ticks);
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.SCREEN_SHOT, device.Id, tempScreenshot, destination));
            return output != null;
        }

        public bool SendKey(EmulatorInfo device, AdbKeyEvent keyEvent)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.KEY_EVENT, device.Id, (int)keyEvent));
            return output != null;
        }

        public bool StartApp(EmulatorInfo device, string appPackage)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.START_APP, device.Id, appPackage));
            return output != null;
        }

        public bool StartDevice(EmulatorInfo device)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.START_DEVICE, device.Id));
            if (output == null) return false;

            // check android on
            var androidIsOn = new WaitHelper<EmulatorInfo>(device, TimeSpan.FromSeconds(60)).Until(dev => {
                return IsRunning(dev);
            });

            return androidIsOn;
        }

        public bool StopApp(EmulatorInfo device, string appPackage)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.STOP_APP, device.Id, appPackage));
            return output != null;
        }

        public bool StopDevice(EmulatorInfo device)
        {
            if (device == null)
            {
                var output = CmdFunc.RunCMD(LDPlayerConsts.STOP_ALL_DEVICES);
                return output != null;
            }
            else
            {
                var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.STOP_DEVICE, device.Id));
                return output != null;
            }
        }

        public bool IsRunning(EmulatorInfo device)
        {
            var devices = GetDevices();
            // find device by Id and Status
            EmulatorInfo found = devices.FirstOrDefault(d => d.Id.Equals(device.Id) && d.Status == DeviceStatus.RUNNING);
            return found != null;
        }

        public bool Swipe(EmulatorInfo device, Point from, Point to)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.SWIPE, device.Id, from.X, from.Y, to.X, to.Y));
            return output != null;
        }

        public bool SwipeLong(EmulatorInfo device, Point from, Point to, int duration = 1000)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.SWIPE_LONG, device.Id, from.X, from.Y, to.X, to.Y, duration));
            return output != null;
        }

        public bool Tap(EmulatorInfo device, double x, double y)
        {
            var output = CmdFunc.RunCMD(string.Format(LDPlayerConsts.TAP, device.Id, x, y));
            return output != null;
        }

        public bool Tap(EmulatorInfo device, Point point)
        {
            return Tap(device, point.X, point.Y);
        }
    }
}