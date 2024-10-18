using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class TipoHabitacion
    {
        private int idTipo { get; set; }
        private string descripcion { get; set; }

        public TipoHabitacion() { }

        public TipoHabitacion(int idTipo, string descripcion)
        {
            this.idTipo = idTipo;
            this.descripcion = descripcion;
        }

        public TipoHabitacion( string descripcion)
        {
            
            this.descripcion = descripcion;
        }
    }
}
