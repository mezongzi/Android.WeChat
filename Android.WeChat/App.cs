using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android.WeChat
{
    public static class App
    {
        public static string HostUrl = ConfigurationSettings.AppSettings["AuthUrl"].ToString();
    }
}
