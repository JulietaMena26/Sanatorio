using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
   public class Medico
    {
        public int idMedico { get; set; }
        public string dni { get; set; }
        public string cuil { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string celular { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public bool activo { get; set; }

		
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
		public override string ToString()
		{
			return $"Médico: {{ idMedico: {idMedico}, " +
				   $"dni: {dni}, " +
				   $"cuil: {cuil}, " +
				   $"apellido: {apellido}, " +
				   $"nombre: {nombre}, " +
				   $"celular: {celular}, " +
				   $"telefono: {telefono}, " +
				   $"direccion: {direccion}, " +
				   $"email: {email}, " +
				   $"activo: {activo} }}";
		}
	}
}
