using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //==========Static field==============
            Console.WriteLine("Number of saved measurements:" + Measurement.NoOfMeasurements);
            //=========Inheritance================
            GammaRadiationMeasurement gammacheck1=new GammaRadiationMeasurement("CLOR GAMMA1");
            GammaRadiationMeasurement gammacheck2=new GammaRadiationMeasurement("CLOR GAMMA2");
            AirPollutionMeasurement polutioncheck1=new AirPollutionMeasurement("CLOR AIR POLLUTION");
            //==========Staticfield==============
            Console.WriteLine("Number of saved measurements:"+Measurement.NoOfMeasurements);
            //========Properties===================
            gammacheck1.RadiationLevel=0.002;
            gammacheck2.RadiationLevel=0.04;
            polutioncheck1.PM2_5=22;
            polutioncheck1.PM10=132;
            Measurement[] CLORmeasurements=new Measurement[3];
            CLORmeasurements[0]=gammacheck1;
            CLORmeasurements[1]=gammacheck2;
            CLORmeasurements[2]=polutioncheck1;
            Random rnd=new Random();
            foreach(Measurement check in CLORmeasurements)
            {
                //----------Measurementsimulation---------
                double temperature=rnd.NextDouble()*50-10;
                double presseure=rnd.Next(950,1200);
                double humidity=rnd.Next(0,100);
                //-----------------------------------------

                //===========Indexer+enum=============
                check[(int)Measurement.MeasurementsConditions.Temperature]=temperature;
                check[Measurement.MeasurementsConditions.Pressure]=presseure; //Dlaczego to nie działa a to wyżej działa?
                check[Measurement.MeasurementsConditions.Humidity]=humidity;
                check.Print();
            }
            //========================================================
            Console.WriteLine("\n*****HTMLPRINTING******\n");
            //============interfejsy=================================
            Report report = new Report();
            PrintToHTML(report);
            PrintToHTML(CLORmeasurements[1]);
            PrintToHTML(CLORmeasurements[2]);
            Console.ReadKey();
        }
        static void PrintToHTML(IGenerateHTML objectToPrint)
        {
            objectToPrint.GenerateHTML(); 
        }
    }
}
