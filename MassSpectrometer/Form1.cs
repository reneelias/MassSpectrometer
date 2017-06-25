using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassSpectrometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap map;
        Graphics gfx;
        ChargePlate positivePlate, negativePlate;
        PlateSystem system;
        Particle helium;
        MagneticField mField;
        
        /*****EVERY PIXEL IS .00005 METERS!****/

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            gfx = Graphics.FromImage(map);
            mainPictureBox.Image = map;
            mainTimer.Interval = 15;
        }

        double secondsElapsedTime = 0;

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            secondsElapsedTime += 1;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            positivePlate = new ChargePlate(new Point(100, 300), 88389513119, 40, 800, false);
            positivePlate.CenterHeight(mainPictureBox.Height);
            negativePlate = new ChargePlate(new Point(800, 300), -88389513119, 40, 800, true);
            negativePlate.CenterHeight(mainPictureBox.Height);
            system = new PlateSystem(positivePlate, negativePlate, 500);
            helium = new Particle(2, 2, 1, system.StartPosition);
            mField = new MagneticField(negativePlate.Location.X + negativePlate.Width, 0, mainPictureBox.Width - negativePlate.Location.X - negativePlate.Width, mainPictureBox.Height, -1);
            mainTimer.Enabled = true;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);

            decimal acceleration = system.Acceleration(helium);
            if(!helium.Crashed)
            {
                helium.Update(acceleration, 0);
            }
            if (helium.Location.X >= mField.HitBox.X && !helium.MagneticContact)
            {
                //CrossProduct(helium, (decimal)mField.Value);
                helium.MagneticContact = true;
                helium.CalculateCirclePath(mField.Value, system.Voltage);
            }
            if(helium.HitBox.IntersectsWith(negativePlate.HitBox) && helium.MagneticContact)
            {
                helium.Crashed = true;
            }

            //gfx.DrawString(positiveSheet.ElectricField.ToString(), new Font("Calibri", 20), Brushes.IndianRed, new Point(100, 100));
            //gfx.DrawString(helium.VelocityX.ToString(), new Font("Calibri", 20), Brushes.IndianRed, new Point(100, 100));
            if(helium.Crashed)
            {
                Point topPoint = new Point(0, 0), bottomPoint;
                for(int i = helium.CirclePoints.Count - 1; i >= 0; i--)
                {
                    if (helium.CirclePoints[i].X >= negativePlate.Location.X + negativePlate.Width)
                    {
                        topPoint = new Point(helium.CirclePoints[i].X + 4, helium.CirclePoints[i].Y);
                        break;
                    }
                }
                bottomPoint = new Point(helium.CirclePoints[0].X + 4, helium.CirclePoints[0].Y);
                gfx.DrawLine(Pens.IndianRed, topPoint, bottomPoint);
                double diameter = Math.Round(Math.Abs(helium.Radius * 2), 4);
                gfx.DrawString("Diameter: " + diameter + "m", new Font("Calibri", 15), Brushes.IndianRed, new Point(topPoint.X + 4, topPoint .Y + (bottomPoint.Y - topPoint.Y) / 2 ));
            }
            positivePlate.Draw(gfx);
            negativePlate.Draw(gfx);
            helium.Draw(gfx);
            gfx.DrawString("Plate Height: " + (positivePlate.Height * .00005d) + " m", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 50));
            gfx.DrawString("Particle Speed: " + (helium.MagneticContact ? Math.Round(helium.FinalVelocity, 3) : Math.Round(helium.VelocityX, 3)) + " m/s", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 80));
            gfx.DrawString("Particle Charge: " + helium.ChargeString, new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 110));
            gfx.DrawString("Particle Mass: " + helium.MassString + " kg", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 140));
            gfx.DrawString("Distance Between Plates: " + (Math.Round((negativePlate.Location.X - negativePlate.Width - positivePlate.Location.X) * .00005f, 4)).ToString() + " m", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 170));
            gfx.DrawString("Potential Difference Between Plates: " + system.Voltage.ToString() + " J/C", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 200));
            gfx.DrawString("Electric Field Magnitude: " + Math.Round(system.ElectricField, 3).ToString() + " V/m", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 230));
            gfx.DrawString("Magnetic Field Magnitude: " + Math.Round(Math.Abs(mField.Value), 3) + " T", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 260));
            gfx.DrawString("Magnetic Field Direction: " + (mField.Value < 0 ? "Into Page" : "Out of Page"), new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 290));

            mainPictureBox.Image = map;
        }

        //public void CrossProduct(Particle particle, decimal magneticField)
        //{
        //    decimal ForceX = (decimal)helium.VelocityY * magneticField;
        //    decimal ForceY = -(decimal)helium.VelocityX * magneticField;

        //    decimal accelerationX = ForceX / particle.Mass;
        //    decimal accelerationY = ForceY / particle.Mass;
        //    particle.Update(accelerationX, accelerationY);
        //}
    }

}
