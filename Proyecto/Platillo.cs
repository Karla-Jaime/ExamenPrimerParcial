using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Platillo
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        private float _Precio;
        public float Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                if (Precio == 50 || Precio > 50)
                {
                    Precio = value;
                }
                else if (Precio < 50)
                {
                    _Precio = value + 50;
                }
            }
        }

        public List<Ingrediente> ingredientes { get; set; }

        public Platillo (string identificador,string nombre, string descripcion, float precio)
        {
            Identificador = identificador;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }
        public Platillo()
        {
            ingredientes = new List<Ingrediente>();
        }
        
    }
}
