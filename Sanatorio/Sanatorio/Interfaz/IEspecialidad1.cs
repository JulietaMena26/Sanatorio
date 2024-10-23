using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    public interface IEspecialidad1
    {
        bool agregarEspecialidad(Especialidad especialidad);
        bool actualizarEspecialidad(Especialidad especialidad);
        void eliminarEspecialidad(string especialidad);
        Especialidad buscarEspecialidadId(int id);
        DataTable buscarEspecialidad(string Especialidad);
        DataTable listarEspecialidad();
    }
}
