using SharpNEX.Editor.UI.GUI;
using SharpNEX.Engine.GUI;

namespace SharpNEX.Editor.GUI
{
    public partial class FormMain : FormTitleBarlessBase
    {
        public FormMain()
        {
            InitializeComponent();
            SceneManager sceneManager = new SceneManager();
            sceneManager.Show();
        }
    }
}
