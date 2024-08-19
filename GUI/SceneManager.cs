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

        private void treeViewGameObjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sceneManagementMenu.Show(Cursor.Position);
            }
        }

        private void UpdateTreeView()
        {
            var gameObjects = GameData.Scene.GetGameObjects();

            foreach (var gameObject in gameObjects)
            {
                var childs = GetChildren(gameObject);
                var treeNode = new TreeNode(gameObject.Name, childs);
                treeNode.Tag = gameObject;

                treeViewGameObjects.Nodes.Add(treeNode);
            }
        }

        private TreeNode[] GetChildren(GameObject gameObject)
        {
            var children = new List<TreeNode>();

            foreach (var childrenGameObject in gameObject.GetChilds())
            {
                var childs = GetChildren(childrenGameObject);
                var child = new TreeNode(childrenGameObject.Name, childs);
                child.Tag = child;

                children.Add(child);
            }

            return children.ToArray();
        }
    }
}
