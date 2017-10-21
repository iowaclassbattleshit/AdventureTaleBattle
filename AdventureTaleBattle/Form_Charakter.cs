using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AdventureTale
{
    public partial class Form_Charakter : Form
    {

        private bool _exiting;
        Person chara;
        public Form_Charakter()
        {

            InitializeComponent();

        }

        private void btn_Krieger_Click(object sender, EventArgs e)
        {
            chara = new User("Krieger", Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/krieger.png"));
            initWelt();

        }

        private void btn_Magier_Click(object sender, EventArgs e)
        {
            chara = new User("Magier", Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/mage.png"));
            initWelt();
        }

        private void btn_Assassin_Click(object sender, EventArgs e)
        {
            chara = new User("Assassin", Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/assasin.png"));
            initWelt();
        }
        private void initWelt()
        {
            this.Hide();
            Form_Welt welt = new Form_Welt(chara);
            welt.setchara(chara.getName(), chara.getImage());
            welt.Show();
        }
        private void Form_Charakter_FormClosing(object sender, FormClosingEventArgs e)
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

        /*private void Form_Charakter_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form_Charakter_FormClosing);
        }*/
    }
}
