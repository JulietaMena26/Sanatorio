using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    public interface IRegistroClinico1
    {
        bool agregarRegistro(Registro_Clinico registro);
        bool actualizarRegistro(Registro_Clinico registro);
        void eliminarRegistroId(int id);
        DataTable buscarRegistroId(int id);
        DataTable buscarRegistroIdPaciente(int id_paciente);
        DataTable buscarRegistroIdMedico(int id_medico);
        DataTable buscarRegistroFecha(DateTime inicial, DateTime final);
        DataTable listarRegistros(string cTexto);
       
    }
}
