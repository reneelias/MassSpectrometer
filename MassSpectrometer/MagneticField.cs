using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassSpectrometer
{
    class MagneticField
    {
        int width;
        int height;
        double value;
        public double Value
        {
            get { return value; }
        }
        int direction;
        Rectangle hitbox;
        public Rectangle HitBox
        {
            get { return hitbox; }
        }


        public MagneticField(int x, int y, int width, int height, double value)
        {
            this.width = width;
            this.height = height;
            this.value = value;
            hitbox = new Rectangle(x, y, width, height);
        }


    }
}
