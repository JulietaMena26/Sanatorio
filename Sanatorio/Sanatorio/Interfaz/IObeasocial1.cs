using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    internal interface IObeasocial1
    {
        bool agregarObraSocial(ObraSocial obrasocial);
        bool actualizarObraSocial(ObraSocial obrasocial);
        void eliminarObraSocial(string codigo);
        Medico buscaridSocial(int idSocial);

        List<ObraSocial> listaNombre(string nombre);
        List<ObraSocial> listarObraSocial();
    }
}
