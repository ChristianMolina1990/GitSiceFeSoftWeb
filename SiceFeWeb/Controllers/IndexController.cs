using SiceFeWebModel.Comun;
using SiceFeWebModel.OnQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiceFeWeb.Controllers
{
    public class IndexController : Controller
    {

        public readonly SiceFeWebDB.Contexto.SiceFeWebDB _siceFeWebDB = new SiceFeWebDB.Contexto.SiceFeWebDB();
        public IndexController()
        {
        }

        public IndexController (SiceFeWebDB.Contexto.SiceFeWebDB siceFeWebDB)
        {
            _siceFeWebDB = siceFeWebDB;
        }

        // GET: Index
        public ActionResult Index()
        {
            ViewBag.Title = "Facturación electrónica";

            
            return View();
        }


        [HttpPost]
        public ActionResult Index(string txtDctoEmi, string selTpdRec, string txtDctoRec, string tipoComprobante, string txtSerie, string txtDocumento, string txtCmpCtrl, string txtEmail)
        {
            try
            {
                decimal dec_txtCmpCtrl = Decimal.Parse(txtCmpCtrl);
                var modelo = from doc in _siceFeWebDB.Document
                             where (doc.RucEmisor == txtDctoEmi &
                                                            doc.TipoDocumentoIdentidadCliente == selTpdRec &
                                                            doc.NombreDocumentoIdentidadCliente == txtDctoRec &
                                                            doc.TipoDocumentoSunat == tipoComprobante &

                                                            doc.SerieDocumento == txtSerie &
                                                            doc.NumeroDocumento == txtDocumento &
                                                            doc.ImporteTotal == dec_txtCmpCtrl)
                             select new DocumentoRequest
                             {
                                 NumeroDocumentoIdentidadEmisor = doc.NumeroDocumento
                             };


                var result = modelo.ToList();

                if (result != null)
                {
                    OnQueue onQueue = new OnQueue()
                    {
                        RucEmisor = txtDctoEmi,
                        TipoDocumentoSunat = tipoComprobante,
                        SerieDocumento = txtSerie,
                        NumeroDocumento = txtDocumento,
                        ImporteDocumento = dec_txtCmpCtrl,
                        EmailRegistrado = txtEmail
                    };

                    _siceFeWebDB.OnQueue.Add(onQueue);
                    _siceFeWebDB.SaveChangesAsync();

                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            //ViewBag.Aficion = selTpdEmi;
            return RedirectToAction("Index");
        }
    }
}