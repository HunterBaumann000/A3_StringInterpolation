using System;

namespace A3___String_Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;
            string tenSpaces = "          ";
            //Console.WriteLine(thisDay);

            // 1. - - - - - -
            Console.Write("1.) ");
            Console.WriteLine(DateTime.Now.ToString("MMMM dd, yyyy")); 

            // 2. - - - - - -
            Console.Write("2.) ");
            Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd"));

            // 3. - - - - - -
            Console.Write("3.) ");
            Console.WriteLine($"Day {thisDay.Day} of {DateTime.Now.ToString("MMMM")}, {thisDay.Year}");

            // 4. - - - - - -
            Console.Write("4.) ");
            Console.WriteLine($"Year: {DateTime.Now.ToString("yyyy")}, Month: {DateTime.Now.ToString("MM")}, Day: {DateTime.Now.ToString("dd")}");  

            // 5. - - - - - -
            Console.Write("5.) ");  
            Console.WriteLine($"{tenSpaces}{DateTime.Now.ToString("dddd")}{tenSpaces}"); 
            
            // 6. - - - - - -
            Console.Write("6.) ");
            Console.WriteLine($"{DateTime.Now.ToString("t")}{tenSpaces}{DateTime.Now.ToString("dddd")}");

            // 7. - - - - - -
            Console.Write("7.) ");
            Console.WriteLine($"h:{DateTime.Now.ToString("hh")}, m:{DateTime.Now.ToString("mm")}, s:{DateTime.Now.ToString("ss")}");

            // 8. - - - - - -
            Console.Write("8.) "); 
            Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd.hh.m.ss"));

            // 9. - - - - - -
            double Pi = 3.14159265359;

            Console.Write("9.) ");
            Console.WriteLine(Pi.ToString("C2"));

            // 10. - - - - - -
            Console.Write("10.) ");
            Console.WriteLine(string.Format("{0,15}", Pi.ToString("C3")));
            // 15 when including string size    ^

            //Console.WriteLine(string.Format("{0,10}", Pi.ToString("C3")));
            // Not including the string's size    ^
        }
    }
}
