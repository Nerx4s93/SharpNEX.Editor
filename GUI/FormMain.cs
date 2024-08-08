using SharpNEX.Editor.UI.GUI;
using SharpNEX.Engine.GUI;

namespace SharpNEX.Editor.GUI
{
    public partial class FormMain : FormTitleBarlessBase
    {
        public FormMain()
        {
            InitializeComponent();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
