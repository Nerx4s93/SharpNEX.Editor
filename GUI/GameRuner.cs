using System;
using System.Drawing;

using SharpNEX.Editor.UI;
using SharpNEX.Engine;

namespace SharpNEX.Editor.GUI
{
    public partial class GameRuner : CustomFromBaase
    {
        public GameRuner()
        {
            InitializeComponent();
        }

        private void GameRuner_Shown(object sender, EventArgs e)
        {
            Engine.Game.SetHandle(this, renderPanel.Handle, new Size(1920, 1080));
        }
    }
}
