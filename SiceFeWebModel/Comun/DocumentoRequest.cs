using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiceFeWebModel.Comun
{
    public class DocumentoRequest
    {
        public string NumeroDocumentoIdentidadEmisor { get; set; }
        public string TipoDocumentoSUNAT { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string TipoDocumentoIdentidadCliente { get; set; }
        public string NumeroDocumentoIdentidadCliente { get; set; }
        public decimal ImporteTotal { get; set; }
    }
}
