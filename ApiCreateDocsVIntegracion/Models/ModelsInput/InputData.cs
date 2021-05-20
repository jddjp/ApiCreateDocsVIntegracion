using ApiCreacionDocs.Models.ModelsOuput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCreacionDocs.Models
{
    public class InputData
    {
        public string Credenciales { get; set; }
        public string IdentificadorTramite { get; set; }
        public string IdPersona { get; set; }
        public InformacionDocs.InputReferenciaPago dataReferenciaPago { get; set; }
        public InformacionDocs.InputCaratula dataCaratula { get; set; }
        public InformacionDocs.InputCaratulaMejoramiento dataCaratulaMejoramiento { get; set; }
        public InformacionDocs.InputPagare dataPagare { get; set; }
        public InformacionDocs.InputSolicitud dataSolicitud { get; set; }
        public InformacionDocs.InputSolicitudMejoramiento dataSolicitudMejoramiento { get; set; }
        public InformacionDocs.InputContratoConsumo dataContratoConsumo { get; set; }
        public InformacionDocs.InputContratoMejoramiento dataContratoMejoramiento { get; set; }
        public InformacionDocs.InputEstipulacion dataEstipulacion { get; set; }
        public InformacionDocs.InputTablaAmortizacion dataTAmortizacion { get; set; }
        public InformacionDocs.InputArticulosLegales dataArticulosLegalesMejoramiento { get; set; }
        public InformacionDocs.InputArticulosLegales dataArticulosLegales { get; set; }
        public InformacionDocs.InputPresupuestoObra dataPresupuestoObra { get; set; }
        public InformacionDocs.InputEstudioSocioeconomico dataEstudioSocioeconomico { get; set; }
        public InformacionDocs.InputProyeccionObra dataProyeccionObra { get; set; }
        public InformacionDocs.InputCartaEntrega dataCartaEntrega { get; set; }

        //Domiciliado
        public InformacionDocs.InputSolicitudDomiciliado SolicitudDomiciliado { get; set; }
        public InformacionDocs.InputContratoDomiciliado ContratoDomiciliado { get; set; }
        public InformacionDocs.InputCaratulaDomiciliacion CaratulaDomiciliado { get; set; }
        public InformacionDocs.InputArticulosLegalesDomiciliacion ArticulosLegalesDomiciliado { get; set; }
        public InformacionDocs.InputConceptosDomiciliacion ConceptosDomiciliaion { get; set; }
        public InformacionDocs.InputIntegracionPreeliminarDomiciliacion IntegracionPreeliminar { get; set; }
        public InformacionDocs.InputCheckListDomiciliacion CheckList { get; set; }


    }
}