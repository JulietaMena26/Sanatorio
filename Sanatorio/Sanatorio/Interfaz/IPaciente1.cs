using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IPaciente1
    {
        bool agregarPaciente(Paciente _paciente);
        bool actualizarPaciente(Paciente paciente);
        void eliminarPaciente(string dni);
        Paciente buscarPacienteDni(string dni);
        Paciente buscarPacienteId(int idpaciente);
        Paciente listadoPacienteApellido(string apellido);
        DataTable listarPaciente();
        List<Paciente> listarPacienteid_ObraSocial(int id_obraSocial);

    }
}
