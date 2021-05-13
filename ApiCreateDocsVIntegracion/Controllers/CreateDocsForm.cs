using ApiCreacionDocs.Models;
using ApiCreacionDocs.Models.ModelsOuput;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OriginaWebApp.Models.Formatos;
using SelectPdf;
using System;
using System.Collections.Generic;
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
        //private readonly IWebHostEnvironment _env;

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

            if (data.dataPagare != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GeneratePagare(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "Pagare.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "Estipulacion.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
            if (data.dataTAmortizacion != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateTablaAmortizacion(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "TablaAmortizacion.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
            if (data.dataPresupuestoObra != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GeneratePresupuestoObra(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "PesupuestoDeObra.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "EstudioSocioEconomico.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
            if (data.dataProyeccionObra != null)
            {
                var content = new MultipartFormDataContent();
                ByteArrayContent bytes = new ByteArrayContent(GenerateProyeccionObra(data));
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Emision");
                content.Add(new StringContent(DateTime.Now.ToShortDateString()), "Fecha_Vigencia");
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "ProyeccionDeObra.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
                content.Add(new StringContent(data.dataSolicitud.TipoExpediente.ToString()), "TipoExpediente");
                content.Add(bytes, "Documento", "CartaEntrega.pdf");
                content.Add(new StringContent(data.dataSolicitud.TipoSubExpediente.ToString()), "TipocSubExpediente");
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
            if (data.dataSolicitud != null)
            {
                //vamos obtener la solicitud
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
        public byte[] GenerateTablaAmortizacion(InputData data)
        {
            fmtfmtTablaAmortizacion formato = new fmtfmtTablaAmortizacion();

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
        public byte[] GenerateContratoConsumo(InputData data)
        {
            fmtfmtContratoConsumo formato = new fmtfmtContratoConsumo();

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
        public byte[] GenerateCaratula(InputData data)
        {
            fmtfmtCaratula formato = new fmtfmtCaratula();

            string htmlString = formato.FormatoHTML(data,"\\img\\aprecia-blanco.jpeg");
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
        public byte[] GenerateEstipulacion(InputData data)
        {


            fmtfmtEstipulacion formato = new fmtfmtEstipulacion();

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
