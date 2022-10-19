using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SumaDesdeProgram(1, 3); //SumaDesdeProgram no es static

            var p = new Program();
            p.SumaDesdeProgram(1, 2);

            Program.SumaDesdeProgram(1, 3); //SumaDesdeProgram no es static

            Matematicas.SumaDesdeMatematicas(1, 3);

            var factura = new Factura();
            factura.SumaDesdeFactura(1, 2);
            Factura.SumaDesdeFactura(1, 2);

            //Cuando SI es static podemos acceder desde la clase.metodo, no podemos instanciarla
            //Cuando NO es static podemos acceder a partir de un instancia

        }
        public int SumaDesdeProgram(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
    }

    static class Matematicas
    {
        const double PI = 3.1415;
        public static int SumaDesdeMatematicas (int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        public static double AreaDelCirculo(int radio)
        {
            return radio * radio * PI;
        }
    }

    class Factura //Decidimos que no sea estatica porque requiere almacenar data, para cada factura
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public static int SumaDesdeFactura(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
    }

    class FacturaRepositorio
    {
        public void GuardarEnBaseDeDatos(Factura factura)
        {
            // Codigo para guardar la factura en base de datos
        }
    }
}