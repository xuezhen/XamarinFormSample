using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Service
{
    public interface IPlatformService
    {
        /// <summary>
        /// 得到当前app版本号
        /// </summary>
        /// <returns></returns>
        String GetVersion();
    }
}
