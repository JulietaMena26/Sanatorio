using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    public class Dato_Medico
    {
        public int idDato { get; set; }
        public DateTime fechaNac{ get; set; }
        public string horarioAtencion { get; set; }
        public string convenio { get; set; }
        public string observacion { get; set; }
        public int id_medico { get; set; }

        public Dato_Medico() { }

        public Dato_Medico(int idDato, DateTime fechaNac, string horarioAtencion, string convenio, string observacion, int id_medico)
        {
            this.idDato = idDato;
            this.fechaNac = fechaNac;
            this.horarioAtencion = horarioAtencion;
            this.convenio = convenio;
            this.observacion = observacion;
            this.id_medico = id_medico;
        }

        public Dato_Medico( DateTime fechaNac, string horarioAtencion, string convenio, string observacion, int id_medico)
        {
           
            this.fechaNac = fechaNac;
            this.horarioAtencion = horarioAtencion;
            this.convenio = convenio;
            this.observacion = observacion;
            this.id_medico = id_medico;
        }
    }
}
