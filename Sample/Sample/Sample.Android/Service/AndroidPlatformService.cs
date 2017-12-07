using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Sample.Service;

namespace Sample.Droid.Service
{
    public class AndroidPlatformService : IPlatformService
    {
        /// <summary>
        /// 得到App版本号
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            return Android.App.Application.Context.PackageManager.GetPackageInfo(Android.App.Application.Context.PackageName, 0).VersionName;
        }
    }
}