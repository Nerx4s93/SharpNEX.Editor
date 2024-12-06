namespace SharpNEX.Editor.GUI
{
    partial class GameRuner
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
            this.renderPanel = new System.Windows.Forms.Panel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
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
            this.titleBar1.Size = new System.Drawing.Size(598, 29);
            this.titleBar1.TabIndex = 2;
            this.titleBar1.Text = "GameRuner";
            // 
            // renderPanel
            // 
            this.renderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderPanel.BackColor = System.Drawing.Color.White;
            this.renderPanel.Location = new System.Drawing.Point(12, 63);
            this.renderPanel.Name = "renderPanel";
            this.renderPanel.Size = new System.Drawing.Size(574, 312);
            this.renderPanel.TabIndex = 3;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(12, 34);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(93, 34);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // GameRuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 387);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.renderPanel);
            this.Controls.Add(this.titleBar1);
            this.Name = "GameRuner";
            this.Text = "GameRuner";
            this.Shown += new System.EventHandler(this.GameRuner_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.TitleBar titleBar1;
        private System.Windows.Forms.Panel renderPanel;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonStop;
    }
}