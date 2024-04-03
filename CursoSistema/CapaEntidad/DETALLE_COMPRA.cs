using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public class DETALLE_COMPRA
    {
        public int IDDETALLE_COMPRA { get; set; }
        public PRODUCTO oPRODUCTO { get; set; }
        public decimal PRECIOCOMPRA { get; set; }
        public decimal PRECIOVENTA { get; set; }
        public int CANTIDAD { get; set; }
        public decimal MONTOTOTAL { get; set; }
        public string FECHACREACION { get; set; }
    }
}
