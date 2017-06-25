using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassSpectrometer
{
    public class Particle
    {
        decimal mass;
        public decimal Mass
        {
            get { return mass; }
        }
        public string MassString
        {
            get
            {
                string massString = (mass / .0000000000000000000000000001m).ToString() + "E-28";
                return massString;
            }
        }

        decimal charge;
        public decimal Charge
        {
            get { return charge; }
        }
        public string ChargeString
        {
            get
            {
                string chargeString = (charge / .000000000000000000160218m).ToString() + 'e';
                return chargeString;
            }
        }

        Point location;
        public Point Location
        {
            get { return location; }
        }

        double velocityX;
        public double VelocityX
        {
            get { return velocityX * 15000; }
            set { velocityX = value; }
        }

        double velocityY;
        public double VelocityY
        {
            get { return velocityY * 15000; }
            set { velocityY = value; }
        }

        Rectangle hitbox;
        public Rectangle HitBox
        {
            get { return hitbox; }
        }

        bool magneticContact;
        public bool MagneticContact
        {
            get { return magneticContact; }
            set {  magneticContact = value; }
        }

        double degreeStep;
        double currentDegree;
        double finalVelocity;
        public double FinalVelocity
        {
            get { return finalVelocity; }
        }
        double finalScaleVelocity;
        double radius;
        public double Radius
        {
            get { return radius; }
        }

        bool crashed;
        public bool Crashed
        {
            get { return crashed; }
            set { crashed = value; }
        }
        List<Point> circlePoints;
        public List<Point> CirclePoints
        {
            get { return circlePoints; }
        }

        public Particle(decimal protons, decimal neutrons, decimal electrons, Point startLocation)
        {
            mass += (protons + neutrons) * .0000000000000000000000000017m;
            mass += electrons * .0000000000000000000000000000091m;
            charge += protons * .000000000000000000160218m;
            charge -= electrons * .000000000000000000160218m;
            velocityX = 0;
            velocityY = 0;
            location = startLocation;
            hitbox = new Rectangle(location.X, location.Y, 16, 16);
            magneticContact = false;
            crashed = false;
        }

        public void Update(decimal accelerationX, decimal accelerationY)
        {
            if(!magneticContact)
            {
                velocityX += ((double)accelerationX * 15 / 1000) / 100000000000;
                velocityY += ((double)accelerationY * 15 / 1000) / 100000000000;
            }
            else
            {
                currentDegree += degreeStep;
                velocityX = (finalScaleVelocity * Math.Cos(currentDegree));
                velocityY = (finalScaleVelocity * Math.Sin(currentDegree));
            }

            location.X += (int)velocityX;
            location.Y += (int)velocityY;

            if(circlePoints != null)
            {
                circlePoints.Add(location);
            }

            hitbox.X = location.X;
            hitbox.Y = location.Y;
        }

        public void Draw(Graphics gfx)
        {
            if (circlePoints != null)
            {
                foreach(Point point in circlePoints)
                {
                    gfx.FillEllipse(Brushes.Black, point.X, point.Y, 4, 4);
                }
            }
            if(charge > 0)
            {
                gfx.FillEllipse(Brushes.Red, location.X, location.Y - 8, hitbox.Width, hitbox.Height);
            }
            else
            {
                gfx.FillEllipse(Brushes.Blue, location.X, location.Y - 8, hitbox.Width, hitbox.Height);
            }
          
        }

        public void CalculateCirclePath(double magneticValue, double voltage)
        {
            finalVelocity = Math.Sqrt((double)((2m * (decimal)voltage * charge) / mass));
            finalScaleVelocity = finalVelocity / 15000;
            radius = (double)((mass * (decimal)finalVelocity) / (Math.Abs(charge) * (decimal)magneticValue));
            double distanceToCover = 2 * Math.PI * Math.Abs(radius);
            double timeToCover = distanceToCover / (finalScaleVelocity * .00005);
            degreeStep = (2 * Math.PI) / timeToCover;
            if(radius < 0)
            {
                degreeStep = -degreeStep;
            }
            degreeStep *= (double)(charge / charge);
            currentDegree = 0;
            circlePoints = new List<Point>();
            circlePoints.Add(location);
        }
    }
}
