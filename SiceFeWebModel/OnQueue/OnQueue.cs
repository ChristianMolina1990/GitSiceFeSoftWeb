using SiceFeWebModel.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiceFeWebModel.OnQueue
{
    public class OnQueue : EntityComun
    {
        public string RucEmisor { get; set; }
        public string TipoDocumentoSunat { get; set; }
        public string SerieDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Decimal ImporteDocumento { get; set; }
        public string EmailRegistrado { get; set; }
        public bool? EmailEnviado { get; set; }
        public DateTime? FechaEnviado { get; set; }

    }
}
