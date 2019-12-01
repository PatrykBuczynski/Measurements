using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class AirPollutionMeasurement : Measurement, IGenerateHTML
    {
        public double PM2_5 { set; get; } = 0;
        public double PM10 { set; get; } = 0;

        public AirPollutionMeasurement(string nameOfTheStation = "No Name!") : base(nameOfTheStation)
        {

        }
        public override void print()
        {
            Console.WriteLine(PM2_5 + " " + PM10);
            base.print();
        }


    }
}
