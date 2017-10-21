using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AdventureTale
{
    class User : Person
    {
        public User(String klasse, System.Drawing.Image image)
        {
            this.lblname = "lbl_main";
            this.name = klasse;
            this.image = image;
            x = 700;
            y = 150;
        }
        protected override kampf eventauslösen()
        {
            throw new NotImplementedException();
        }
    }
}
