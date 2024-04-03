using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DETALLE_VENTA
    {
        public  int IDDETALLE_VENTA { get; set; }
        public PRODUCTO oPRODUCTO { get; set; }
        public decimal PRECIOVENTA { get; set; }
        public int CANTIDAD { get; set; }
        public decimal SUBTOTAL { get; set; }
        public string FECHACREACION { get; set; }

    }
}
