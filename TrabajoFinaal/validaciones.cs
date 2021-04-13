using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class validaciones
    {
        public bool Vacio(string texto)
        {
            if (texto.Equals(""))
            {
                Console.WriteLine(" La entrada no puede ser VACIO");
                return true;
            }
            else
                return false;
        }
        public bool TipoNumero(string texto)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada no debe ser NUMERICA");
                return false;
            }
        }
        public bool TipoTexto(string texto)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.SetCursorPosition(35,18);
                Console.WriteLine(" La entrada debe ser SOLO TEXTO");
                return false;
       
            }
     
        }

        public bool TipoCorreo(string texto)
        {
            Regex regla = new Regex(@"\A(\w+\.?\w*\@\w+\.)(com)\Z");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine(" La entrada debe ser correo electronico");
                return false;
            }
        }



    }
}


