using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using SharpNEX.Editor.UI.GUI;

using SharpNEX.Engine;
using DockPanelControler.Components;

namespace SharpNEX.Engine.GUI
{
    public partial class SceneManager : FormTitleBarlessBase
    {
        private FormDockHandler _formDockHandler;

        public SceneManager()
        {
            InitializeComponent();
            _formDockHandler = new FormDockHandler(this);

            TestCode_AddGameObjects();
            LoadTreeView();
        }

        private void TestCode_AddGameObjects()
        {
            GameData.Scene = new Scene("ExempleScene");

            GameObject one = new GameObject("1");
            GameObject two = new GameObject("2");
            GameObject three = new GameObject("3");
            GameObject four = new GameObject("4");

            one = GameData.Scene.Instantiate(one);
            two = GameData.Scene.Instantiate(two);
            three = GameData.Scene.Instantiate(three);
            four = GameData.Scene.Instantiate(four);

            one.AddChild(two);
            one.AddChild(four);
            two.AddChild(three);
        }

        #region TreeViewGameObjects

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

        private void TreeViewGameObjects_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            var gameObject = e.Node.Tag as GameObject;
            gameObject.Name = e.Label;
        }

        private void TreeViewGameObjects_DoubleClick(object sender, EventArgs e)
        {
            TreeViewGameObjects.SelectedNode?.BeginEdit();
        }

        #endregion
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
                gameObject = GameData.Scene.Instantiate(gameObject);
            }
            else
            {
                gameObject = GameData.Scene.Instantiate(gameObject, gameObject.Parent);
            }

            LoadTreeView();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = TreeViewGameObjects.SelectedNode;

            var gameObject = node.Tag as GameObject;
            GameData.Scene.Destroy(gameObject);

            TreeViewGameObjects.Nodes.Remove(node);
        }

        private void CreateEmptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameObject = new GameObject("GameObject");

            if (TreeViewGameObjects.SelectedNode == null)
            {
                GameData.Scene.Instantiate(gameObject);
            }
            else
            {
                var parent = TreeViewGameObjects.SelectedNode.Tag as GameObject;
                gameObject = GameData.Scene.Instantiate(gameObject, parent);
            }

            var treeNode = AddGameObjectToTreeView(gameObject);
            treeNode.Parent.Expand();
            treeNode.BeginEdit();
        }

        #endregion

        private void LoadTreeView()
        {
            TreeViewGameObjects.Nodes.Clear();

            var gameObjects = GameData.Scene.GetGameObjects();

            foreach (var gameObject in gameObjects)
            {
                AddGameObjectToTreeView(gameObject);
            }
        }

        private TreeNode AddGameObjectToTreeView(GameObject gameObject)
        {
            var treeNode = new TreeNode(gameObject.Name)
            {
                Tag = gameObject
            };

            if (gameObject.Parent == null)
            {
                TreeViewGameObjects.Nodes.Add(treeNode);
            }
            else
            {
                var treeNodeList = GetAllNodes(TreeViewGameObjects);

                var treeNodeParent = treeNodeList.Find(x => x.Tag as GameObject == gameObject.Parent);

               treeNodeParent.Nodes.Add(treeNode);
            }

            return treeNode;
        }

        public static List<TreeNode> GetAllNodes(TreeView treeView)
        {
            List<TreeNode> result = new List<TreeNode>();
            foreach (TreeNode child in treeView.Nodes)
            {
                result.AddRange(GetAllNodes(child));
            }
            return result;
        }

        public static List<TreeNode> GetAllNodes(TreeNode treeNove)
        {
            List<TreeNode> result = new List<TreeNode>();
            result.Add(treeNove);
            foreach (TreeNode child in treeNove.Nodes)
            {
                result.AddRange(GetAllNodes(child));
            }
            return result;
        }
    }
}
