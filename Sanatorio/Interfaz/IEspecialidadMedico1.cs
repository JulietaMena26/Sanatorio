using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Interfaz
{
    public interface IEspecialidadMedico1
    {
        bool guardarEspecialidaMedico(EspecialidadMedico especialidad);
        bool actualizarEspecialidaMedico(EspecialidadMedico especialidad);
        void eliminarEspecialiad(int id);

        EspecialidadMedico buscarMatricula(string matricula);
        EspecialidadMedico buscarIdMedico(int id);
        DataTable listarEspecialidadMedico();

    }
}
