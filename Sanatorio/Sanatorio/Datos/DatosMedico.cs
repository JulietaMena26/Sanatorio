using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;

namespace Sanatorio.Datos
{
    class DatosMedico : IMedico
    {
        public bool actualizarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public bool agregarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Medico buscarMedicoDni(string dni)
        {
            throw new NotImplementedException();
        }

        public Medico buscarMedicoId(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarMedico(string dni)
        {
            throw new NotImplementedException();
        }

        public List<Medico> listadoMedicoApellido(string apellido)
        {
            throw new NotImplementedException();
        }

        public List<Medico> listarMedico()
        {
            throw new NotImplementedException();
        }

        public List<Medico> listarMedicoXespecialidad(string especialidad)
        {
            throw new NotImplementedException();
        }
    }
}
