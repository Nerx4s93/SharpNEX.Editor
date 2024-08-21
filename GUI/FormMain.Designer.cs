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
            this.dockPanelLeft = new DockPanelControler.DockPanel();
            this.dockPanelRight = new DockPanelControler.DockPanel();
            this.dockPanelTop = new DockPanelControler.DockPanel();
            this.dockPanelBottom = new DockPanelControler.DockPanel();
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
            this.titleBar1.Size = new System.Drawing.Size(1106, 45);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.Text = "FormMain";
            // 
            // dockPanelLeft
            // 
            this.dockPanelLeft.AdditionalScope = 100;
            this.dockPanelLeft.BackColorOnFormMove = System.Drawing.Color.Silver;
            this.dockPanelLeft.BodyPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dockPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockPanelLeft.Location = new System.Drawing.Point(0, 45);
            this.dockPanelLeft.Name = "dockPanelLeft";
            this.dockPanelLeft.OutlineColorOnFormEnter = System.Drawing.Color.Red;
            this.dockPanelLeft.OutlineColorOnFormMove = System.Drawing.Color.Gray;
            this.dockPanelLeft.OutlineWidth = 3F;
            this.dockPanelLeft.Size = new System.Drawing.Size(273, 757);
            this.dockPanelLeft.TabIndex = 1;
            this.dockPanelLeft.Text = "dockPanelLeft";
            this.dockPanelLeft.TitleBarPanelBackColor = System.Drawing.Color.Silver;
            // 
            // dockPanelRight
            // 
            this.dockPanelRight.AdditionalScope = 100;
            this.dockPanelRight.BackColorOnFormMove = System.Drawing.Color.Silver;
            this.dockPanelRight.BodyPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dockPanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockPanelRight.Location = new System.Drawing.Point(833, 45);
            this.dockPanelRight.Name = "dockPanelRight";
            this.dockPanelRight.OutlineColorOnFormEnter = System.Drawing.Color.Red;
            this.dockPanelRight.OutlineColorOnFormMove = System.Drawing.Color.Gray;
            this.dockPanelRight.OutlineWidth = 3F;
            this.dockPanelRight.Size = new System.Drawing.Size(273, 757);
            this.dockPanelRight.TabIndex = 2;
            this.dockPanelRight.Text = "dockPanel1";
            this.dockPanelRight.TitleBarPanelBackColor = System.Drawing.Color.Silver;
            // 
            // dockPanelTop
            // 
            this.dockPanelTop.AdditionalScope = 100;
            this.dockPanelTop.BackColorOnFormMove = System.Drawing.Color.Silver;
            this.dockPanelTop.BodyPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dockPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelTop.Location = new System.Drawing.Point(273, 45);
            this.dockPanelTop.Name = "dockPanelTop";
            this.dockPanelTop.OutlineColorOnFormEnter = System.Drawing.Color.Red;
            this.dockPanelTop.OutlineColorOnFormMove = System.Drawing.Color.Gray;
            this.dockPanelTop.OutlineWidth = 3F;
            this.dockPanelTop.Size = new System.Drawing.Size(560, 757);
            this.dockPanelTop.TabIndex = 3;
            this.dockPanelTop.Text = "dockPanel2";
            this.dockPanelTop.TitleBarPanelBackColor = System.Drawing.Color.Silver;
            // 
            // dockPanelBottom
            // 
            this.dockPanelBottom.AdditionalScope = 100;
            this.dockPanelBottom.BackColorOnFormMove = System.Drawing.Color.Silver;
            this.dockPanelBottom.BodyPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dockPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockPanelBottom.Location = new System.Drawing.Point(273, 590);
            this.dockPanelBottom.Name = "dockPanelBottom";
            this.dockPanelBottom.OutlineColorOnFormEnter = System.Drawing.Color.Red;
            this.dockPanelBottom.OutlineColorOnFormMove = System.Drawing.Color.Gray;
            this.dockPanelBottom.OutlineWidth = 3F;
            this.dockPanelBottom.Size = new System.Drawing.Size(560, 212);
            this.dockPanelBottom.TabIndex = 4;
            this.dockPanelBottom.Text = "dockPanel2";
            this.dockPanelBottom.TitleBarPanelBackColor = System.Drawing.Color.Silver;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 802);
            this.Controls.Add(this.dockPanelBottom);
            this.Controls.Add(this.dockPanelTop);
            this.Controls.Add(this.dockPanelRight);
            this.Controls.Add(this.dockPanelLeft);
            this.Controls.Add(this.titleBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(274, 279);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.TitleBar titleBar1;
        private DockPanelControler.DockPanel dockPanelLeft;
        private DockPanelControler.DockPanel dockPanelRight;
        private DockPanelControler.DockPanel dockPanelTop;
        private DockPanelControler.DockPanel dockPanelBottom;
    }
}