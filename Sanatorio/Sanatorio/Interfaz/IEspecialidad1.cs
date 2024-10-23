using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IEspecialidad1
    {
        bool agregarEspecialidad(Especialidad especialidad);
        bool actualizarEspecialidad(Especialidad especialidad);
        void eliminarEspecialidad(string especialidad);
        Medico buscarEspecialidad(string Especialidad);
        Medico buscarEspecialidadId(int idEspecialidad);

        List<Medico> listadoMedicoApellido(string especialidad);
        List<Medico> listarEspecialidad();
    }
}
