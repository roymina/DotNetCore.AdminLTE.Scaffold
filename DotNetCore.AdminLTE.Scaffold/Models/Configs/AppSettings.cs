using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.AdminLTE.Scaffold.Models.Configs
{
    public class AppSettings
    {
        public string BaseUrl { get; set; }
        public string ApplicationName { get; set; }
        public string ShortName { get; set; }
        public string Version { get; set; }
        public string Enviroment { get; set; }
    }
}
