using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = "Felipe";
            string nombreMayuscula = "FELIPE";

            //Console.WriteLine(nombre.ToUpper() == nombreMayuscula.ToUpper());

            ////Length: Calcula la longitud del string
            //Console.WriteLine(nombre.Length);
            //Console.WriteLine(frase.Length);

            ////Substring: Obtener un string a partir de otro string
            //Console.WriteLine(nombre.Substring(3));
            //Console.WriteLine(frase.Substring(7, 4));

            ////StartsWith: Para verificar si el string empieza con una subcadena determinada
            //Console.WriteLine(frase.StartsWith("Juan"));
            //Console.WriteLine(frase.StartsWith("Jose"));

            ////EndsWith: Para verificar si el string termina con una subcadena en especifico
            //Console.WriteLine(frase.EndsWith("amigos"));
            //Console.WriteLine(frase.EndsWith("enemigos"));

            ////Contains: Para verificar si una subcadena está contenida en un string
            //Console.WriteLine(frase.Contains("Jose"));
            //Console.WriteLine(frase.Contains("Pedro"));

            string frase = "Juan y Jose son amigos";

            ////IndexOf: A partir de cual se encuentra una determinada subcadena
            //var indiceDeJose = frase.IndexOf("Jose");
            //var indiceDePedro = frase.IndexOf("Pedro");

            //-1: Valor cuando no existe o no se encuentra

            //Console.WriteLine(indiceDeJose);
            //Console.WriteLine(indiceDePedro);

            //operador + : Concatenar strings 
            //Console.WriteLine(nombre + ", " + frase);

            //ToLower: Colocar en minuscula 
            //Console.WriteLine(frase.ToLower());

            //ToUpper: Colocar en mayuscula
            //Console.WriteLine(frase.ToUpper());

            //Trim: Elimina los espacios vacios al inicio y al final
            //string ejemploTrim = " Felipe ";
            //Console.WriteLine(ejemploTrim);
            //Console.WriteLine(ejemploTrim.Trim());
            //Console.WriteLine(nombre == ejemploTrim);
            //Console.WriteLine(nombre == ejemploTrim.Trim());

            //Format: Sustituciones de subcadenas especiales dentro de un string
            //string ejemploFormat = "Felicidades {0} en tu cumpleaños {1}! {0}";
            //var resultadoFormat = string.Format(ejemploFormat, nombre, 50);
            //Console.WriteLine(resultadoFormat);

            //Replace: Reemplazos dentro de un string con sintaxis más amigable
            string ejemploReplace = "Felicidades @nombre en tu cumpleaños número @edad! @nombre";

            var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            resultadoReplace = resultadoReplace.Replace("@edad", "50");
            Console.WriteLine(resultadoReplace);

            //IsNullOrWhiteSpace: Verifica si un string es nulo o consiste solo en espacios en blanco
            string stringEspaciosEnBlanco = "      ";
            string stringNulo = null;
            Console.WriteLine(string.IsNullOrWhiteSpace(stringEspaciosEnBlanco));
            Console.WriteLine(string.IsNullOrWhiteSpace(stringNulo));
            Console.WriteLine(string.IsNullOrWhiteSpace(nombre));

            Console.Read();
        }
    }
}
