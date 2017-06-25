using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassSpectrometer
{
    public class PlateSystem
    {
        ChargePlate leftSheet, rightSheet;
        double voltage;
        public double Voltage
        {
            get { return voltage; }
        }
        double electricField;
        public double ElectricField
        {
            get { return electricField; }
        }

        public PlateSystem(ChargePlate leftSheet, ChargePlate rightSheet, double voltage)
        {
            this.leftSheet = leftSheet;
            this.rightSheet = rightSheet;
            this.voltage = voltage;
            electricField = voltage / ((rightSheet.Location.X - rightSheet.Width - leftSheet.Location.X) * .00005f);
        }

        public Point StartPosition
        {
            get { return new Point(leftSheet.Location.X + leftSheet.Width, leftSheet.Location.Y + leftSheet.Height / 2); }
        }

        public decimal Acceleration(Particle particle)
        {
            if(!(particle.Location.X >= leftSheet.Location.X + leftSheet.Width && particle.Location.X <= rightSheet.Location.X))
            {
                return 0;
            }
            decimal force = (decimal)electricField * particle.Charge;
            decimal acceleration = force / particle.Mass;
            return acceleration;
        }
    }
}
