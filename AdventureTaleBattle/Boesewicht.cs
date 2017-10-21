using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AdventureTale
{
    class Boesewicht : Person
    {
        public Boesewicht()
        {
            lblname = "bäse";
            name ="bösewichti";
            dialog= "ich sein böse";
            x=400;
            y=400;
            sizeX = 400;
            sizeY = 400;
            image = Image.FromFile("C:/Users/vmadmin/Desktop/Projekt_AdventureTale/Resources/nito400.gif");
        }
        protected override kampf eventauslösen()
        {
            throw new NotImplementedException();
        }


    }
}
