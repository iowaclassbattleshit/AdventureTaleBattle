namespace Projekt_AdventureTale
{
    partial class Form_Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.lbl_GameTitle = new System.Windows.Forms.Label();
            this.btn_Charakter = new System.Windows.Forms.Button();
            this.btn_Mitwirkende = new System.Windows.Forms.Button();
            this.pBox_Menu = new System.Windows.Forms.PictureBox();
            this.lblMitwirkende = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GameTitle
            // 
            this.lbl_GameTitle.AutoSize = true;
            this.lbl_GameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GameTitle.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lbl_GameTitle.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameTitle.Location = new System.Drawing.Point(166, 78);
            this.lbl_GameTitle.Name = "lbl_GameTitle";
            this.lbl_GameTitle.Size = new System.Drawing.Size(411, 80);
            this.lbl_GameTitle.TabIndex = 0;
            this.lbl_GameTitle.Text = "AdventureTale\r\n";
            // 
            // btn_Charakter
            // 
            this.btn_Charakter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Charakter.Location = new System.Drawing.Point(309, 217);
            this.btn_Charakter.Name = "btn_Charakter";
            this.btn_Charakter.Size = new System.Drawing.Size(118, 23);
            this.btn_Charakter.TabIndex = 1;
            this.btn_Charakter.Text = "Charakter Auswahl";
            this.btn_Charakter.UseVisualStyleBackColor = false;
            this.btn_Charakter.Click += new System.EventHandler(this.btn_Charakter_Click);
            // 
            // btn_Mitwirkende
            // 
            this.btn_Mitwirkende.Location = new System.Drawing.Point(326, 346);
            this.btn_Mitwirkende.Name = "btn_Mitwirkende";
            this.btn_Mitwirkende.Size = new System.Drawing.Size(75, 23);
            this.btn_Mitwirkende.TabIndex = 3;
            this.btn_Mitwirkende.Text = "Mitwirkende";
            this.btn_Mitwirkende.UseVisualStyleBackColor = true;
            this.btn_Mitwirkende.Click += new System.EventHandler(this.btn_Mitwirkende_Click);
            // 
            // pBox_Menu
            // 
            this.pBox_Menu.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Menu.Image")));
            this.pBox_Menu.Location = new System.Drawing.Point(1, 1);
            this.pBox_Menu.Name = "pBox_Menu";
            this.pBox_Menu.Size = new System.Drawing.Size(738, 515);
            this.pBox_Menu.TabIndex = 4;
            this.pBox_Menu.TabStop = false;
            // 
            // lblMitwirkende
            // 
            this.lblMitwirkende.BackColor = System.Drawing.Color.Transparent;
            this.lblMitwirkende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMitwirkende.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMitwirkende.Location = new System.Drawing.Point(177, 479);
            this.lblMitwirkende.Name = "lblMitwirkende";
            this.lblMitwirkende.Size = new System.Drawing.Size(400, 29);
            this.lblMitwirkende.TabIndex = 5;
            this.lblMitwirkende.Text = "© Dominic Droz, Cedric Schacher, Marc Schläpfer";
            this.lblMitwirkende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMitwirkende.Visible = false;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 517);
            this.Controls.Add(this.lblMitwirkende);
            this.Controls.Add(this.lbl_GameTitle);
            this.Controls.Add(this.btn_Mitwirkende);
            this.Controls.Add(this.btn_Charakter);
            this.Controls.Add(this.pBox_Menu);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdventureTale";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GameTitle;
        private System.Windows.Forms.Button btn_Charakter;
        private System.Windows.Forms.Button btn_Mitwirkende;
        private System.Windows.Forms.PictureBox pBox_Menu;
        private System.Windows.Forms.Label lblMitwirkende;
    }
}

