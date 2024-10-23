using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class EspecialidadMedico
    {

        public int id_ { get; set; }
        public int id_especialidad { get; set; }
        public int id_medico { get; set; }
        public string matricula { get; set; }

        public EspecialidadMedico() { }

        public EspecialidadMedico(int id_, int id_especialidad, int id_medico, string matricula)
        {
            this.id_ = id_;
            this.id_especialidad = id_especialidad;
            this.id_medico = id_medico;
            this.matricula = matricula;
        }

        public EspecialidadMedico( int id_especialidad, int id_medico, string matricula)
        {
            
            this.id_especialidad = id_especialidad;
            this.id_medico = id_medico;
            this.matricula = matricula;
        }
    }
}
