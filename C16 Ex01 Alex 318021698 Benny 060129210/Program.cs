using System;
using System.Windows.Forms;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public static class Program
    {    
        [STAThread]
       public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }
    }
}
