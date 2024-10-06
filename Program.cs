using System;
using System.Windows.Forms;

namespace YourNamespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibrarySystemFrontend.Form1());  // Ana formunuzu buraya yazýn
        }
    }
}
