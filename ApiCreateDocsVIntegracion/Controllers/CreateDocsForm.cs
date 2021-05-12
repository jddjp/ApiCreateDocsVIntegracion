﻿using ApiCreacionDocs.Models;
using ApiCreacionDocs.Models.ModelsOuput;
using Microsoft.AspNetCore.Mvc;
using OriginaWebApp.Models.Formatos;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiCreateDocsVIntegracion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateDocsForm : Controller
    {
        [HttpPost]
        public async Task<IActionResult> CreateDocs(InputData data)
        {

            return Ok(SavePdfFileAsync(data));
        }

        //Almacenar Documento en el expediente del no. solicitud a la APiExpedientes
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<OutputData> SavePdfFileAsync(InputData data)
        {
            OutputData DocsInfoSaveExpedientes = new OutputData();

            //if (data.dataPagare != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GeneratePagare(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataPagare.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "Pagare.pdf");
            //    content.Add(new StringContent(data.dataPagare.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");
            //    if (data.dataPagare.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoPagare = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoPagare = EnviarExpedientes(content).Documento_data;
            //    }

            //}

            //if (data.dataEstipulacion != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateEstipulacion(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataEstipulacion.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "Estipulacion.pdf");
            //    content.Add(new StringContent(data.dataEstipulacion.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataEstipulacion.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoEstipulacion = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoEstipulacion = EnviarExpedientes(content).Documento_data;
            //    }



            //}
            //if (data.dataArticulosLegales != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateArticulos());
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataArticulosLegales.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "ArticulosLegales.pdf");
            //    content.Add(new StringContent(data.dataArticulosLegales.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataArticulosLegales.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoArticulosLegales = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoArticulosLegales = EnviarExpedientes(content).Documento_data;
            //    }

            //}
            //if (data.dataCaratula != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateCaratula());
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataCaratula.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "Caratula.pdf");
            //    content.Add(new StringContent(data.dataCaratula.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");
            //    if (data.dataCaratula.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoCaratula = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoCaratula = EnviarExpedientes(content).Documento_data;
            //    }

            //}
            //if (data.dataContratoConsumo != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateContratoConsumo());
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataContratoConsumo.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "ContratoConsumo.pdf");
            //    content.Add(new StringContent(data.dataContratoConsumo.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataContratoConsumo.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoContratoConsumo = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoContratoConsumo = EnviarExpedientes(content).Documento_data;
            //    }

            //}
            //if (data.dataTAmortizacion != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateTablaAmortizacion(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataTAmortizacion.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "TablaAmortizacion.pdf");
            //    content.Add(new StringContent(data.dataTAmortizacion.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");
            //    if (data.dataTAmortizacion.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoTablaAmortizacion = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoTablaAmortizacion = EnviarExpedientes(content).Documento_data;
            //    }


            //}
            //if (data.dataReferenciaPago != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateReferenciaPago(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataTAmortizacion.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "ReferenciaPago.pdf");
            //    content.Add(new StringContent(data.dataReferenciaPago.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataReferenciaPago.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoReferenciaPago = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoReferenciaPago = EnviarExpedientes(content).Documento_data;
            //    }

            //}
            //if (data.dataPresupuestoObra != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GeneratePresupuestoObra(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataPresupuestoObra.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "PresupuestoObra.pdf");
            //    content.Add(new StringContent(data.dataPresupuestoObra.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataPresupuestoObra.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoPresupuestoObra = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoPresupuestoObra = EnviarExpedientes(content).Documento_data;
            //    }


            //}
            //if (data.dataEstudioSocioeconomico != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateEstudidioSocioeconomico(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataEstudioSocioeconomico.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "EstudioSocioeconomico.pdf");
            //    content.Add(new StringContent(data.dataEstudioSocioeconomico.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataEstudioSocioeconomico.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoEstudioSocioeconomico = EnviarExpedientes(content).Documento_data;
            //    }



            //}
            //if (data.dataProyeccionObra != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateProyeccionObra(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataProyeccionObra.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "ProyeccionDeObra.pdf");
            //    content.Add(new StringContent(data.dataProyeccionObra.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataProyeccionObra.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoProyeccionObra = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoProyeccionObra = EnviarExpedientes(content).Documento_data;
            //    }


            //}
            //if (data.dataCartaEntrega != null)
            //{
            //    var content = new MultipartFormDataContent();
            //    ByteArrayContent bytes = new ByteArrayContent(GenerateCartaEntrega(data));
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
            //    content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
            //    content.Add(new StringContent(data.dataCartaEntrega.TipoExpediente), "TipoExpediente");
            //    content.Add(bytes, "Documento", "CartaEntrega.pdf");
            //    content.Add(new StringContent(data.dataCartaEntrega.TipoSubExpediente), "TipocSubExpediente");
            //    content.Add(new StringContent(data.IdentificadorTramite.ToString()), "IdExpediente");
            //    content.Add(new StringContent(data.Credenciales.ToString()), "CredencialesCliente");
            //    content.Add(new StringContent("2345"), "Tipo_Documento");

            //    if (data.dataCartaEntrega.formato == "pdf")
            //    {
            //        DocsInfoSaveExpedientes.DocumentoCartaEntrega = EnviarExpedientes(content).URL;
            //    }
            //    else
            //    {
            //        DocsInfoSaveExpedientes.DocumentoCartaEntrega = EnviarExpedientes(content).Documento_data;
            //    }



            //}
            //if (data.dataSolicitud != null)
            //{
                //vamos obtener la solicitud


                //System.IO.File.WriteAllBytes("Solicitud.pdf", GenerateSolicitud(data));

                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateSolicitud(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent("22"), "TipoExpediente");
                content.Add(bytes, "Documento", "Solicitud.pdf");
                content.Add(new StringContent("2201"), "TipocSubExpediente");
                content.Add(new StringContent("220102"), "TipocSubSubExpediente");
                content.Add(new StringContent("DocGenerate"), "IdExpediente");
                content.Add(new StringContent("Fomepade"), "CredencialesCliente");
                content.Add(new StringContent("2345"), "Tipo_Documento");

            var doc = EnviarExpedientes(content).URL;
            DocsInfoSaveExpedientes.DocumentoSolicitud = doc;

            //if (data.dataSolicitud.formato == "pdf")
            //{
            //    var doc = EnviarExpedientes(content).URL;
            //    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
            //}
            //else
            //{
            //    var doc = EnviarExpedientes(content).Documento_data;
            //    DocsInfoSaveExpedientes.DocumentoSolicitud = doc;
            //}

            //}
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
                        //expedienteEnvioResponse = JsonConverter.DeserializeObject<DocumentosExpedienteCliente>(jsonString.Result);
                        //expedienteEnvioResponse = JsonConverter.DeserializeObject<DocumentosExpedienteCliente>(jsonString.Result);

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

            //IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            //MemoryStream rend = Renderer.RenderHtmlAsPdf(formato.FormatoHTML()).Stream;

            //return File(rend, "application/pdf", "Tabla.pdf");

            // read parameters from the webpage
            //string htmlString = formato.FormatoHTML(cotizaView, listAmortizacion, _env.WebRootPath + "C://Javier//Cotizador//Proyectos//OriginaWebApp//wwwroot//img//aprecia-blanco.jpg");
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