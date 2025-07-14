namespace Bai_2
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
            loginToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1576, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, registerToolStripMenuItem1 });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(50, 20);
            loginToolStripMenuItem.Text = "Menu";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(116, 22);
            registerToolStripMenuItem.Text = "Login";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click_1;
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(116, 22);
            registerToolStripMenuItem1.Text = "Register";
            registerToolStripMenuItem1.Click += registerToolStripMenuItem1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 799);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem1;
    }
}