using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }

        public List<Platillo> platillos { get; set; }
        public Menu()
        {
            platillos = new List<Platillo>();
        }
        public Menu(string nombre, string identificador, int horaInicio, int horaFin)
        {
            Nombre = nombre;
            Identificador = identificador;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }
    }
}
