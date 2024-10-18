using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Modelos
{
    internal class obraSocial
    {
        private int idSocial { get; set; }
        private string codigo { get; set; }
        private string nombre { get; set; }
        private bool activo { get; set; }

        public obraSocial() { }

        public obraSocial(int idSocial, string codigo, string nombre, bool activo)
        {
            this.idSocial = idSocial;
            this.codigo = codigo;
            this.nombre = nombre;
            this.activo = activo;
        }


        public obraSocial(string codigo, string nombre, bool activo)
        {
            
            this.codigo = codigo;
            this.nombre = nombre;
            this.activo = activo;
        }
    }
}
