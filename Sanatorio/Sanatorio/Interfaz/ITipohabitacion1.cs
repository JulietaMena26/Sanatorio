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
        bool agregarHabitacion(TipoHabitacion habi);
        bool actualizarHabitacion(TipoHabitacion habi);
        void eliminarHabitacion(int _id);
        DataTable listarTipoHabitacion();
    }
}
