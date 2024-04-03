using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VENTA
    {
        public int IDVENTA { get; set; }
        public USUARIO oUSUARIO { get; set; }
        public string TIPODOCUMENTO { get; set; }
        public string NUMERODOCUMENTO { get; set; }
        public string DOCUMENTOCLIENTE { get; set; }
        public string NOMBRECLIENTE { get; set; }
        public decimal MONTOPAGO { get; set; }
        public decimal MONTOCAMBIO { get; set; }
        public decimal MONTOTOTAL { get; set; }
        public List<DETALLE_VENTA> dETALLE_VENTAs{ get; set; }
        public string FECHACREACION { get; set; }
    }
}
