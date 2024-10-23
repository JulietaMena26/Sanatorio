using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Habitacion
    {
        public int idHabitacion { get; set; }
        public string numero { get; set; }
        public int id_tipo { get; set; }
        public int piso { get; set; }
        public int capacidad { get; set; }
        public string estado { get; set; }
        public double precio { get; set; }
        public string comodidad { get; set; }
        public string observacion { get; set; }
        public bool activo { get; set; }

        public Habitacion() { }

        public Habitacion(int idHabitacion, string numero, int id_tipo, int piso, int capacidad, string estado, double precio, string comodidad, string observacion, bool activo)
        {
            this.idHabitacion = idHabitacion;
            this.numero = numero;
            this.id_tipo = id_tipo;
            this.piso = piso;
            this.capacidad = capacidad;
            this.estado = estado;
            this.precio = precio;
            this.comodidad = comodidad;
            this.observacion = observacion;
            this.activo = activo;
        }
        public Habitacion( string numero, int id_tipo, int piso, int capacidad, string estado, double precio, string comodidad, string observacion, bool activo)
        {
            
            this.numero = numero;
            this.id_tipo = id_tipo;
            this.piso = piso;
            this.capacidad = capacidad;
            this.estado = estado;
            this.precio = precio;
            this.comodidad = comodidad;
            this.observacion = observacion;
            this.activo = activo;
        }
    }
}
