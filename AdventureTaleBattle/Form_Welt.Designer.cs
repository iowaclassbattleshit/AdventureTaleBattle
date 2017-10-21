namespace Projekt_AdventureTale
{
    partial class Form_Welt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welt));
            this.lbl_Klasse = new System.Windows.Forms.Label();
            this.lbl_versperrung1 = new System.Windows.Forms.Label();
            this.lbl_versperrung2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Klasse
            // 
            this.lbl_Klasse.AutoSize = true;
            this.lbl_Klasse.Location = new System.Drawing.Point(12, 9);
            this.lbl_Klasse.Name = "lbl_Klasse";
            this.lbl_Klasse.Size = new System.Drawing.Size(0, 13);
            this.lbl_Klasse.TabIndex = 1;
            // 
            // lbl_versperrung1
            // 
            this.lbl_versperrung1.BackColor = System.Drawing.Color.Red;
            this.lbl_versperrung1.Location = new System.Drawing.Point(350, 400);
            this.lbl_versperrung1.Name = "lbl_versperrung1";
            this.lbl_versperrung1.Size = new System.Drawing.Size(50, 400);
            this.lbl_versperrung1.TabIndex = 3;
            // 
            // lbl_versperrung2
            // 
            this.lbl_versperrung2.BackColor = System.Drawing.Color.Red;
            this.lbl_versperrung2.Location = new System.Drawing.Point(400, 400);
            this.lbl_versperrung2.Name = "lbl_versperrung2";
            this.lbl_versperrung2.Size = new System.Drawing.Size(400, 50);
            this.lbl_versperrung2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Welt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lbl_versperrung2);
            this.Controls.Add(this.lbl_versperrung1);
            this.Controls.Add(this.lbl_Klasse);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Welt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventureTale";
            //this.Load += new System.EventHandler(this.Form_Welt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Klasse;
        private System.Windows.Forms.Label lbl_versperrung1;
        private System.Windows.Forms.Label lbl_versperrung2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}