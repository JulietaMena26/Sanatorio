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
        bool agregarPaciente(Paciente paciente);
        bool actualizarPaciente(Paciente paciente);
        void eliminarPaciente(string dni);
        void eliminarPaciente(int id);
        Paciente buscarPacienteDni(string dni);
        Paciente buscarPacienteId(int idpaciente);
        DataTable listadoPacienteApellido(string apellido);
        DataTable listarPaciente();
        DataTable listarPacienteid_ObraSocial(int id_obraSocial);

    }
}
