using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Ingrediente
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Ingrediente()
        {
            Nombre = "Carne";
            Identificador = "Res";
        }

        public Ingrediente(string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
        }
    }
}
