using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    public interface ITipoHabitacion1
    {
        bool agregarHabitacion(Habitacion habitacion);
        bool actualizarHabitacion(Habitacion habitacion);
        void eliminarHabitacion(string Idhabitacion);
        DataTable listarTipoHabitacion();
    }
}
