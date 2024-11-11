using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IMedico1
    {
        bool agregarMedico(Medico medico);
        bool actualizarMedico(Medico medico);
        void eliminarMedico(string dni);
        Medico buscarMedicoDni(string dni);
        Medico buscarMedicoId(int id);

        DataTable listadoMedicoApellido(string apellido);
        DataTable listarMedico(string texto);
        DataTable listarMedicoXespecialidad(string especialidad);

    }
}
