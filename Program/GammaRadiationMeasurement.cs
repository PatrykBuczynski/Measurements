using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class GammaRadiationMeasurement : Measurement, IGenerateHTML
    {
        public double RadiationLevel { set; get; } = 0;

        public GammaRadiationMeasurement(string nameOfTheStation = "No Name!") : base(nameOfTheStation)
        {

        }
        public override void print()
        {
            Console.WriteLine(RadiationLevel);
            base.print();
        }

    }
}
