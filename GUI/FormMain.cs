using System.Windows.Forms;

using SharpNEX.Engine.GUI;

namespace SharpNEX.Editor.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SceneManager sceneManager = new SceneManager();
            sceneManager.Show();
        }
    }
}
