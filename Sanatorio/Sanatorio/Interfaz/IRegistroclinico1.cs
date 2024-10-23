using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IRegistroclinico1
    {
        bool agregarRegistro(string RegistroClinico);
        bool actualizarRegistro(string registro);
        void eliminarRegistroId(string Paciente);
        void buscarRegistroId(string dni);


        List<Paciente> ListadoRegistroPaciente(string Paciente);
        List<Paciente> listadoMedicoApellido(string apellido);
        List<Paciente> listarPaciente();
        List<Paciente> listarMedico(string Medico);
    }
}
