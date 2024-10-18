using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IMedico
    {
        bool agregarMedico(Medico medico);
        bool actualizarMedico(Medico medico);
        void eliminarMedico(string dni);
        Medico buscarMedicoDni(string dni);
        Medico buscarMedicoId(int id);

        List<Medico> listadoMedicoApellido(string apellido);
        List<Medico> listarMedico();
        List<Medico> listarMedicoXespecialidad(string especialidad);

    }
}
