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
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Radiation level: " + RadiationLevel);
        }

        public new string ToHTMLString() 
        {
            return base.ToHTMLString();
        }
        public new void GenerateHTML() 
        {
            Console.WriteLine(ToHTMLString());
        }

    }
}
