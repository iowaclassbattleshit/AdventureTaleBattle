using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AdventureTale
{
    public abstract class Person
    {
        protected string lblname;
        protected int x;
        protected int y;
        protected String dialog;
        protected string name;
        protected System.Drawing.Color color = System.Drawing.Color.Transparent;
        protected System.Drawing.Image image;
        
        protected int sizeY = 100;
        protected int sizeX = 50;

        protected abstract kampf eventauslösen();


        public String textausgabe()
        {
            return dialog;
        }
        public void setText(String text)
        {
            dialog = text;
        }
        public System.Drawing.Image getImage()
        {
            return image;
        }
        public String getText()
        {
            return dialog;
        }
        protected void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        protected void setX(int x)
        {
            this.x = x;
        }
        protected void setY(int y)
        {
            this.y = y;
        }
        public int getSizeX()
        {
            return sizeX;
        }
        public int getSizeY()
        {
            return sizeY;
        }
        public System.Drawing.Color getColor()
        {
            return color;
        }

        public string getlblName()
        {
            return lblname;
        }
    }
}
