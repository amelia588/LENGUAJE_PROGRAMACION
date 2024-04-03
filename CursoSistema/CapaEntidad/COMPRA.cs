using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class COMPRA
    {
        public int IDCOMPRA { get; set; }
        public USUARIO oUSUARIO { get; set; }
        public PROVEEDOR oPROVEEDOR { get; set; }
        public string TIPODOCUMENTO { get; set; }
        public string NUMERODOCUMENTO { get; set; }
        public decimal MONTOTOTAL { get; set; }
        public List<DETALLE_COMPRA> oDETALLE_COMPRA { get; set; }
        public string FECHAREGISTRO { get; set; }

    }
}
