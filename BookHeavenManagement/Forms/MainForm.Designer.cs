namespace BookHeavenManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            AdmintoolStripMenuItem = new ToolStripMenuItem();
            reportstoolStripMenuItem = new ToolStripMenuItem();
            helptoolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.GripStyle = ToolStripGripStyle.Visible;
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, booksToolStripMenuItem, salesToolStripMenuItem, customersToolStripMenuItem, AdmintoolStripMenuItem, reportstoolStripMenuItem, helptoolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(1073, 28);
            Menu.TabIndex = 0;
            Menu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(63, 24);
            booksToolStripMenuItem.Text = "Books";
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(57, 24);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(92, 24);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // AdmintoolStripMenuItem
            // 
            AdmintoolStripMenuItem.Name = "AdmintoolStripMenuItem";
            AdmintoolStripMenuItem.Size = new Size(67, 24);
            AdmintoolStripMenuItem.Text = "Admin";
            // 
            // reportstoolStripMenuItem
            // 
            reportstoolStripMenuItem.Name = "reportstoolStripMenuItem";
            reportstoolStripMenuItem.Size = new Size(74, 24);
            reportstoolStripMenuItem.Text = "Reports";
            // 
            // helptoolStripMenuItem
            // 
            helptoolStripMenuItem.Name = "helptoolStripMenuItem";
            helptoolStripMenuItem.Size = new Size(55, 24);
            helptoolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(225, 26);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 477);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "MainForm";
            Text = "MainForm";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem AdmintoolStripMenuItem;
        private ToolStripMenuItem reportstoolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem AdmintoolStripMenuItem;
        private ToolStripMenuItem reportstoolStripMenuItem;
        private ToolStripMenuItem helptoolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helptoolStripMenuItem;
        private ToolStripMenuItem File;
        private ToolStripMenuItem Books;
        private ToolStripMenuItem Sales;
        private ToolStripMenuItem Customers;
        private ToolStripMenuItem Admin;
        private ToolStripMenuItem Reports;
    }
}
