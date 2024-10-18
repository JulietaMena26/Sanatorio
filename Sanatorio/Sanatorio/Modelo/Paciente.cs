using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Paciente
    {
        private int idPaciente { get; set; }
        private string dni { get; set; }
        private string apellido { get; set; }
        private string nombre { get; set; }
        private DateTime fechaNaci { get; set; }
        private string domicilio { get; set; }
        private string telefono { get; set; }
        private string historiaClinica { get; set; }
        private int id_obraSocial { get; set; }
        private string afiliado { get; set; }
        private bool activo { get; set; }

        public Paciente() { }

        public Paciente(int idPaciente, string dni, string apellido, string nombre, DateTime fechaNaci, string domicilio, string telefono, string historiaClinica, int id_obraSocial, string afiliado, bool activo)
        {
            this.idPaciente = idPaciente;
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.fechaNaci = fechaNaci;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.historiaClinica = historiaClinica;
            this.id_obraSocial = id_obraSocial;
            this.afiliado = afiliado;
            this.activo = activo;
        }

        public Paciente(string dni, string apellido, string nombre, DateTime fechaNaci, string domicilio, string telefono, string historiaClinica, int id_obraSocial, string afiliado, bool activo)
        {
            
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.fechaNaci = fechaNaci;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.historiaClinica = historiaClinica;
            this.id_obraSocial = id_obraSocial;
            this.afiliado = afiliado;
            this.activo = activo;
        }
    }
}
