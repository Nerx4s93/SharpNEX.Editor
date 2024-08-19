using System;
using System.Drawing;
using System.Collections.Generic;
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
            UpdateTreeView();
        }

        private void TestCode_AddGameObjects()
        {
            GameData.Scene = new Scene("ExempleScene");
            GameObject gameObject = new GameObject("asdasd", new List<Script>());
            GameObject gameObject1 = new GameObject("asdasd", new List<Script>());
            GameObject gameObject2 = new GameObject("asdasd", new List<Script>());
            GameObject gameObject3 = new GameObject("asdasd", new List<Script>());
            gameObject.AddChild(gameObject1);
            gameObject.AddChild(gameObject2);
            gameObject1.AddChild(gameObject3);
            GameData.Scene.Instante(gameObject);
        }

        #region TreeViewGameObjects

        private void TreeViewGameObjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sceneManagementMenu.Show(Cursor.Position);
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
            TreeViewGameObjects.SelectedNode?.BeginEdit();
        }

        #endregion

        private void UpdateTreeView()
        {
            var gameObjects = GameData.Scene.GetGameObjects();

            foreach (var gameObject in gameObjects)
            {
                var childs = GetChildren(gameObject);
                var treeNode = new TreeNode(gameObject.Name, childs);
                treeNode.Tag = gameObject;

                TreeViewGameObjects.Nodes.Add(treeNode);
            }
        }

        private TreeNode[] GetChildren(GameObject gameObject)
        {
            var children = new List<TreeNode>();

            foreach (var childrenGameObject in gameObject.GetChilds())
            {
                var childs = GetChildren(childrenGameObject);
                var child = new TreeNode(childrenGameObject.Name, childs);
                child.Tag = childrenGameObject;

                children.Add(child);
            }

            return children.ToArray();
        }
    }
}
