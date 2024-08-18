namespace SharpNEX.Engine.GUI
{
    partial class SceneManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBar1 = new SharpNEX.Editor.UI.TitleBar();
            this.treeViewGameObjects = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBar1.ForeColor = System.Drawing.Color.Gray;
            this.titleBar1.ForeColorFormActive = System.Drawing.Color.White;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.LogoColorFormActive = System.Drawing.Color.White;
            this.titleBar1.LogoColorFormNotActive = System.Drawing.Color.Gray;
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(824, 29);
            this.titleBar1.TabIndex = 1;
            this.titleBar1.Text = "FormMain";
            // 
            // treeViewGameObjects
            // 
            this.treeViewGameObjects.Indent = 10;
            this.treeViewGameObjects.Location = new System.Drawing.Point(12, 34);
            this.treeViewGameObjects.Name = "treeViewGameObjects";
            this.treeViewGameObjects.Size = new System.Drawing.Size(788, 554);
            this.treeViewGameObjects.TabIndex = 2;
            this.treeViewGameObjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewGameObjects_MouseClick);
            // 
            // SceneManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 645);
            this.Controls.Add(this.treeViewGameObjects);
            this.Controls.Add(this.titleBar1);
            this.Name = "SceneManager";
            this.Text = "SceneManager";
            this.ResumeLayout(false);

        }

        #endregion

        private Editor.UI.TitleBar titleBar1;
        private System.Windows.Forms.TreeView treeViewGameObjects;
    }
}