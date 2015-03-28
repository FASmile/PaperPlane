using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Pipes;
using System.Text;
using System.Threading;

namespace PaperPlane
{
    static class MainClass
    {
        static gMain Program;

        [STAThread]
        static int Main(string[] args)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length == 1)
            {
                Program = new gMain(args);
                Application.Run(Program);

                
                Application.Exit();
                
            }
            
            return 0;
        }
        

    }
}
