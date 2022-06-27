using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo2022summer
{
    public partial class App : Application
    {
        public static DemosummerEntities bd = new DemosummerEntities();
        public static string login;
        public static string fio;
        public static Tickets tickets;

    }
}
