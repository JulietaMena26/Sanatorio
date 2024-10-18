using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class Habitacion
    {
        private int idHabitacion { get; set; }
        private string numero { get; set; }
        private int id_tipo { get; set; }
        private int piso { get; set; }
        private int capacidad { get; set; }
        private string estado { get; set; }
        private double precio { get; set; }
        private string comodidad { get; set; }
        private string observacion { get; set; }
        private bool activo { get; set; }

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
