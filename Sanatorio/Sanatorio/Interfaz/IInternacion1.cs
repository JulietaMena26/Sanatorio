using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Interfaz
{
    public interface IInternacion1
    {
        bool guardarInternacion(Internacion internacion);
        bool actualizarInternacion(Internacion internacion);
        void eliminarInternacion(int id);
        DataTable buscarFechaIngreso(DateTime fecha);
        DataTable buscarFechaIngreso(DateTime ingreso, DateTime egreso);
        DataTable buscarFechaEgreso(DateTime fecha);
        DataTable buscarPaciente(int id);
        DataTable buscarMedico(int id);
        DataTable listarInternacion(string cTexto,string _estado);
		Internacion buscarInternacionId(int id);
		bool isInternadoPaciente(int idPaciente);
        bool altaInternacion(int id_);

	}
}
