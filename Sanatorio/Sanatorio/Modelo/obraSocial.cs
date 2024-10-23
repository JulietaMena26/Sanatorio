using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class ObraSocial
    {
        public int idSocial { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }

        public ObraSocial() { }

        public ObraSocial(int idSocial, string codigo, string nombre, bool activo)
        {
            this.idSocial = idSocial;
            this.codigo = codigo;
            this.nombre = nombre;
            this.activo = activo;
        }


        public ObraSocial(string codigo, string nombre, bool activo)
        {
            
            this.codigo = codigo;
            this.nombre = nombre;
            this.activo = activo;
        }
    }
}
