﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;

namespace Sanatorio.Datos
{
    class DatosMedico : IMedico1
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

        public DataTable listadoMedicoApellido(string apellido)
        {
            throw new NotImplementedException();
        }

        public DataTable listarMedico()
        {
            throw new NotImplementedException();
        }

        public DataTable listarMedicoXespecialidad(string especialidad)
        {
            throw new NotImplementedException();
        }
    }
}
