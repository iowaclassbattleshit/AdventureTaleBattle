using Projekt_AdventureTale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureTaleBattle
{
    public partial class Form1 : Form
    {
        Boolean _exiting;
        Label lblEnemy = new Label();
        Label lblYou = new Label();
        public Form1(Person gegner, Person user)
        {
            
 
            KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(move);

            InitializeComponent();
            spawnUser(user);
            spawngegner(gegner);
            lblEnemyHP.BringToFront();
            lblEnemy.BackColor = Color.Transparent;
            lblYou.BackColor = Color.Transparent;
        }

        private void spawngegner(Person gegner)
        {
            lblEnemy.Image = gegner.getImage();
            lblEnemy.Location = new Point(400, 110);
            lblEnemy.AutoSize = false;
            lblEnemy.Size = new Size(400,400);
            this.Controls.Add(lblEnemy);
            if(gegner.getName() == "König Sonnenbrand")
            {
                lblEnemy.Location = new Point(450, 110);
                lblEnemy.Image = Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/kinggross.png");
            }
        }

        private void spawnUser(Person user)
        {
            lblYou.Image = user.getImage();
            lblYou.Location = new Point(135, 300);
            lblYou.AutoSize = false;
            lblYou.Size = new Size(200, 200);
            this.Controls.Add(lblYou);
            if (user.getName() == "Magier")
            {
                lblYou.Image = Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/mageturned.png");
            }
            if (user.getName() == "Assassin")
            {
                lblYou.Image = Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/assasinturned.png");
            }
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            angriff1();
        }
        private void btnAttack2_Click_1(object sender, EventArgs e)
        {
            angriff2();
        }

        private void btnAttack3_Click(object sender, EventArgs e)
        {
            angriff3();
        }

        public void schadenAnGegner(ref int angriffsSchaden)
        {
            int x;
            Int32.TryParse(lblEnemyHP.Text, out x);
            int resultat = x - angriffsSchaden;
            string resultatString = resultat.ToString();
            lblEnemyHP.Text = resultatString;
            lblEnemyHP.Width = resultat;
            gegnerLebt(ref resultat);
        }

        public void gegnerLebt(ref int resultat2)
        {
            if (resultat2 <= 0)
            {
                if (MessageBox.Show("Glückwunsch Sie haben gewonnen! Wollen Sie nocheinmal spielen?",
                       "AdventureTales",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Form_Menu restart = new Form_Menu();
                    this.Hide();
                    restart.Show();
                }
                else
                {
                    Application.Exit();
                    
                }
            }
            else
            {
                gegnerZug();
            }
        }

        public void gegnerZug()
        {
            int i;
            Int32.TryParse(lblRound.Text, out i);
            i++;
            string neueRunde = i.ToString();
            lblRound.Text = neueRunde;
            int angriffsSchaden = 10;
            int x;
            Int32.TryParse(lblYourHP.Text, out x);
            int resultat = x - angriffsSchaden;
            string resultatString = resultat.ToString();
            lblYourHP.Text = resultatString;
            lblYourHP.Width = resultat;
            spielerLebt();
        }

        public void spielerLebt()
        {
            int i;
            Int32.TryParse(lblYourHP.Text, out i);
            if (i <= 0)
            {
                yourDeath();
            }
            else
            {
                Form gameOver = new Form();
                
            }
        }

        public void move(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y)
            {
                angriff1();
            }
            else if (e.KeyCode == Keys.X)
            {
                angriff2();
            }
            else if (e.KeyCode == Keys.C)
            {
                angriff3();
            }
        }
        private void angriff1()
        {
            int ad = 5;
            int wahrscheinlichkeit = 0;
            if (probability(wahrscheinlichkeit))
            {
                schadenAnGegner(ref ad);
                lblMiss.Text = "";
            }
            else
            {
                lblMiss.Text = "Verfehlt!";
                gegnerZug();
            }
        }
        private void angriff2()
        {
            int ad = 15;
            int wahrscheinlichkeit = 2;
            if (probability(wahrscheinlichkeit))
            {
                schadenAnGegner(ref ad);
                lblMiss.Text = "";
            }
            else
            {
                lblMiss.Text = "Verfehlt!";
                gegnerZug();
            }
        }
        private void angriff3()
        {
            int ad = 35;
            int wahrscheinlichkeit = 4;
            if (probability(wahrscheinlichkeit))
            {
                schadenAnGegner(ref ad);
                lblMiss.Text = "";
            }
            else
            {
                lblMiss.Text = "Verfehlt!";
                gegnerZug();
            }
        }
        public bool probability(int wahrscheinlichkeit)
        {
            Random rnd = new Random();
            int Zufall = rnd.Next(1, 10);
            if (Zufall > wahrscheinlichkeit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void yourDeath()
        {
            lblYou.Width = 5;
            if (MessageBox.Show("Sie haben verloren. Möchten Sie von vorne anfangen?",
                       "AdventureTales",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form_Menu restart = new Form_Menu();
                this.Hide();
                restart.Show();
            }
            else
            {
                Application.Exit();
            }

        }
    }
}



