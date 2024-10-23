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
    public class DatosInternacion : IInternacion1
    {
        public bool actualizarInternacion(Internacion internacion)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarFechaEgreso(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarFechaIngreso(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarFechaIngreso(DateTime ingreso, DateTime egreso)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarMedico(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarPaciente(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarInternacion(int id)
        {
            throw new NotImplementedException();
        }

        public bool guardarInternacion(Internacion internacion)
        {
            throw new NotImplementedException();
        }

        public DataTable listarInternacion()
        {
            throw new NotImplementedException();
        }
    }
}
