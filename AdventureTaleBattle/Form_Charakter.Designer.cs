namespace Projekt_AdventureTale
{
    partial class Form_Charakter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Charakter));
            this.btn_Krieger = new System.Windows.Forms.Button();
            this.btn_Magier = new System.Windows.Forms.Button();
            this.btn_Assassin = new System.Windows.Forms.Button();
            this.pBox_Menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Krieger
            // 
            this.btn_Krieger.Location = new System.Drawing.Point(317, 116);
            this.btn_Krieger.Name = "btn_Krieger";
            this.btn_Krieger.Size = new System.Drawing.Size(60, 60);
            this.btn_Krieger.TabIndex = 0;
            this.btn_Krieger.Text = "Krieger";
            this.btn_Krieger.UseVisualStyleBackColor = true;
            this.btn_Krieger.Click += new System.EventHandler(this.btn_Krieger_Click);
            // 
            // btn_Magier
            // 
            this.btn_Magier.Location = new System.Drawing.Point(203, 303);
            this.btn_Magier.Name = "btn_Magier";
            this.btn_Magier.Size = new System.Drawing.Size(60, 60);
            this.btn_Magier.TabIndex = 1;
            this.btn_Magier.Text = "Magier";
            this.btn_Magier.UseVisualStyleBackColor = true;
            this.btn_Magier.Click += new System.EventHandler(this.btn_Magier_Click);
            // 
            // btn_Assassin
            // 
            this.btn_Assassin.Location = new System.Drawing.Point(454, 303);
            this.btn_Assassin.Name = "btn_Assassin";
            this.btn_Assassin.Size = new System.Drawing.Size(60, 60);
            this.btn_Assassin.TabIndex = 2;
            this.btn_Assassin.Text = "Assassin";
            this.btn_Assassin.UseVisualStyleBackColor = true;
            this.btn_Assassin.Click += new System.EventHandler(this.btn_Assassin_Click);
            // 
            // pBox_Menu
            // 
            this.pBox_Menu.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Menu.Image")));
            this.pBox_Menu.Location = new System.Drawing.Point(0, 1);
            this.pBox_Menu.Name = "pBox_Menu";
            this.pBox_Menu.Size = new System.Drawing.Size(738, 515);
            this.pBox_Menu.TabIndex = 5;
            this.pBox_Menu.TabStop = false;
            // 
            // Form_Charakter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 517);
            this.Controls.Add(this.btn_Assassin);
            this.Controls.Add(this.btn_Magier);
            this.Controls.Add(this.btn_Krieger);
            this.Controls.Add(this.pBox_Menu);
            this.Name = "Form_Charakter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charakter Auswahl";
            //this.Load += new System.EventHandler(this.Form_Charakter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Krieger;
        private System.Windows.Forms.Button btn_Magier;
        private System.Windows.Forms.Button btn_Assassin;
        private System.Windows.Forms.PictureBox pBox_Menu;
    }
}