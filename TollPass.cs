using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportComepanyManagementConsoleVersion
{
    class TollPass
    {

        private double[] euro = new double[6];
        private double truckEuro;
        private double kilometersPassed;
        private double tollPassTax;

        private void Euro()
        {
             this.euro[0] = 0.30;
             this.euro[1] = 0.25;
             this.euro[2] = 0.20;
             this.euro[3] = 0.15;
             this.euro[4] = 0.12;
             this.euro[5] = 0.10;
        }

        public double TruckEuro
        {
            get { return this.truckEuro; }
            set { this.truckEuro = value; }
        }

        public double KilometersPassed
        {
            get { return this.kilometersPassed; }
            set { this.kilometersPassed = value; }
        }

        public TollPass (double truckEuro, double kilometersPassed)
        {
            this.truckEuro = truckEuro;
            this.kilometersPassed = kilometersPassed;
        }

        public double TruckEuro1()
        {
            for (int i = 0; i <= this.truckEuro; i++)
            {
                this.truckEuro = euro[i];
            }
            return this.truckEuro;
        }

        public double TollPassTax()
        {
            this.tollPassTax = kilometersPassed * truckEuro;
            return this.tollPassTax;
        }

        public override string ToString()
        {
            return $"The TollPass tax is: {this.tollPassTax}";
        }

    }
}
