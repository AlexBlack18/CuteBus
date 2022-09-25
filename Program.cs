using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteBus
{
    internal static class Program
    {
        public static Auth auth_form;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Home home;
        public static MessageRemove f1;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hello());
        }
    }
}
