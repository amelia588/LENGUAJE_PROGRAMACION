using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaNegocio
{
    public class CN_USUARIO
    {
        // instanciamos datos
        private CD_USUARIO objCD_USUARIO = new CD_USUARIO();

        public List<USUARIO> Listar()
        {
            return objCD_USUARIO.Listar();
        }
    }
}
