using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class datosMedico
    {
        private int idDato { get; set; }
        private DateTime fechaNac{ get; set; }
        private string horarioAtencion { get; set; }
        private string convenio { get; set; }
        private string observacion { get; set; }
        private int id_medico { get; set; }

        public datosMedico() { }

        public datosMedico(int idDato, DateTime fechaNac, string horarioAtencion, string convenio, string observacion, int id_medico)
        {
            this.idDato = idDato;
            this.fechaNac = fechaNac;
            this.horarioAtencion = horarioAtencion;
            this.convenio = convenio;
            this.observacion = observacion;
            this.id_medico = id_medico;
        }

        public datosMedico( DateTime fechaNac, string horarioAtencion, string convenio, string observacion, int id_medico)
        {
           
            this.fechaNac = fechaNac;
            this.horarioAtencion = horarioAtencion;
            this.convenio = convenio;
            this.observacion = observacion;
            this.id_medico = id_medico;
        }
    }
}
