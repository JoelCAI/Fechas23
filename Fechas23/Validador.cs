using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas23
{
    public class Validador
    {
        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public const int cantidad = 1;
        public static void FechaValida(ref string[] arregloFecha)
        {
            /* "05/05/2009" */

            for (int i = 0; i < cantidad; i++)
            {
                string fechaUno;

                do
                {

                    Console.WriteLine(" \n Ingrese la fecha " + (i + 1).ToString() + ": ");
                    Console.WriteLine(" \n El formato válido es: *dd/mm/aaaa hh:mm:ss* ");

                    fechaUno = Console.ReadLine();

                    if (fechaUno == "")
                    {
                        Console.Clear();
                        Console.WriteLine(" \n Ingrese un valor que no sea vacío por favor");
                    }

                } while (fechaUno == "");

                arregloFecha[i] = fechaUno;

            }

            string[] dateStrings = arregloFecha;

            DateTime dateValue;

            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out dateValue))
                    Console.WriteLine(" \n Fecha ingresada válida " +
                                      " \n Usted escribió *{0}* " +
                                      " \n Por lo tanto el sistema lo convirtio correctamente a: *{1}* ", dateString,
                                      dateValue, dateValue.Kind);
                else
                {
                    Console.Clear();
                    Console.WriteLine(" \n Fecha ingresada inválida " +
                                      " \n Ingrese un formato dd/mm/aaaa hh:mm:ss ");
                }
                    

            }

        }


        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }
    }
}
