using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    public class Paciente
    {
        public int idPaciente { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNaci { get; set; }
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string historiaClinica { get; set; }
        public int id_obraSocial { get; set; }
        public string afiliado { get; set; }
        public bool activo { get; set; }

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
