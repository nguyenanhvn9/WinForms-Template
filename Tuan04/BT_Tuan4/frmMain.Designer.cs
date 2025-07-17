namespace Bai2
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            inputDataTimeToolStripMenuItem = new ToolStripMenuItem();
            comBoboxToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            raidoButtonToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, registrationToolStripMenuItem, inputDataTimeToolStripMenuItem, comBoboxToolStripMenuItem, listBoxToolStripMenuItem, checkBoxToolStripMenuItem, raidoButtonToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 24);
            toolStripMenuItem1.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(191, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // registrationToolStripMenuItem
            // 
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(191, 26);
            registrationToolStripMenuItem.Text = "Registration";
            registrationToolStripMenuItem.Click += registrationToolStripMenuItem_Click;
            // 
            // inputDataTimeToolStripMenuItem
            // 
            inputDataTimeToolStripMenuItem.Name = "inputDataTimeToolStripMenuItem";
            inputDataTimeToolStripMenuItem.Size = new Size(191, 26);
            inputDataTimeToolStripMenuItem.Text = "InputDataTime";
            inputDataTimeToolStripMenuItem.Click += inputDataTimeToolStripMenuItem_Click;
            // 
            // comBoboxToolStripMenuItem
            // 
            comBoboxToolStripMenuItem.Name = "comBoboxToolStripMenuItem";
            comBoboxToolStripMenuItem.Size = new Size(191, 26);
            comBoboxToolStripMenuItem.Text = "ComBobox";
            comBoboxToolStripMenuItem.Click += comBoboxToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(191, 26);
            listBoxToolStripMenuItem.Text = "ListBox";
            listBoxToolStripMenuItem.Click += listBoxToolStripMenuItem_Click;
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(191, 26);
            checkBoxToolStripMenuItem.Text = "CheckBox";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // raidoButtonToolStripMenuItem
            // 
            raidoButtonToolStripMenuItem.Name = "raidoButtonToolStripMenuItem";
            raidoButtonToolStripMenuItem.Size = new Size(191, 26);
            raidoButtonToolStripMenuItem.Text = "RaidoButton";
            raidoButtonToolStripMenuItem.Click += raidoButtonToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem inputDataTimeToolStripMenuItem;
        private ToolStripMenuItem comBoboxToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem raidoButtonToolStripMenuItem;
    }
}