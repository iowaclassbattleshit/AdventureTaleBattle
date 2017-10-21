using AdventureTaleBattle;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_AdventureTale
{

    public partial class Form_Welt : Form
    {
        Person user;
        Person könig = new Koenig();
        Person bösewicht = new Boesewicht();
        static Person[] personen = new Person[2];
        Label[] labels = new Label[personen.Length];
        
        Label lbl_main;

        private bool _exiting;

        String Klasse;
        System.Drawing.Image Charakter;

        public Form_Welt(Person user)
        {

            this.user = user;
            setzeParameter();
            createlbl_main();
            createPerson(personen);
            KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Move);
            InitializeComponent();
            transparenback();
        }

        private void transparenback()
        {
            lbl_main.Parent = pictureBox1;
            lbl_main.BackColor = Color.Transparent;
            foreach (Label name in labels)
            {
                name.Parent = pictureBox1;
                name.BackColor = Color.Transparent;
            }
        }

        private void createlbl_main()
        {
            lbl_main = new Label();

            lbl_main.Image = user.getImage();
            lbl_main.BackColor = Color.Transparent;
            lbl_main.Height = user.getSizeY();
            lbl_main.Width = user.getSizeX();
            lbl_main.Location = new Point(user.getX(), user.getY());

            this.Controls.Add(lbl_main);

        }

        private void setzeParameter()
        {
            personen[0] = könig;
            personen[1] = bösewicht;
            //personen[2] = user;
        }

        /*private void Form_Welt_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form_Welt_FormClosing);

        }*/
        private void Form_Welt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_exiting && MessageBox.Show("Wollen Sie uns wirklich verlassen?",
                       "AdventureTales",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                Application.Exit();
            }
        }
        public void setchara(String Klasse, Image charakter)
        {
            this.Klasse = Klasse;
            this.Charakter = charakter;
            
            lbl_Klasse.Text = "Klasse: "+Klasse;
        }

        private new void Move(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                lbl_main.Location = new Point(lbl_main.Location.X, lbl_main.Location.Y - 50);
                
            }
            else if (e.KeyCode == Keys.A)
            {
                lbl_main.Location = new Point(lbl_main.Location.X - 50, lbl_main.Location.Y);
            }
            else if (e.KeyCode == Keys.S)
            {
                lbl_main.Location = new Point(lbl_main.Location.X, lbl_main.Location.Y + 50);
            }
            else if (e.KeyCode == Keys.D)
            {
                lbl_main.Location = new Point(lbl_main.Location.X + 50, lbl_main.Location.Y);
            }
            else if (e.KeyCode == Keys.E)
            {
                checkInteraction();
            }
        }
        private void createPerson(Person[] personen)
        {
            int x = 0;
            foreach (Person charakter in personen)
            {
                Label temp = new Label();
                temp.Parent = pictureBox1;
                temp.Location = new Point(charakter.getX(), charakter.getY());
                temp.AutoSize = false;
                temp.Size = new System.Drawing.Size(charakter.getSizeX(), charakter.getSizeY());
                temp.Image = charakter.getImage();
                temp.Show();
                this.Controls.Add(temp);
                labels[x] = temp;

                temp.Name = charakter.getlblName();
                x++;
            }
        }
        private void checkInteraction()
        {
            for (int i = lbl_main.Location.X - 50; i <= lbl_main.Location.X + 50; i += 50){
                for (int j = lbl_main.Location.Y -100; j <= lbl_main.Location.Y+100; j += 100)
                {
                    if (könig.getX() == i && könig.getY() == j)
                    {
                        if (MessageBox.Show(könig.getText(),
                       "AdventureTales",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            lbl_versperrung1.Visible = false;
                            lbl_versperrung2.Visible = false;
                        }
                        else
                        {
                            this.Hide();
                            Form1 kampf = new Form1(könig, user);
                            kampf.Show();
                        }
                    }
                }
            }
            for (int i = lbl_main.Location.X - 50; i <= lbl_main.Location.X + 50; i += 50)
            {
                for (int j = lbl_main.Location.Y - 100; j <= lbl_main.Location.Y + 100; j += 100)
                {
                    if (bösewicht.getX() == i && bösewicht.getY() == j)
                    {
                        this.Hide();
                        Form1 kampf = new Form1(bösewicht, user);
                        kampf.Show();
                    }
                }
            }
        }
    }
}
