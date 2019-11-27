namespace MyFirstWinForm
{
    partial class game
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
            this.clicker = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.upgradeOne = new System.Windows.Forms.Button();
            this.cookies = new System.Windows.Forms.Label();
            this.upgradeOneText = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // clicker
            // 
            this.clicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clicker.Location = new System.Drawing.Point(826, 461);
            this.clicker.Margin = new System.Windows.Forms.Padding(4);
            this.clicker.Name = "clicker";
            this.clicker.Size = new System.Drawing.Size(417, 62);
            this.clicker.TabIndex = 0;
            this.clicker.Text = "Clicker";
            this.clicker.UseVisualStyleBackColor = true;
            this.clicker.Click += new System.EventHandler(this.Clicker_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.upgradeOneText);
            this.panelLeft.Controls.Add(this.upgradeOne);
            this.panelLeft.Location = new System.Drawing.Point(16, 15);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(267, 730);
            this.panelLeft.TabIndex = 2;
            // 
            // upgradeOne
            // 
            this.upgradeOne.Location = new System.Drawing.Point(63, 70);
            this.upgradeOne.Margin = new System.Windows.Forms.Padding(4);
            this.upgradeOne.Name = "upgradeOne";
            this.upgradeOne.Size = new System.Drawing.Size(128, 96);
            this.upgradeOne.TabIndex = 0;
            this.upgradeOne.Text = "Upgrade";
            this.upgradeOne.UseVisualStyleBackColor = true;
            this.upgradeOne.Click += new System.EventHandler(this.UpgradeOne_Click);
            // 
            // cookies
            // 
            this.cookies.BackColor = System.Drawing.SystemColors.Highlight;
            this.cookies.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cookies.Location = new System.Drawing.Point(880, 158);
            this.cookies.Name = "cookies";
            this.cookies.Size = new System.Drawing.Size(300, 100);
            this.cookies.TabIndex = 4;
            this.cookies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeOneText
            // 
            this.upgradeOneText.BackColor = System.Drawing.Color.Aqua;
            this.upgradeOneText.Location = new System.Drawing.Point(76, 185);
            this.upgradeOneText.Name = "upgradeOneText";
            this.upgradeOneText.Size = new System.Drawing.Size(100, 30);
            this.upgradeOneText.TabIndex = 3;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2986, 1227);
            this.Controls.Add(this.cookies);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.clicker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "game";
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clicker;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button upgradeOne;
        private System.Windows.Forms.Label cookies;
        private System.Windows.Forms.Label upgradeOneText;
    }
}

