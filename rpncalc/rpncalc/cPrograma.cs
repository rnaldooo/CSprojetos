using System;
using System.Windows.Forms;
namespace MINIrpncalc
{
    static class cPrograma
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new foMINIrpncalc());            
        }
    }
}
