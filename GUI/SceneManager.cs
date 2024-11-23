using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using SharpNEX.Engine;
using SharpNEX.Game;
using DockPanelControler.Components;

namespace SharpNEX.Engine.GUI
{
    public partial class SceneManager : Form
    {
        private FormDockHandler _formDockHandler;

        public SceneManager()
        {
            TestCode_AddGameObjects();

            InitializeComponent();
            _formDockHandler = new FormDockHandler(this);
        }

        private void TestCode_AddGameObjects()
        {
            Data.Scene = new Scene("ExempleScene");

            GameObject one = new GameObject("1");
            GameObject two = new GameObject("2");
            GameObject three = new GameObject("3");
            GameObject four = new GameObject("4");

            one = Data.Scene.Instantiate(one);
            two = Data.Scene.Instantiate(two);
            three = Data.Scene.Instantiate(three);
            four = Data.Scene.Instantiate(four);

            one.AddChild(two);
            one.AddChild(four);
            two.AddChild(three);
        }

        private void TreeViewGameObjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sceneManagementMenu.Show(Cursor.Position);

                bool objectHasBeenSelected = TreeViewGameObjects.SelectedNode == null;
                RenameToolStripMenuItem.Enabled = !objectHasBeenSelected;
                DeleteToolStripMenuItem.Enabled = !objectHasBeenSelected;
                DuplicateToolStripMenuItem.Enabled = !objectHasBeenSelected;
            }
        }

        #region SceneManagementMenu

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeViewGameObjects.SelectedNode.BeginEdit();
        }

        private void DuplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameObject = TreeViewGameObjects.SelectedNode.Tag as GameObject;

            if (gameObject.Parent == null)
            {
                Data.Scene.Instantiate(gameObject);
            }
            else
            {
                Data.Scene.Instantiate(gameObject, gameObject.Parent);
            }

            TreeViewGameObjects.LoadTreeView();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = TreeViewGameObjects.SelectedNode;

            var gameObject = node.Tag as GameObject;
            Data.Scene.Destroy(gameObject);

            TreeViewGameObjects.Nodes.Remove(node);
        }

        private void CreateEmptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameObject = new GameObject("GameObject");

            if (TreeViewGameObjects.SelectedNode == null)
            {
                Data.Scene.Instantiate(gameObject);
            }
            else
            {
                var parent = TreeViewGameObjects.SelectedNode.Tag as GameObject;
                gameObject = Data.Scene.Instantiate(gameObject, parent);
            }

            var treeNode = TreeViewGameObjects.AddGameObjectToTreeView(gameObject);
            treeNode.Parent.Expand();
            treeNode.BeginEdit();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Width + "; " + Height);
        }
    }
}
