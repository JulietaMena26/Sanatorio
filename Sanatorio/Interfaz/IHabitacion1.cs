using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    public interface IHabitacion1
    {
        bool agregarHabitacion(Habitacion habitacion);
        bool actualizarHabitacion(Habitacion habitacion);
        bool eliminar(int id_);
        Habitacion buscarHabitacionNumero(string numero);
        Habitacion buscarHabitacionPiso(int piso);
        List<Habitacion> listadoHabitacionTipo(int idHabitacion);
        DataTable listarHabitacion();
		DataTable listarHabitacionDisponible();
        void ocuparCama(int idHabitacion);
        void liberarCama(int idHabitacion);

	}
}
