using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IDatosmedico1
    {
        bool agregarDatomedico(Medico Datomedico);
        bool actualizarMedico(string Datomedico);
        void eliminardatomedico(string idDato);
        Medico buscarDatomedico(int idDato);

        List<DatosMedico> listaNombre(string nombre);
        List<ObraSocial> listarDato();
    }
}
