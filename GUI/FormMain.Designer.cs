namespace SharpNEX.Editor.GUI
{
    partial class FormMain
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
            this.dockPanel1 = new DockPanelControler.DockPanel();
            this.dockPanel2 = new DockPanelControler.DockPanel();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBar1.ForeColor = System.Drawing.Color.Gray;
            this.titleBar1.ForeColorFormActive = System.Drawing.Color.White;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.LogoColorFormActive = System.Drawing.Color.White;
            this.titleBar1.LogoColorFormNotActive = System.Drawing.Color.Gray;
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(986, 45);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.Text = "FormMain";
            // 
            // dockPanel1
            // 
            this.dockPanel1.BackColorOnFormMove = System.Drawing.Color.Silver;
            this.dockPanel1.BodyPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dockPanel1.Location = new System.Drawing.Point(35, 71);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OutlineColorOnFormEnter = System.Drawing.Color.Red;
            this.dockPanel1.OutlineColorOnFormMove = System.Drawing.Color.Gray;
            this.dockPanel1.OutlineWidth = 3F;
            this.dockPanel1.Size = new System.Drawing.Size(326, 237);
            this.dockPanel1.TabIndex = 1;
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.TitleBarPanelBackColor = System.Drawing.Color.Silver;
            // 
            // dockPanel2
            // 
            this.dockPanel2.BackColorOnFormMove = System.Drawing.Color.Silver;
            this.dockPanel2.BodyPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dockPanel2.Location = new System.Drawing.Point(438, 118);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OutlineColorOnFormEnter = System.Drawing.Color.Red;
            this.dockPanel2.OutlineColorOnFormMove = System.Drawing.Color.Gray;
            this.dockPanel2.OutlineWidth = 3F;
            this.dockPanel2.Size = new System.Drawing.Size(373, 253);
            this.dockPanel2.TabIndex = 2;
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.TitleBarPanelBackColor = System.Drawing.Color.Silver;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 585);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.titleBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(274, 279);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.TitleBar titleBar1;
        private DockPanelControler.DockPanel dockPanel1;
        private DockPanelControler.DockPanel dockPanel2;
    }
}