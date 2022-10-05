using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando la clase "Persona"
            Persona p = new Persona();
            p.Nombre = "Lorena";
            p.Edad = 35;
            p.Direccion = "Avenida Siempre Viva";
            p.MostrarDatosEnConsola();

            //Instanciando la clase "Persona"
            Persona p2 = new Persona();
            p2.Nombre = "Mario";
            p2.Edad = 19;
            p2.Direccion = "Av. Winston Churchill";
            p2.MostrarDatosEnConsola();

            Console.Read();
        }

        class Persona
        {
            public string Nombre;
            public int Edad;
            public string Direccion;

            public void MostrarDatosEnConsola()
            {
                string output = "El nombre es {0}, la edad es {1} y su dirección es {2}";
                output = string.Format(output, Nombre, Edad, Direccion);
                Console.WriteLine(output);
            }
        }

    }

    /*
    class Carro
    {
        public string Modelo;
        public int Anio;
        public decimal Precio;
        //...(Más variables)

        public void Encender()
        {
            //Codigo que enciende el carro
        }
        //...(más métodos)
    }
    */

    /*
    class Factura
    {
        public int Id;
        public DateTime Creacion;
        public decimal Total;
        public string Cliente;
        public string Facturador;
        //...Otras variables (atributos)
    }

    class ProcesarFactura
    {
        public void Reversar (int Id)
        {
            // Codigo reversa de una factura
        }

        public Factura ConsolidarFacturasPendientes()
        {
            // Codigo ConsolidaFacturas
        }

        //...Otros metodos
    }

    class RepositorioFacturas
    {
        public Factura ObtenerPorId(int Id)
        {
            // Codigo obtiene factura por Id
        }

        public void Guardar(Factura factura)
        {
            // Codigo guarda factura en una BD
        }

        // ... Otros metodos
    }
    */
}
