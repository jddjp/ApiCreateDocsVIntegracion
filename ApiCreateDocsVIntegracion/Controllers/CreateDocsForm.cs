using ApiCreacionDocs.Models;
using ApiCreacionDocs.Models.ModelsOuput;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;
using OriginaWebApp.Models.Formatos;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;



namespace ApiCreateDocsVIntegracion.Controllers
{
    

    [ApiController]
    [Route("[controller]")]
    public class CreateDocsForm : Controller
    {
        //Url de la imagen
        private readonly IWebHostEnvironment _env;
        public CreateDocsForm( IWebHostEnvironment env)
        {
        
            _env = env;
        }


        [HttpPost]
        public async Task<IActionResult> CreateDocs(InputData data)
        {
          var json = new JavaScriptSerializer().Serialize(data);
            var x = json;
             return Ok(SavePdfFileAsync(data));
        }

        //Almacenar Documento en el expediente del no. solicitud a la APiExpedientes
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<OutputData> SavePdfFileAsync(InputData data)
        {
            OutputData DocsInfoSaveExpedientes = new OutputData();

            //La tabla Amortizacion no Cambia es igual para cualquier producto
            if (data.dataTAmortizacion != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateTablaAmortizacion(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataTAmortizacion.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "TablaAmortizacion.pdf");
                content.Add(new StringContent(data.dataTAmortizacion.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");
                if (data.dataTAmortizacion.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoTablaAmortizacion = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoTablaAmortizacion = EnviarExpedientes(content).Documento_data;
                }


            }

            //Consumo

            if (data.dataPagare != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GeneratePagare(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataPagare.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "Pagare.pdf");
                content.Add(new StringContent(data.dataPagare.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");
                if (data.dataPagare.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoPagare = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoPagare = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.dataEstipulacion != null)
            {
                var content = new MultipartFormDataContent();

                ByteArrayContent bytes = new ByteArrayContent(GenerateEstipulacion(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataEstipulacion.TipoExpediente.ToString()), "TipoExpediente");
                //Recibir Nombre del documento y Extension
                content.Add(bytes, "Documento", "Estipulacion.pdf");
                content.Add(new StringContent(data.dataEstipulacion.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataEstipulacion.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstipulacion = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstipulacion = EnviarExpedientes(content).Documento_data;
                }



            }
            if (data.dataArticulosLegales != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateArticulos(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ArticulosLegales.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataArticulosLegales.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoArticulosLegales = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoArticulosLegales = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.dataCaratula != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateCaratula(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "Caratula.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");
               
                if (data.dataCaratula.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoCaratula = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoCaratula = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.dataContratoConsumo != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateContratoConsumo(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ContratoConsumo.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataContratoConsumo.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoContratoConsumo = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoContratoConsumo = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.dataReferenciaPago != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateReferenciaPago(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ReferenciaPago.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataReferenciaPago.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoReferenciaPago = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoReferenciaPago = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.dataSolicitud != null)
            {
              
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateSolicitud(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "Solicitud.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente"); 
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");


                if (data.dataSolicitud.formato == "pdf")
                {
                    var doc = EnviarExpedientes(content).URL;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }
                else
                {
                    var doc = EnviarExpedientes(content).Documento_data;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }

            }


            //Mejoramiento

            if (data.dataSolicitudMejoramiento != null)
            {
                
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateSolicitudMejoramiento(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitudMejoramiento.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "SolicitudMejoramiento.pdf");
                content.Add(new StringContent(data.dataSolicitudMejoramiento.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");


                if (data.dataSolicitudMejoramiento.formato == "pdf")
                {
                    var doc = EnviarExpedientes(content).URL;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }
                else
                {
                    var doc = EnviarExpedientes(content).Documento_data;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }

            }
            if (data.dataCaratulaMejoramiento != null)
            {

                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateCaratulaMejoramiento(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataCaratulaMejoramiento.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "CaratulaMejoramiento.pdf");
                content.Add(new StringContent(data.dataCaratulaMejoramiento.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");


                if (data.dataSolicitudMejoramiento.formato == "pdf")
                {
                    var doc = EnviarExpedientes(content).URL;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }
                else
                {
                    var doc = EnviarExpedientes(content).Documento_data;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }

            }
            if (data.dataContratoMejoramiento != null)
            {

                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateContratoMejoramiento(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataContratoMejoramiento.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ContratoMejoramiento.pdf");
                content.Add(new StringContent(data.dataContratoMejoramiento.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");


                if (data.dataSolicitudMejoramiento.formato == "pdf")
                {
                    var doc = EnviarExpedientes(content).URL;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }
                else
                {
                    var doc = EnviarExpedientes(content).Documento_data;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }

            }
            if (data.dataArticulosLegalesMejoramiento != null)
            {

                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateArticulosMejoramiento(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataArticulosLegalesMejoramiento.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ArticulosLegalesMejoramiento.pdf");
                content.Add(new StringContent(data.dataArticulosLegalesMejoramiento.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");


                if (data.dataArticulosLegalesMejoramiento.formato == "pdf")
                {
                    var doc = EnviarExpedientes(content).URL;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }
                else
                {
                    var doc = EnviarExpedientes(content).Documento_data;
                    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
                }

            }
            //Revisar
            if (data.dataProyeccionObra != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateProyeccionObra(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataProyeccionObra.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ProyeccionDeObraMejoramiento.pdf");
                content.Add(new StringContent(data.dataProyeccionObra.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataProyeccionObra.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoProyeccionObra = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoProyeccionObra = EnviarExpedientes(content).Documento_data;
                }


            }
            if (data.dataCartaEntrega != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateCartaEntrega(data));

                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataCartaEntrega.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "CartaEntregaMejoramiento.pdf");
                content.Add(new StringContent(data.dataCartaEntrega.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataCartaEntrega.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoCartaEntrega = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoCartaEntrega = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.dataPresupuestoObra != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GeneratePresupuestoObra(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataPresupuestoObra.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "PresupuestoDeObraMejoramiento.pdf");
                content.Add(new StringContent(data.dataPresupuestoObra.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataPresupuestoObra.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoPresupuestoObra = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoPresupuestoObra = EnviarExpedientes(content).Documento_data;
                }


            }
            if (data.dataEstudioSocioeconomico != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateEstudidioSocioeconomico(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataEstudioSocioeconomico.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "EstudioSocioEconomicoMejoramiento.pdf");
                content.Add(new StringContent(data.dataEstudioSocioeconomico.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.dataEstudioSocioeconomico.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }



            }
            //Revisar

            //DomiciliadoPublio
            if (data.SolicitudDomiciliado != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateSolicitudDomiciliado(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.SolicitudDomiciliado.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "SolicitudDomiciliado.pdf");
                content.Add(new StringContent(data.SolicitudDomiciliado.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.SolicitudDomiciliado.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }



            }
            if (data.ContratoDomiciliado != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GeneraContratoDomiciliado(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.ContratoDomiciliado.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ContratoDomiciliado.pdf");
                content.Add(new StringContent(data.ContratoDomiciliado.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.ContratoDomiciliado.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }

            }
            if (data.CaratulaDomiciliado != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateCaratulaDomiciliado(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.CaratulaDomiciliado.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "CaratulaDomiciliado.pdf");
                content.Add(new StringContent(data.CaratulaDomiciliado.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.CaratulaDomiciliado.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }
            }
            if (data.ArticulosLegalesDomiciliado != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateArticulosDomiciliado(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.ArticulosLegalesDomiciliado.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ArticulosLegalesDomiciliado.pdf");
                content.Add(new StringContent(data.ArticulosLegalesDomiciliado.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.ArticulosLegalesDomiciliado.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }
            }
            if (data.ConceptosDomiciliaion != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateConceptosDomiciliacionDomiciliado(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.ConceptosDomiciliaion.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ConceptosDomiciliacion.pdf");
                content.Add(new StringContent(data.ConceptosDomiciliaion.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.ConceptosDomiciliaion.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }
            }
            if (data.IntegracionPreeliminar != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateIntegracionPreeliminar(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.IntegracionPreeliminar.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "IntegracionPreeliminar.pdf");
                content.Add(new StringContent(data.IntegracionPreeliminar.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

                if (data.IntegracionPreeliminar.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }
            }
            if (data.CheckList != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateCheckList(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.CheckList.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "CheckList.pdf");
                content.Add(new StringContent(data.CheckList.TipoSubExpediente.ToString()), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");


                if (data.CheckList.formato == "pdf")
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
                }
                else
                {
                    DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
                }
            }

            //Retornamos el Objeto 
            return DocsInfoSaveExpedientes;

        }
        //Almacenar Documentos en API Expedientes los manda y nos devuelve donde se encuentran fisica y en base64 
        [ApiExplorerSettings(IgnoreApi = true)]
        public DocumentosExpedienteCliente EnviarExpedientes(MultipartFormDataContent content)
        {
            DocumentosExpedienteCliente expedienteEnvioResponse = new DocumentosExpedienteCliente();
            try
            {
                using (var svcClient = new HttpClient())
                {

                    svcClient.DefaultRequestHeaders.Accept.Clear();
                    svcClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data")); //application/json"));

                    var response = svcClient.PostAsync("https://qa.adocs.aprecia.com.mx:9048/api/Clientes", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = response.Content.ReadAsStringAsync();

                       expedienteEnvioResponse = JsonConvert.DeserializeObject<DocumentosExpedienteCliente>(jsonString.Result);

                     
                    }


                }
            }
            catch (Exception ex)
            {

                expedienteEnvioResponse.Documento_data = ex.ToString();
            }


            return expedienteEnvioResponse;


        }

        //Generador de la solicitud

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateSolicitud(InputData data)
        {
            fmtfmtAutSolicitud formato = new fmtfmtAutSolicitud();
            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // header settings

            converter.Options.DisplayHeader = true;
            converter.Header.DisplayOnFirstPage = true;
            converter.Header.DisplayOnOddPages = true;
            converter.Header.DisplayOnEvenPages = true;
            converter.Header.Height = 40;/*Tamaño del encabezado en int*/

            fmtAutHeaderSolicitudConsumo headerContrato = new fmtAutHeaderSolicitudConsumo();
            string htmlStringheader = headerContrato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");

            PdfHtmlSection customHtml = new PdfHtmlSection(htmlStringheader, string.Empty);

            converter.Header.Add(customHtml);


            //// header settings
            //Footer
            converter.Options.DisplayFooter = true;
            converter.Footer.DisplayOnFirstPage = true;
            converter.Footer.DisplayOnOddPages = true;
            converter.Footer.DisplayOnEvenPages = true;
            converter.Footer.Height = 20;


            //fmtAutFooterContrato footer = new fmtAutFooterContrato();
            //string htmlStringfooter = footer.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            //PdfHtmlSection customHtmlfooter = new PdfHtmlSection(htmlStringfooter, string.Empty);
            //converter.Footer.Add(customHtmlfooter);

            PdfTextSection text = new PdfTextSection(0, 10, "Página : {page_number} de {total_pages}  ", new System.Drawing.Font("Arial", 8));
            text.HorizontalAlign = PdfTextHorizontalAlign.Right;
            converter.Footer.Add(text);
            //Footer


            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
         
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateSolicitudDomiciliado(InputData data)
        {
            DomiciliadofmtfmtAutSolicitud formato = new DomiciliadofmtfmtAutSolicitud();
            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GeneraContratoDomiciliado(InputData data)
        {
            DomiciliadofmtfmtContratoConsumo formato = new DomiciliadofmtfmtContratoConsumo();
            string htmlString = formato.FormatoHTML(data, "logo");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }


        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateSolicitudMejoramiento(InputData data)
        {
            MejoramientofmtfmtAutSolicitud formato = new MejoramientofmtfmtAutSolicitud();
            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }


        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateCartaEntrega(InputData data)
        {
            fmtfmtCartaEntrega formato = new fmtfmtCartaEntrega();

            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateProyeccionObra(InputData data)
        {
            fmtfmtAutProyecciondeObra formato = new fmtfmtAutProyecciondeObra();

            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateEstudidioSocioeconomico(InputData data)
        {
            fmtfmtEstudioSocioEconomio formato = new fmtfmtEstudioSocioEconomio();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString,  baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GeneratePresupuestoObra(InputData data)
        {
            fmtfmtPresupuestoObra formato = new fmtfmtPresupuestoObra();

            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        //Falta Codigo de Barras
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateReferenciaPago(InputData data)
        {
            fmtfmtReferenciaDePag formato = new fmtfmtReferenciaDePag();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateTablaAmortizacion(InputData data)
        {
            fmtfmtTablaAmortizacion formato = new fmtfmtTablaAmortizacion();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateContratoConsumo(InputData data)
        {


            fmtfmtContratoConsumo formato = new fmtfmtContratoConsumo();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation), pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // header settings
          
            converter.Options.DisplayHeader =true;
            converter.Header.DisplayOnFirstPage = true;
            converter.Header.DisplayOnOddPages = true;
            converter.Header.DisplayOnEvenPages = true;
            converter.Header.Height = 40;/*Tamaño del encabezado en int*/

            fmtAutHeaderContrato headerContrato = new fmtAutHeaderContrato();
            string htmlStringheader = headerContrato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");

            PdfHtmlSection customHtml = new PdfHtmlSection(htmlStringheader,   string.Empty);
          
            converter.Header.Add(customHtml);


            // header settings
            //Footer
            converter.Options.DisplayFooter = true;
            converter.Footer.DisplayOnFirstPage = true;
            converter.Footer.DisplayOnOddPages = true;
            converter.Footer.DisplayOnEvenPages = true;
            converter.Footer.Height = 20;


            fmtAutFooterContrato footer = new fmtAutFooterContrato();
            string htmlStringfooter = footer.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            PdfHtmlSection customHtmlfooter = new PdfHtmlSection(htmlStringfooter, string.Empty);
            converter.Footer.Add(customHtmlfooter);
            //Footer
            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateContratoMejoramiento(InputData data)
        {
            MejoramientofmtfmtContrato formato = new MejoramientofmtfmtContrato();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation), pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }


        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateCaratula(InputData data)
        {
            fmtfmtCaratula formato = new fmtfmtCaratula();

      
            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateCaratulaMejoramiento(InputData data)
        {
            MejoramientofmtfmtCaratula formato = new MejoramientofmtfmtCaratula();


            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateCaratulaDomiciliado(InputData data)
        {
            DomiciliadofmtfmtCaratula formato = new DomiciliadofmtfmtCaratula();


            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateArticulos(InputData data)
        {
            fmtfmtArticulosLegales formato = new fmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;


            // header settings

            converter.Options.DisplayHeader = true;
            converter.Header.DisplayOnFirstPage = true;
            converter.Header.DisplayOnOddPages = true;
            converter.Header.DisplayOnEvenPages = true;
            converter.Header.Height = 40;/*Tamaño del encabezado en int*/

            fmtAutHeaderArticulosLegalesConsumo headerArticulos = new fmtAutHeaderArticulosLegalesConsumo();
            string htmlStringheader = headerArticulos.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");

            PdfHtmlSection customHtml = new PdfHtmlSection(htmlStringheader, string.Empty);

            converter.Header.Add(customHtml);


            //// header settings
            //Footer
            converter.Options.DisplayFooter = true;
            converter.Footer.DisplayOnFirstPage = true;
            converter.Footer.DisplayOnOddPages = true;
            converter.Footer.DisplayOnEvenPages = true;
            converter.Footer.Height = 20;


            fmtAutFooterArticulosLegalesConsumo footer = new fmtAutFooterArticulosLegalesConsumo();
            string htmlStringfooter = footer.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            PdfHtmlSection customHtmlfooter = new PdfHtmlSection(htmlStringfooter, string.Empty);
            converter.Footer.Add(customHtmlfooter);

            PdfTextSection text = new PdfTextSection(0, 10, "Página : {page_number} | {total_pages}  ", new System.Drawing.Font("Arial", 8));
            text.HorizontalAlign = PdfTextHorizontalAlign.Right;
            converter.Footer.Add(text);
            //Footer


            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateArticulosMejoramiento(InputData data)
        {
            MejoramientofmtfmtArticulosLegales formato = new MejoramientofmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize), pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 20;
            converter.Options.MarginRight = 20;
            converter.Options.MarginTop = 20;
            converter.Options.MarginBottom = 20;

            // header settings

            converter.Options.DisplayHeader = true;
            converter.Header.DisplayOnFirstPage = true;
            converter.Header.DisplayOnOddPages = true;
            converter.Header.DisplayOnEvenPages = true;
            converter.Header.Height = 40;/*Tamaño del encabezado en int*/

            fmtAutHeaderArticulosLegalesMejoramiento headerArticulos = new fmtAutHeaderArticulosLegalesMejoramiento();
            string htmlStringheader = headerArticulos.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");

            PdfHtmlSection customHtml = new PdfHtmlSection(htmlStringheader, string.Empty);

            converter.Header.Add(customHtml);


            //// header settings
            //Footer
            converter.Options.DisplayFooter = true;
            converter.Footer.DisplayOnFirstPage = true;
            converter.Footer.DisplayOnOddPages = true;
            converter.Footer.DisplayOnEvenPages = true;
            converter.Footer.Height = 20;


            PdfTextSection text = new PdfTextSection(0, 10, "Página : {page_number} | {total_pages}  ", new System.Drawing.Font("Calibri", 8));
            text.HorizontalAlign = PdfTextHorizontalAlign.Right;
            converter.Footer.Add(text);

            fmtAutFooterArticulosLegalesMejormaiento footer = new fmtAutFooterArticulosLegalesMejormaiento();
            string htmlStringfooter = footer.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            PdfHtmlSection customHtmlfooter = new PdfHtmlSection(htmlStringfooter, string.Empty);
            converter.Footer.Add(customHtmlfooter);

            //Footer

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateArticulosDomiciliado(InputData data)
        {
            DomiciliadofmtfmtArticulosLegales formato = new DomiciliadofmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateConceptosDomiciliacionDomiciliado(InputData data)
        {
            DomiciliadofmtfmtArticulosLegales formato = new DomiciliadofmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateEstipulacion(InputData data)
        {


            fmtfmtEstipulacion formato = new fmtfmtEstipulacion();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 10;
            converter.Options.MarginRight = 10;
            converter.Options.MarginTop = 10;
            converter.Options.MarginBottom = 10;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateConceptosDomiciliacion(InputData data)
        {
            DomiciliadofmtfmtArticulosLegales formato = new DomiciliadofmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateIntegracionPreeliminar(InputData data)
        {


            DomiciliadofmtfmtArticulosLegales formato = new DomiciliadofmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GenerateCheckList(InputData data)
        {


            DomiciliadofmtfmtArticulosLegales formato = new DomiciliadofmtfmtArticulosLegales();

            string htmlString = formato.FormatoHTML(data, _env.WebRootPath + "\\img\\aprecia-blanco.jpeg");
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }


        [ApiExplorerSettings(IgnoreApi = true)]
        public byte[] GeneratePagare(InputData data)
        {


            fmtfmtPagare formato = new fmtfmtPagare();
            string htmlString = formato.FormatoHTML(data);
            string baseUrl = "";

            string pdf_page_size = "Letter";
            PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            string pdf_orientation = "Portrait";
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 1024;
            try
            {
                webPageWidth = 1024;
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = Convert.ToInt32(0);
            }
            catch { }

            // instantiate a html to pdf converter object
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            converter.Options.MarginLeft = 50;
            converter.Options.MarginRight = 50;
            converter.Options.MarginTop = 50;
            converter.Options.MarginBottom = 50;

            // create a new pdf document converting an url
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlString, baseUrl);
            var streamPdf = new MemoryStream(doc.Save());

            byte[] data1;
            using (var br = new BinaryReader(streamPdf))
                data1 = br.ReadBytes((int)streamPdf.Length);

            return data1;
        }
    }
}
