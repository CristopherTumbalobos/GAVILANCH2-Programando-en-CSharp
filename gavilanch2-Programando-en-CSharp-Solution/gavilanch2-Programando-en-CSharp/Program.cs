using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2014, 10, 23);        
            DateTime fechaConHora = new DateTime(2005, 4, 23, 9, 30, 45);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yy"));
            Console.WriteLine(fechaConHora.ToString("dd*MM*yy hh:mm:ss"));
            Console.WriteLine(fecha.AddDays(45).ToString());

            Console.WriteLine(fechaConHora.DayOfWeek);
            Console.WriteLine(fechaConHora.Date);

            Console.WriteLine(fecha.Subtract(fechaConHora).Days);

            Console.Read();
        }
    }
}
