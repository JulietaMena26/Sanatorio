using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Internacion
    {
        private int idinternacion { get; set; }
        private DateTime fechaIngreso { get; set; }
        private DateTime horaIngreso { get; set; }
        private int id_medico { get; set; }
        private int id_paciente { get; set; }
        private int id_habitacion { get; set; }
        private string motivoInternacion { get; set; }
        private string diagnostico { get; set; }
        private bool deuda { get; set; }
        private string estado { get; set; }
        private DateTime fechaEgreso { get; set; }
        private DateTime horaEgreso { get; set; }
        private bool activo { get; set; }

        public Internacion() { }

        public Internacion(int idinternacion, DateTime fechaIngreso, DateTime horaIngreso, int id_medico, int id_paciente, int id_habitacion, string motivoInternacion, string diagnostico, bool deuda, string estado, DateTime fechaEgreso, DateTime horaEgreso, bool activo)
        {
            this.idinternacion = idinternacion;
            this.fechaIngreso = fechaIngreso;
            this.horaIngreso = horaIngreso;
            this.id_medico = id_medico;
            this.id_paciente = id_paciente;
            this.id_habitacion = id_habitacion;
            this.motivoInternacion = motivoInternacion;
            this.diagnostico = diagnostico;
            this.deuda = deuda;
            this.estado = estado;
            this.fechaEgreso = fechaEgreso;
            this.horaEgreso = horaEgreso;
            this.activo = activo;
        }

        public Internacion( DateTime fechaIngreso, DateTime horaIngreso, int id_medico, int id_paciente, int id_habitacion, string motivoInternacion, string diagnostico, bool deuda, string estado, DateTime fechaEgreso, DateTime horaEgreso, bool activo)
        {
            
            this.fechaIngreso = fechaIngreso;
            this.horaIngreso = horaIngreso;
            this.id_medico = id_medico;
            this.id_paciente = id_paciente;
            this.id_habitacion = id_habitacion;
            this.motivoInternacion = motivoInternacion;
            this.diagnostico = diagnostico;
            this.deuda = deuda;
            this.estado = estado;
            this.fechaEgreso = fechaEgreso;
            this.horaEgreso = horaEgreso;
            this.activo = activo;
        }
    }
}
