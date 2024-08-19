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

        private void LoadTreeView()
        {
            TreeViewGameObjects.Nodes.Clear();

            var gameObjects = GameData.Scene.GetGameObjects();

            foreach (var gameObject in gameObjects)
            {
                AddGameObjectToTreeView(gameObject);
                GetChildren(gameObject);
            }
        }

        private void GetChildren(GameObject gameObject)
        {
            foreach (var childrenGameObject in gameObject.GetChilds())
            {
                AddGameObjectToTreeView(childrenGameObject);
                GetChildren(childrenGameObject);
            }
        }

        private void AddGameObjectToTreeView(GameObject gameObject)
        {
            if (gameObject.Parent == null)
            {
                var treeNode = new TreeNode(gameObject.Name)
                {
                    Tag = gameObject
                };

                TreeViewGameObjects.Nodes.Add(treeNode);
            }
            else
        {
                var treeNodeList = GetAllNodes(TreeViewGameObjects);

                var treeNodeParent = treeNodeList.Find(x => x.Tag as GameObject == gameObject.Parent);

                var treeNode = new TreeNode(gameObject.Name)
            {
                    Tag = gameObject
                };

                treeNodeParent.Nodes.Add(treeNode);
            }
        }

        public static List<TreeNode> GetAllNodes(TreeView _self)
        {
            List<TreeNode> result = new List<TreeNode>();
            foreach (TreeNode child in _self.Nodes)
            {
                result.AddRange(GetAllNodes(child));
            }
            return result;
            }

        public static List<TreeNode> GetAllNodes(TreeNode _self)
        {
            List<TreeNode> result = new List<TreeNode>();
            result.Add(_self);
            foreach (TreeNode child in _self.Nodes)
            {
                result.AddRange(GetAllNodes(child));
            }
            return result;
        }
    }
}
