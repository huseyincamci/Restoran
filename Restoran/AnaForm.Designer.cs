namespace Restoran
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisTool = new System.Windows.Forms.ToolStripMenuItem();
            this.urunTool = new System.Windows.Forms.ToolStripMenuItem();
            this.salonTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisTool,
            this.urunTool,
            this.salonTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisTool
            // 
            this.siparisTool.Name = "siparisTool";
            this.siparisTool.Size = new System.Drawing.Size(59, 21);
            this.siparisTool.Text = "Sipariş";
            this.siparisTool.Click += new System.EventHandler(this.siparisTool_Click);
            // 
            // urunTool
            // 
            this.urunTool.Name = "urunTool";
            this.urunTool.Size = new System.Drawing.Size(48, 21);
            this.urunTool.Text = "Ürün";
            this.urunTool.Click += new System.EventHandler(this.urunTool_Click);
            // 
            // salonTool
            // 
            this.salonTool.Name = "salonTool";
            this.salonTool.Size = new System.Drawing.Size(52, 21);
            this.salonTool.Text = "Salon";
            this.salonTool.Click += new System.EventHandler(this.salonTool_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 368);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisTool;
        private System.Windows.Forms.ToolStripMenuItem urunTool;
        private System.Windows.Forms.ToolStripMenuItem salonTool;
    }
}

