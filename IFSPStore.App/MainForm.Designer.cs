namespace IFSPStore.App
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
            ReaLTaiizor.ControlRenderer controlRenderer2 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable2 = new ReaLTaiizor.MSColorTable();
            formMenuStrip = new ReaLTaiizor.Controls.FormMenuStrip();
            registerToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            cityToolStripMenuItem = new ToolStripMenuItem();
            custumerToolStripMenuItem = new ToolStripMenuItem();
            saleToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            formMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip
            // 
            formMenuStrip.ImageScalingSize = new Size(20, 20);
            formMenuStrip.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, reportToolStripMenuItem, helpToolStripMenuItem, closeToolStripMenuItem });
            formMenuStrip.Location = new Point(3, 64);
            formMenuStrip.Name = "formMenuStrip";
            controlRenderer2.ColorTable = msColorTable2;
            controlRenderer2.RoundedEdges = true;
            formMenuStrip.Renderer = controlRenderer2;
            formMenuStrip.Size = new Size(794, 28);
            formMenuStrip.TabIndex = 1;
            formMenuStrip.Text = "formMenuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, categoryToolStripMenuItem, productToolStripMenuItem, cityToolStripMenuItem, custumerToolStripMenuItem, saleToolStripMenuItem });
            registerToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(77, 24);
            registerToolStripMenuItem.Text = "Register";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(224, 26);
            userToolStripMenuItem.Text = "User";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(224, 26);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(224, 26);
            productToolStripMenuItem.Text = "Product";
            // 
            // cityToolStripMenuItem
            // 
            cityToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            cityToolStripMenuItem.Size = new Size(224, 26);
            cityToolStripMenuItem.Text = "City";
            // 
            // custumerToolStripMenuItem
            // 
            custumerToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            custumerToolStripMenuItem.Name = "custumerToolStripMenuItem";
            custumerToolStripMenuItem.Size = new Size(224, 26);
            custumerToolStripMenuItem.Text = "Custumer";
            // 
            // saleToolStripMenuItem
            // 
            saleToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            saleToolStripMenuItem.Size = new Size(224, 26);
            saleToolStripMenuItem.Text = "Sale";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(68, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(59, 24);
            closeToolStripMenuItem.Text = "Close";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = formMenuStrip;
            Name = "BaseForm";
            Text = "IFSP Store";
            WindowState = FormWindowState.Maximized;
            formMenuStrip.ResumeLayout(false);
            formMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem cityToolStripMenuItem;
        private ToolStripMenuItem custumerToolStripMenuItem;
        private ToolStripMenuItem saleToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}