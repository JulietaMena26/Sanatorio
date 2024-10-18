using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class especialidadMedico
    {
          
        private int id_ { get; set; }
        private int id_especialidad { get; set; }
        private int id_medico { get; set; }
        private string matricula { get; set; }

        public especialidadMedico() { }

        public especialidadMedico(int id_, int id_especialidad, int id_medico, string matricula)
        {
            this.id_ = id_;
            this.id_especialidad = id_especialidad;
            this.id_medico = id_medico;
            this.matricula = matricula;
        }

        public especialidadMedico( int id_especialidad, int id_medico, string matricula)
        {
            
            this.id_especialidad = id_especialidad;
            this.id_medico = id_medico;
            this.matricula = matricula;
        }
    }
}
