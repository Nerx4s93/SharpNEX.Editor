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
            this.components = new System.ComponentModel.Container();
            this.titleBar1 = new SharpNEX.Editor.UI.TitleBar();
            this.sceneManagementMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewGameObjects = new SharpNEX.Editor.UI.TreeViewGameObjects();
            this.button1 = new System.Windows.Forms.Button();
            this.sceneManagementMenu.SuspendLayout();
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
            this.titleBar1.Size = new System.Drawing.Size(370, 29);
            this.titleBar1.TabIndex = 1;
            this.titleBar1.Text = "SceneManager";
            // 
            // sceneManagementMenu
            // 
            this.sceneManagementMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RenameToolStripMenuItem,
            this.DuplicateToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.CreateEmptyToolStripMenuItem});
            this.sceneManagementMenu.Name = "contextMenuStrip1";
            this.sceneManagementMenu.Size = new System.Drawing.Size(162, 98);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            this.RenameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.RenameToolStripMenuItem.Text = "Переименовать";
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // DuplicateToolStripMenuItem
            // 
            this.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem";
            this.DuplicateToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.DuplicateToolStripMenuItem.Text = "Дублировать";
            this.DuplicateToolStripMenuItem.Click += new System.EventHandler(this.DuplicateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // CreateEmptyToolStripMenuItem
            // 
            this.CreateEmptyToolStripMenuItem.Name = "CreateEmptyToolStripMenuItem";
            this.CreateEmptyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.CreateEmptyToolStripMenuItem.Text = "Создать пустой";
            this.CreateEmptyToolStripMenuItem.Click += new System.EventHandler(this.CreateEmptyToolStripMenuItem_Click);
            // 
            // TreeViewGameObjects
            // 
            this.TreeViewGameObjects.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.TreeViewGameObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeViewGameObjects.LabelEdit = true;
            this.TreeViewGameObjects.Location = new System.Drawing.Point(12, 34);
            this.TreeViewGameObjects.Name = "TreeViewGameObjects";
            this.TreeViewGameObjects.Size = new System.Drawing.Size(347, 740);
            this.TreeViewGameObjects.TabIndex = 2;
            this.TreeViewGameObjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeViewGameObjects_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SceneManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 785);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TreeViewGameObjects);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SceneManager";
            this.Text = "SceneManager";
            this.sceneManagementMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Editor.UI.TitleBar titleBar1;
        private System.Windows.Forms.ContextMenuStrip sceneManagementMenu;
        private System.Windows.Forms.ToolStripMenuItem RenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CreateEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DuplicateToolStripMenuItem;
        private Editor.UI.TreeViewGameObjects TreeViewGameObjects;
        private System.Windows.Forms.Button button1;
    }
}