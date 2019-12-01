using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Report : IGenerateHTML
    {
        public string ToHTMLString()
        {
            return ("<p> This is a placeholder for the report.</p>");
        }
        public void GenerateHTML()
        {
            Console.WriteLine(ToHTMLString());
        }
    }
}
