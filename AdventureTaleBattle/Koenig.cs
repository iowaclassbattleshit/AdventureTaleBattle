using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AdventureTale
{
    class Koenig : Person
    {
        
        public Koenig()
        {
            lblname = "lbl_könig";
            name = "König Sonnenbrand";
            dialog = "Banditen haben angegriffen, Ich belohne Sie wenn Sie sie töten";
            x = 50;
            y = 100;
            //dialog = "Töte die Banditen und ich belohne Sie!";
            image = Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/king2.png");
        }
        protected override kampf eventauslösen()
        {
            throw new NotImplementedException();
        }




        
    }
}
