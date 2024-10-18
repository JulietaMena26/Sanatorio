using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Registro_Clinico
    {
        private int idRegistro { get; set; }
        private int id_paciente { get; set; }
        private int id_medico { get; set; }
        private DateTime fecha { get; set; }
        private DateTime hora { get; set; }
        private string motivo { get; set; }
        private string diagnostico { get; set; }
        private string tratamiento { get; set; }
        private DateTime proxima_visita { get; set; }
        private string observacion { get; set; }
        private bool activo { get; set; }

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
