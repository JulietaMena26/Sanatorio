using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IHabitacion1
    {
        Habitacion buscarHabitacionNumero(string numero);
        Habitacion buscarHabitacionPiso(int piso);
        List<Habitacion> listadoHabitacionTipo(int idHabitacion);
        List<Habitacion> listarHabitacion();
    }
}
