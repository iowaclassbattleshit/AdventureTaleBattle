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
    public partial class Form_Menu : Form
    {
        Daten daten = new Daten();
        public Form_Menu()
        {
            InitializeComponent();
            lbl_GameTitle.Parent = pBox_Menu;
            lbl_GameTitle.BackColor = Color.Transparent;
        }

        private void btn_Charakter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Charakter charakterErstellung = new Form_Charakter();
            charakterErstellung.Show();
        }

        private void btn_Mitwirkende_Click(object sender, EventArgs e)
        {
            lblMitwirkende.Visible = true;
            lblMitwirkende.Parent = pBox_Menu;
        }
    }
}
