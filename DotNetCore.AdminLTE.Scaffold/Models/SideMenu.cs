using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.AdminLTE.Scaffold.Models
{
    public class MenuConfiguration
    {
        public List<MainNode> MenuItems { get; set; }
    }
    public class   MainNode
    {
        public string Icon { get; set; } = "fa fa-dashboard";
        public string Text { get; set; } = "Main";
        public List<ChildNode> ChildNodes { get; set; } = new List<ChildNode>();
    }
    public class ChildNode
    {
        public string NavTo { get; set; } = "#";
        public string Icon { get; set; } = "fa fa-circle-o";
        public string Text { get; set; } = "Sub";
    }
}
