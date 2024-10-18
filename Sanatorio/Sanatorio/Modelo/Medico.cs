using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Medico
    {
        private int idMedico { get; set; }
        private string dni { get; set; }
        private string cuil { get; set; }
        private string apellido { get; set; }
        private string nombre { get; set; }
        private string celular { get; set; }
        private string telefono { get; set; }
        private string direccion { get; set; }
        private string email { get; set; }
        private bool activo { get; set; }

        public Medico() { }

        public Medico(int idMedico, string dni, string cuil, string apellido, string nombre, string celular, string telefono, string direccion, string email, bool activo)
        {
            this.idMedico = idMedico;
            this.dni = dni;
            this.cuil = cuil;
            this.apellido = apellido;
            this.nombre = nombre;
            this.celular = celular;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.activo = activo;
        }

        public Medico( string dni, string cuil, string apellido, string nombre, string celular, string telefono, string direccion, string email, bool activo)
        {
            
            this.dni = dni;
            this.cuil = cuil;
            this.apellido = apellido;
            this.nombre = nombre;
            this.celular = celular;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.activo = activo;
        }
    }
}
