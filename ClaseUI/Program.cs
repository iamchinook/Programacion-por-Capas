using System;
using System.Object;
using System.Windows.Forms;
using CapaBLL;

namespace ClaseUI
{
    internal static class Program

    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
    }
}
