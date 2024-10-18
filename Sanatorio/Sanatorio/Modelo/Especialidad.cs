using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Especialidad
    {
        private int idEspecialidad { get; set; }
        private string especialidad { get; set; }
        private string descripcion { get; set; }

        public Especialidad() { }

        public Especialidad(int idEspecialidad, string especialidad, string descripcion)
        {
            this.idEspecialidad = idEspecialidad;
            this.especialidad = especialidad;
            this.descripcion = descripcion;
        }

        public Especialidad(string especialidad, string descripcion)
        {
            
            this.especialidad = especialidad;
            this.descripcion = descripcion;
        }
    }
}
