using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
  public interface IDatosmedico1
    {
        bool agregarDatomedico(Dato_Medico datos);
        bool actualizarMedico(Dato_Medico Datomedico);
        void eliminardatomedico(int id);
        Dato_Medico buscarDatomedico(int id);
        DataTable listarDatoMedico();
    }
}
