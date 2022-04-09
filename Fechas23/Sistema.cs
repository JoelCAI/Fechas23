using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas23
{
    public class Sistema
    {
        public void MenuPrincipal()
        {

            string[] arregloFecha = new string[cantidad];

            Validador.Bienvenida();

            Validador.FechaValida(ref arregloFecha);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }

        public static int cantidad = 1;


    }
}
