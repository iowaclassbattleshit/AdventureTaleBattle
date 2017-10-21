namespace AdventureTaleBattle
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.btnAttack3 = new System.Windows.Forms.Button();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.lblYourHP = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAttack1
            // 
            this.btnAttack1.BackColor = System.Drawing.Color.White;
            this.btnAttack1.Location = new System.Drawing.Point(12, 12);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(159, 53);
            this.btnAttack1.TabIndex = 1;
            this.btnAttack1.Text = "Y | 5 Schaden | 100% Treffer";
            this.btnAttack1.UseVisualStyleBackColor = false;
            this.btnAttack1.Click += new System.EventHandler(this.btnAttack1_Click);
            // 
            // btnAttack2
            // 
            this.btnAttack2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttack2.BackgroundImage")));
            this.btnAttack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttack2.Location = new System.Drawing.Point(177, 12);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(159, 53);
            this.btnAttack2.TabIndex = 2;
            this.btnAttack2.Text = "X | 15 Schaden | 80% Treffer";
            this.btnAttack2.UseVisualStyleBackColor = true;
            this.btnAttack2.Click += new System.EventHandler(this.btnAttack2_Click_1);
            // 
            // btnAttack3
            // 
            this.btnAttack3.Location = new System.Drawing.Point(342, 12);
            this.btnAttack3.Name = "btnAttack3";
            this.btnAttack3.Size = new System.Drawing.Size(159, 53);
            this.btnAttack3.TabIndex = 3;
            this.btnAttack3.Text = "C | 35 Schaden | 60% Treffer";
            this.btnAttack3.UseVisualStyleBackColor = true;
            this.btnAttack3.Click += new System.EventHandler(this.btnAttack3_Click);
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.BackColor = System.Drawing.Color.Red;
            this.lblEnemyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnemyHP.Location = new System.Drawing.Point(601, 141);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(100, 23);
            this.lblEnemyHP.TabIndex = 6;
            this.lblEnemyHP.Text = "100";
            this.lblEnemyHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourHP
            // 
            this.lblYourHP.BackColor = System.Drawing.Color.Red;
            this.lblYourHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourHP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYourHP.Location = new System.Drawing.Point(174, 266);
            this.lblYourHP.Name = "lblYourHP";
            this.lblYourHP.Size = new System.Drawing.Size(100, 23);
            this.lblYourHP.TabIndex = 8;
            this.lblYourHP.Text = "100";
            this.lblYourHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundCount.Location = new System.Drawing.Point(654, 12);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(154, 52);
            this.lblRoundCount.TabIndex = 9;
            this.lblRoundCount.Text = "Runde";
            this.lblRoundCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRound
            // 
            this.lblRound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(814, 12);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(100, 52);
            this.lblRound.TabIndex = 10;
            this.lblRound.Text = "0";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiss
            // 
            this.lblMiss.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMiss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.Location = new System.Drawing.Point(507, 12);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(141, 52);
            this.lblMiss.TabIndex = 11;
            this.lblMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 518);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblYourHP);
            this.Controls.Add(this.btnAttack3);
            this.Controls.Add(this.btnAttack2);
            this.Controls.Add(this.btnAttack1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAttack1;
        private System.Windows.Forms.Button btnAttack2;
        private System.Windows.Forms.Button btnAttack3;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Label lblYourHP;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblMiss;
    }
}

