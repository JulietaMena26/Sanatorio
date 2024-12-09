using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    public class Habitacion
    {
        public int idHabitacion { get; set; }
        public string numero { get; set; }
        public int id_tipo { get; set; }
        public int piso { get; set; }
        public int capacidad { get; set; }
		public int camaOcupada { get; set; } // camas ocupadas
		public string estado { get; set; }
        public decimal precio { get; set; }
        public string comodidad { get; set; }
        public string observacion { get; set; }
        public bool activo { get; set; }

        public Habitacion() { }

        public Habitacion(int idHabitacion, string numero, int id_tipo, int piso, int capacidad, string estado, decimal precio, string comodidad, string observacion, bool activo)
        {
            this.idHabitacion = idHabitacion;
            this.numero = numero;
            this.id_tipo = id_tipo;
            this.piso = piso;
            this.capacidad = capacidad;
            this.camaOcupada = 0; 
            this.estado = estado;
            this.precio = precio;
            this.comodidad = comodidad;
            this.observacion = observacion;
            this.activo = activo;
        }
        public Habitacion( string numero, int id_tipo, int piso, int capacidad, string estado, decimal precio, string comodidad, string observacion, bool activo)
        {
            
            this.numero = numero;
            this.id_tipo = id_tipo;
            this.piso = piso;
            this.capacidad = capacidad;
			this.camaOcupada = 0; 
			this.estado = estado;
            this.precio = precio;
            this.comodidad = comodidad;
            this.observacion = observacion;
            this.activo = activo;
        }
        public override string ToString()
		{
			return $"idhabitacion: {this.idHabitacion}\nid_tipo: {this.id_tipo}\npiso: {this.piso}\ncapacidad: {this.capacidad}\nCama Disponible: ${this.camaOcupada}\n" + 
                   $"estado: {this.estado}\nprecio: {this.precio}\ncomodidad: {this.comodidad}\nobservacion: {this.observacion}\nactivo: {this.activo}";
		}

	}
}
