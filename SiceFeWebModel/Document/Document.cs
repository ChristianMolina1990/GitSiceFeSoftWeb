using SiceFeWebModel.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiceFeWebModel.Document
{
    public class Document : EntityComun
    {
        public string RucEmisor { get; set; }
        public string NombreEmisor { get; set; }
        public string TipoDocumentoSunat { get; set; }
        public string NombreDocumentoSunat { get; set; }
        public string SerieDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumentoIdentidadCliente { get; set; }
        public string NombreDocumentoIdentidadCliente { get; set; }
        public decimal ImporteTotal { get; set; }
        public int? CodigoInterno { get; set; }

    }
}
