using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassSpectrometer
{
    public class ChargePlate
    {
        Point location;
        public Point Location
        {
            get { return location; }
            set { location = value; }
        }
        decimal charge;
        int height;
        public int Height
        {
            get { return height; }
        }
        int width;
        public int Width
        {
            get { return width; }
        }
        TextBox valueBox;
        decimal electricField;
        public decimal ElectricField
        {
            get { return electricField; }
            set { electricField = value; }
        }
        bool gap;

        Rectangle hitbox;
        public Rectangle HitBox
        {
            get { return hitbox; }
        }

        public ChargePlate(Point location, decimal chargeMultiplier, int width, int height, bool gap)
        {
            this.location = location;
            this.charge = chargeMultiplier * .000000000000000000160218m;
            this.width = width;
            this.height = height;
            this.gap = gap;
            electricField = charge / (2 * width * .00005m * height *.00005m * .00000000000854198m);
            hitbox = new Rectangle(location.X, location.Y, width, height);
        }

        public void CenterHeight(int height)
        {
            location.Y = (height - this.height) / 2;
            hitbox.Location = location;
        }

        public void Draw(Graphics gfx)
        {
            if(charge > 0)
            {
                if(gap)
                {
                    gfx.DrawRectangle(Pens.Red, location.X, location.Y, width, height / 2 - 10);
                    gfx.DrawRectangle(Pens.Red, location.X, location.Y + height / 2 + 10, width, height / 2 - 10);
                }
                else
                {
                    gfx.DrawRectangle(Pens.Red, location.X, location.Y, width, height);
                }
                
            }
            else
            {
                if (gap)
                {
                    gfx.DrawRectangle(Pens.Blue, location.X, location.Y, width, height / 2 - 10);
                    gfx.DrawRectangle(Pens.Blue, location.X, location.Y + height / 2 + 10, width, height / 2 - 10);
                }
                else
                {
                    gfx.DrawRectangle(Pens.Blue, location.X, location.Y, width, height);
                }
            }
            
        }
    }
}
