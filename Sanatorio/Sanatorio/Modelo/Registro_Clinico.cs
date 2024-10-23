using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Registro_Clinico
    {
        public int idRegistro { get; set; }
        public int id_paciente { get; set; }
        public int id_medico { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string motivo { get; set; }
        public string diagnostico { get; set; }
        public string tratamiento { get; set; }
        public DateTime proxima_visita { get; set; }
        public string observacion { get; set; }
        public bool activo { get; set; }

        public Registro_Clinico() { }

        public Registro_Clinico(int idRegistro, int id_paciente, int id_medico, DateTime fecha, DateTime hora, string motivo, string diagnostico, string tratamiento, DateTime proxima_visita, string observacion, bool activo)
        {
            this.idRegistro = idRegistro;
            this.id_paciente = id_paciente;
            this.id_medico = id_medico;
            this.fecha = fecha;
            this.hora = hora;
            this.motivo = motivo;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.proxima_visita = proxima_visita;
            this.observacion = observacion;
            this.activo = activo;
        }

        public Registro_Clinico( int id_paciente, int id_medico, DateTime fecha, DateTime hora, string motivo, string diagnostico, string tratamiento, DateTime proxima_visita, string observacion, bool activo)
        {
            
            this.id_paciente = id_paciente;
            this.id_medico = id_medico;
            this.fecha = fecha;
            this.hora = hora;
            this.motivo = motivo;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.proxima_visita = proxima_visita;
            this.observacion = observacion;
            this.activo = activo;
        }
    }
}
