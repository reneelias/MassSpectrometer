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
        ChargePlate leftPlate, rightPlate;
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

        public ChargePlate LeftPlate
        {
            get { return leftPlate; }
        }

        public ChargePlate RightPlate
        {
            get { return rightPlate; }
        }

        public PlateSystem(bool positiveToNegative, Point leftPosition, Point rightPosition, int plateWidth, int plateHeight, double voltage)
        {
            //Set up a negative multiplier to adapt to whether plates go from positive-to-negative, or negative-to-positive
            int negativeMultiplier = positiveToNegative ? 1 : -1;
            this.leftPlate = new ChargePlate(leftPosition, negativeMultiplier * 88389513119, plateWidth, plateHeight, false);
            this.rightPlate = new ChargePlate(rightPosition, -1 * negativeMultiplier * 88389513119, plateWidth, plateHeight, true);
            this.voltage = voltage;

            //E = V/d
            electricField = negativeMultiplier * voltage / ((rightPlate.Location.X - rightPlate.Width - leftPlate.Location.X) * .00005f);
        }

        public Point StartPosition
        {
            get { return new Point(leftPlate.Location.X + leftPlate.Width, leftPlate.Location.Y + leftPlate.Height / 2); }
        }

        public decimal Acceleration(Particle particle)
        {
            //If particle not within the electric field
            if (!(particle.Location.X >= leftPlate.Location.X + leftPlate.Width && particle.Location.X <= rightPlate.Location.X))
            {
                return 0;
            }
            //F = E*q
            decimal force = (decimal)electricField * particle.Charge;
            //a = F/m
            decimal acceleration = force / particle.Mass;
            return acceleration;
        }

        public void Draw(Graphics gfx)
        {
            leftPlate.Draw(gfx);
            rightPlate.Draw(gfx);
        }
    }
}
