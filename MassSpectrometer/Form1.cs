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
        PlateSystem system;
        Particle particle;
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
            system = new PlateSystem(positiveCheckBox.Checked, new Point(100, 300), new Point(800, 300), 40, 800, double.Parse(voltageTextBox.Text));
            system.RightPlate.CenterHeight(mainPictureBox.Height);
            system.LeftPlate.CenterHeight(mainPictureBox.Height);
            //protons, neutrons, electrons
            particle = new Particle(int.Parse(protonsTextBox.Text), int.Parse(neutronsTextBox.Text), int.Parse(electronsTextBox.Text), system.StartPosition);
            mField = new MagneticField(system.RightPlate.Location.X + system.RightPlate.Width, 0, mainPictureBox.Width - system.RightPlate.Location.X - system.RightPlate.Width, mainPictureBox.Height, double.Parse(magneticFieldTextBox.Text));
            mainTimer.Enabled = true;
        }

        private void mainPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);

            decimal acceleration = system.Acceleration(particle);
            if(!particle.Crashed)
            {
                particle.Update(acceleration, 0);
                if(particle.Location.X < system.LeftPlate.Location.X + system.LeftPlate.Width)
                {
                    particle.Location = new Point(system.LeftPlate.Location.X + system.LeftPlate.Width, particle.Location.Y);
                }
            }
            if (particle.Location.X >= mField.HitBox.X && !particle.MagneticContact)
            {
                //CrossProduct(helium, (decimal)mField.Value);
                particle.MagneticContact = true;
                particle.CalculateCirclePath(mField.Value, system.Voltage);
            }
            if((particle.HitBox.IntersectsWith(system.RightPlate.HitBox) ||
                particle.Location.X < system.RightPlate.Location.X) && particle.MagneticContact)
            {
                particle.Crashed = true;
            }

            //gfx.DrawString(positiveSheet.ElectricField.ToString(), new Font("Calibri", 20), Brushes.IndianRed, new Point(100, 100));
            //gfx.DrawString(helium.VelocityX.ToString(), new Font("Calibri", 20), Brushes.IndianRed, new Point(100, 100));
            if(particle.Crashed)
            {
                Point topPoint = new Point(0, 0), bottomPoint;
                for(int i = particle.CirclePoints.Count - 1; i >= 0; i--)
                {
                    if (particle.CirclePoints[i].X >= system.RightPlate.Location.X + system.RightPlate.Width)
                    {
                        topPoint = new Point(particle.CirclePoints[i].X + 4, particle.CirclePoints[i].Y);
                        break;
                    }
                }
                bottomPoint = new Point(particle.CirclePoints[0].X + 4, particle.CirclePoints[0].Y);
                gfx.DrawLine(Pens.IndianRed, topPoint, bottomPoint);
                double diameter = Math.Round(Math.Abs(particle.Radius * 2), 4);
                gfx.DrawString("Diameter: " + diameter + "m", new Font("Calibri", 15), Brushes.IndianRed, new Point(topPoint.X + 4, topPoint .Y + (bottomPoint.Y - topPoint.Y) / 2 ));
            }

            //Drawing
            system.Draw(gfx);
            particle.Draw(gfx);
            gfx.DrawString("Plate Height: " + (system.RightPlate.Height * .00005d) + " m", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 50));
            gfx.DrawString("Particle Speed: " + (particle.MagneticContact ? Math.Round(particle.FinalVelocity, 3) : Math.Round(particle.VelocityX, 3)) + " m/s", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 80));
            gfx.DrawString("Particle Charge: " + particle.ChargeString, new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 110));
            gfx.DrawString("Particle Mass: " + particle.MassString + " kg", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 140));
            gfx.DrawString("Distance Between Plates: " + (Math.Round((system.RightPlate.Location.X - system.RightPlate.Width - system.LeftPlate.Location.X) * .00005f, 4)).ToString() + " m", new Font("Calibri", 15), Brushes.IndianRed, new Point(1150, 170));
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
