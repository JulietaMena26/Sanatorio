using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Modelos;

namespace Sanatorio.Interfaz
{
    public interface IObraSocial1
    {
        bool agregarObraSocial(ObraSocial obrasocial);
        bool actualizarObraSocial(ObraSocial obrasocial);
        void eliminarObraSocial(int id);
        ObraSocial buscaridSocial(int idSocial);
        ObraSocial buscaridSocial(string codigo);
        DataTable listaNombre(string nombre);
        DataTable listarObraSocial(string cTexto);
    }
}
