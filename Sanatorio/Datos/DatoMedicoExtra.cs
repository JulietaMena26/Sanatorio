using Sanatorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Datos
{
    /* Clase para manejar los datos de la tabla
      datosmedicos
      Esta tabla guarda datos adicionales 
       de los medicos (puede ser opcional)
      */
    public class DatoMedicoExtra : IDatosmedico1
    {
        
        public bool actualizarMedico(Dato_Medico Datomedico)
        {
            throw new NotImplementedException();
        }

        public bool agregarDatomedico(Dato_Medico datos)
        {
            throw new NotImplementedException();
        }

        public Dato_Medico buscarDatomedico(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminardatomedico(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable listarDatoMedico()
        {
            throw new NotImplementedException();
        }
    }
}
