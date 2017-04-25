namespace Restoran
{
    partial class MasaListeForm
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
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.flwMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.Location = new System.Drawing.Point(12, 22);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(80, 20);
            this.lblSalonAdi.TabIndex = 0;
            this.lblSalonAdi.Text = "Salon Adı";
            // 
            // flwMasalar
            // 
            this.flwMasalar.AutoScroll = true;
            this.flwMasalar.Location = new System.Drawing.Point(13, 55);
            this.flwMasalar.Name = "flwMasalar";
            this.flwMasalar.Size = new System.Drawing.Size(390, 297);
            this.flwMasalar.TabIndex = 1;
            // 
            // MasaListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 364);
            this.Controls.Add(this.flwMasalar);
            this.Controls.Add(this.lblSalonAdi);
            this.Name = "MasaListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasaListeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasaListeForm_FormClosing);
            this.Load += new System.EventHandler(this.MasaListeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.FlowLayoutPanel flwMasalar;
    }
}