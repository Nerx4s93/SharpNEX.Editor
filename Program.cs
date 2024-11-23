using System;
using System.Windows.Forms;

using SharpNEX.Editor.GUI;

namespace SharpNEX.Editor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
