using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Measurement : IGenerateHTML
    {
        string stationName;
        DateTime date;
        double[] conditions = new double[3];
        static int noOfMeasurements = 0;
        public Measurement(string nameOfTheStation = "No Name!")
        {
            date = DateTime.Now;
            for (int i = 0; i < 3; i++)
            {
                conditions[i] = 0;
            }
            noOfMeasurements++;
        }
        ~Measurement()
        {
            noOfMeasurements--;
        }
        public virtual void print()
        {
            string dateInString = date.ToString();
            Console.WriteLine(dateInString + " " + conditions[(int)MeasurementsConditions.Temperature] + " " + conditions[(int)MeasurementsConditions.Pressure] + " " + conditions[(int)MeasurementsConditions.Humidity]);

        }
        public enum MeasurementsConditions { Temperature = 0, Pressure = 1, Humidity = 2 };

        public double this[MeasurementsConditions pos]
        {
            get
            {
                return conditions[(int)pos];
            }
            set
            {
                conditions[(int)pos] = value;
            }
        }
        public int NoOfMeasurements 
        {
            get 
            {
                return noOfMeasurements;
            }
        }
        public string ToHTMLString() 
        {
            return ("<font color = 'red' > =========POMIAR========= </font> <br />" + "\n" +
                "Station name: " + stationName + ", time of measurement:"  );
        }
        public void generateHTML() 
        {

        }


    }

}
