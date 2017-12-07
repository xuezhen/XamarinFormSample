using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Sample.Service;

namespace Sample.iOS.Service
{
    public class IOSPlatformService : IPlatformService
    {
        /// <summary>
        /// 得到App当前版本号
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            string version = Foundation.NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
            return version;
        }
    }
}