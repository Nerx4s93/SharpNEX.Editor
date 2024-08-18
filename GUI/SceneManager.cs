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

        private void treeViewGameObjects_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void UpdateTreeView()
        {
            treeViewGameObjects.Nodes.Add("dada");
            var gameObjects = GameData.Scene.GetGameObjects();

            foreach (var gameObject in gameObjects)
            {
                var childs = GetChildren(gameObject);
                var treeNode = new TreeNode(gameObject.Name, childs);

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

                children.Add(child);
            }

            return children.ToArray();
        }
    }
}
