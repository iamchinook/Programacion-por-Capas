using System;
using System.Windows.Forms;
using CapaBLL;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string saludo = CapaBLL.ClassBLL.SaludoBLL();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            


        }
    }

}