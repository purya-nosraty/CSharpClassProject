namespace MyApplication
{
    partial class MainForm
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
            myMenuStrip = new MenuStrip();
            tollsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            myMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // myMenuStrip
            // 
            myMenuStrip.ImageScalingSize = new Size(20, 20);
            myMenuStrip.Items.AddRange(new ToolStripItem[] { tollsToolStripMenuItem, adminToolStripMenuItem });
            myMenuStrip.Location = new Point(0, 0);
            myMenuStrip.Name = "myMenuStrip";
            myMenuStrip.Size = new Size(800, 28);
            myMenuStrip.TabIndex = 0;
            myMenuStrip.Text = "menuStrip1";
            // 
            // tollsToolStripMenuItem
            // 
            tollsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, changePasswordToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            tollsToolStripMenuItem.Name = "tollsToolStripMenuItem";
            tollsToolStripMenuItem.Size = new Size(70, 24);
            tollsToolStripMenuItem.Text = "&Setting";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(224, 26);
            openToolStripMenuItem1.Text = "&Update Profile";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "&Admin";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(224, 26);
            changePasswordToolStripMenuItem.Text = "&Change Password";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "&Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(224, 26);
            usersToolStripMenuItem.Text = "&Users";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = myMenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MainForm";
            myMenuStrip.ResumeLayout(false);
            myMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip myMenuStrip;
        private ToolStripMenuItem tollsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
    }
}