using Sanatorio.Interfaz;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Datos
{
    public class DatosRegistroClinico : IRegistroClinico1
    {
        public bool actualizarRegistro(Registro_Clinico registro)
        {
            throw new NotImplementedException();
        }

        public bool agregarRegistro(Registro_Clinico registro)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarRegistroFecha(DateTime inicial, DateTime final)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarRegistroId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarRegistroIdMedico(int id_medico)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarRegistroIdPaciente(int id_paciente)
        {
            throw new NotImplementedException();
        }

        public void eliminarRegistroId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable listarRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
