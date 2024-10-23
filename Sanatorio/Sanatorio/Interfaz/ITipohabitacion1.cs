using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface ITipohabitacion1
    {
        bool agregarHabitacion(Habitacion habitacion);
        bool actualizarHabitacion(Habitacion habitacion);
        void eliminarHabitacion(string Idhabitacion);
    }
}
