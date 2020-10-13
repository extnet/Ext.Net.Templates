using System;
using System.Collections.Generic;

namespace Company.WebApplication.Data
{
    public static class NavData
    {
        public static List<NavItem> Items = new List<NavItem>
        { 
            new NavItem("Dashboard", "/", "dashboard"),
            new NavItem("DirectEvents", "/directevents/", "flash-on"),
            new NavItem("GridPanel", "/gridpanel/", "grid-on")
        };
    }

    public class NavItem
    {
        public NavItem (string name, string path, string iconCls)
        {
            Name = name;
            Path = path;
            IconCls = iconCls;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string IconCls { get; set; }
    }
}
