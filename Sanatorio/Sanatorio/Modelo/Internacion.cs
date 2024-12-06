using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    public class Internacion
    {
        public int idinternacion { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime horaIngreso { get; set; }
        public int id_medico { get; set; }
        public int id_paciente { get; set; }
        public int id_habitacion { get; set; }
        public string motivoInternacion { get; set; }
        public string diagnostico { get; set; }
        public bool deuda { get; set; }
        public string estado { get; set; }
        public DateTime? fechaEgreso { get; set; }
        public DateTime? horaEgreso { get; set; }
        public bool activo { get; set; }

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
