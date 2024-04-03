using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PRODUCTO
    {
        public int IDPRODUCTO { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string DEDSCRIPCION { get; set; }
        public CATEGORIA oCATEGORIA { get; set; }
        public int STOCK{ get; set; }
        public decimal PRECIOCOMPRA { get; set; }
        public decimal PRECIOVENTA { get; set; }
        public string ESTADO { get; set; }
        public string FECHACREACION { get; set; }

    }
}
