﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCreacionDocs.Models
{
    public class InformacionDocs
    {
        public class InputPagare
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]

            public string? Version { get; set; }

            [Key]
            public Int32 NumeroContrato { get; set; }
            public String NumeroPagare { get; set; }
            public String Cantidadpagare { get; set; }
            public String CantidadpagareNumLetras { get; set; }
            public String PersonaNombre { get; set; }
            public String PersonaDomicilio { get; set; }
            public String PersonaColonia { get; set; }
            public String PersonaCiudad { get; set; }
            public String PersonaTelefono { get; set; }
            public Int32 NumAmortizaciones { get; set; }
            public Int32 DiaUltimoPago { get; set; }
            public String MesUltimoPago { get; set; }
            public Int32 AnioUltimoPago { get; set; }
            public Int32 AnioPrimerpago { get; set; }
            public Int32 DiaPrimerPago { get; set; }
            public String MesPrimerPago { get; set; }
            public String PagosPeridicidad { get; set; }
            public String CiudadEmite { get; set; }
            public String PaisEmite { get; set; }
            public double TasaOrdinaria { get; set; }
            public double TasaMoratoria { get; set; }
            public String ColoniaEmite { get; set; }
            public String DireccionEmite { get; set; }
            public String CantidadPagosnumeroyletras { get; set; }
            public string FechaCreacionPagare { get; set; }
        }

        public class InputEstipulacion
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public string DiaMesAnioDispersion { get; set; }
            public string retenedorP { get; set; }
            public string TrabajoArea { get; set; }
            public string ClaveEmpleado { get; set; }
            public string ContratoNumero { get; set; }
            public string PlazoCreditoMeses { get; set; }
            public string PlazoCreditoQNAS { get; set; }
            public string MontoPrestamoSinInterSeguroLetra { get; set; }
            public string NombreCliente { get; set; }
            public string DireccionCliente { get; set; }
            public string TelefonoClientePart { get; set; }
            public string TelefonoClienteOficina { get; set; }
            public string NoCuentaCTAClaveDeposito { get; set; }
            public string MunicipioFirma { get; set; }
            public string EstadoFirma { get; set; }
            public string DiaMesLetraAnioDispersion { get; set; }
            public string MunicipioEstado { get; set; }
            public string TrabajoPuesto { get; set; }
            public string CredTotSinInterSeguro { get; set; }
            public string Comisionotorgamiento { get; set; }
            public string Creditosininteresseguroletra { get; set; }
            public string SeguroTotalSin1Pago { get; set; }
            public string SeguroTotalSin1PagoLetra { get; set; }
            public string CredTotal { get; set; }
            public string CredTotalLetra { get; set; }
            public string CredNumPagos { get; set; }
            public string CREDTIPOPERIODICO { get; set; }
            public string CredMontoParcialidad { get; set; }
            public string CREDMONTOPARCIALIDADLETRA { get; set; }
            public string TRABAJONOMBRE { get; set; }
            public string E_BANCO_CTA { get; set; }
            public string E_BANCO_CLABE { get; set; }
            public string EMPRESACLAVE_DEDUCCION { get; set; }
            public string LEPAGANNOMINACADA { get; set; }
            public string CLIENTERFC { get; set; }
            public string sexoMasculino { get; set; }
            public string sexoFemenino { get; set; }

        }


        public class InputConformaTablaAmortizacion
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            public InputTablaAmortizacion TablaInfoAmortiza { get; set; }
            public List<TAmortizacion> ListaTAmortiza { get; set; }
        }

        public class InputTablaAmortizacion
        {

            [Key]
            public String fechaOperacion { get; set; }
            public String fechaVence { get; set; }
            public String idPersona { get; set; }
            public String idCredito { get; set; }
            public String producto { get; set; }
            public String clienteNombre { get; set; }
            public String domicilioCliente { get; set; }
            public String coloniaCliente { get; set; }
            public String ciudadCliente { get; set; }
            public String telefonoCliente { get; set; }
            public String credTotal { get; set; }
            public String credTotalLetra { get; set; }
            public String credNumPagos { get; set; }
            public String clienteNombreAliasFirma { get; set; }


        }


        public class TAmortizacion
        {
            [Key]
            public Int32 No { get; set; }
            public String inicio { get; set; }
            public String vencimiento { get; set; }
            public String saldoInicial { get; set; }
            public String capital { get; set; }
            public String interes { get; set; }
            public String iva { get; set; }
            public String subtotal { get; set; }
            public String comision { get; set; }
            public String seguro { get; set; }
            public String pago { get; set; }
            public String saldoFinal { get; set; }

        }


        public class InputCaratula
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public decimal CAT { get; set; }
            public double TasaInsolutra { get; set; }
            public double TasaMoraa { get; set; }
            public decimal MontoLineaCredito { get; set; }
            public String MontoTotalPagar { get; set; }
            public String CreditoPeriodicidad { get; set; }
            public Int32 CreditoPlazo { get; set; }
            public String ClienteNombreCompleto { get; set; }

        }
        public class InputCaratulaMejoramiento
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public decimal CAT { get; set; }
            public double TasaInsolutra { get; set; }
            public double TasaMoraa { get; set; }
            public decimal MontoLineaCredito { get; set; }
            public String MontoTotalPagar { get; set; }
            public String CreditoPeriodicidad { get; set; }
            public Int32 CreditoPlazo { get; set; }
            public String ClienteNombreCompleto { get; set; }

        }

        public class InputEstudioSocioeconomico
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            //Valores Agregados 
            [Key]
            public string numeroCredito { get; set; }
            public string nombre { get; set; }
            public string primerApellido { get; set; }
            public string segundoApellido { get; set; }
            public string rfc { get; set; }
            public string curp { get; set; }
            public string fechaNacimiento { get; set; }
            public string edad { get; set; }
            public string telefono { get; set; }
            public string antiguedadEmpleo { get; set; }
            public string sexo { get; set; }
            public string sucursal { get; set; }
            public string convenio { get; set; }
            public string montoSolicitado { get; set; }
            public string plazo { get; set; }
            public string tasaInteresMensual { get; set; }
            public string amortizacion { get; set; }
            public string fechaInicio { get; set; }
            public string fechaVencimiento { get; set; }
            public string frecuenciaPago { get; set; }
            public string totalIngresos { get; set; }
            public string totalGastos { get; set; }
            public string totalDeudasBuro { get; set; }
            public string ingresoDisponible { get; set; }
            public string porcentajeDescuento { get; set; }
            public string capacidadDescuento { get; set; }
            public string resultadoEstudio { get; set; }
            public string fechaAprobacion { get; set; }
            public string aprobadoPor { get; set; }

        }
        public class InputContratoConsumo
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public String numeroContrato { get; set; }
            public String RepresentanteLegal { get; set; }
            public String ClienteNomCompleto { get; set; }
            public String SucursalDomicilio { get; set; }
            public String SucursalColonia { get; set; }
            public String SucursalCP { get; set; }
            public String TasaInsoluta { get; set; }
            public String CreditoTipoPeriodicidad { get; set; }
            public String TasaMora { get; set; }
            public String CreditoTotal { get; set; }
            public String CreditoTotalLetra { get; set; }
            public String CreditoPlazo { get; set; }
            public String CreditoNoPagos { get; set; }
            public String CreditoTipoCredito { get; set; }
            public String CreditoMontoParcialidad { get; set; }
            public String CreditoMontoParcialidadLetra { get; set; }
            public String ComisionPagoFijo { get; set; }
            public String ComisionPagoFijoLetra { get; set; }
            public String PorcentajeComision { get; set; }
            public String ReferenciaBanco { get; set; }
            public String SucursalMunicipio { get; set; }
            public String SucursalEstado { get; set; }
            public String CreditoMaximoCtaCorrriente { get; set; }
            public String CreditoMaximoCtaCorrrienteLetra { get; set; }
            public String EsCheque { get; set; }
            public String EsTarjeta { get; set; }
            public String BancoCuenta { get; set; }
            public String BancoCliente { get; set; }
            public String EsTransferencia { get; set; }
            public String BancoClabe { get; set; }
            public String BancoClienteClabe { get; set; }
            public String EspagoVentanilla { get; set; }
            public String MunicipioFirma { get; set; }
            public String MunicipioEstado { get; set; }
            public String DiaDispersion { get; set; }
            public String MesDispersion { get; set; }
            public String AnioDispersion { get; set; }
        }
        public class InputContratoMejoramiento
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public String numeroContrato { get; set; }
            public String RepresentanteLegal { get; set; }
            public String ClienteNomCompleto { get; set; }
            public String SucursalDomicilio { get; set; }
            public String SucursalColonia { get; set; }
            public String SucursalCP { get; set; }
            public String TasaInsoluta { get; set; }
            public String CreditoTipoPeriodicidad { get; set; }
            public String TasaMora { get; set; }
            public String CreditoTotal { get; set; }
            public String CreditoTotalLetra { get; set; }
            public String CreditoPlazo { get; set; }
            public String CreditoNoPagos { get; set; }
            public String CreditoTipoCredito { get; set; }
            public String CreditoMontoParcialidad { get; set; }
            public String CreditoMontoParcialidadLetra { get; set; }
            public String ComisionPagoFijo { get; set; }
            public String ComisionPagoFijoLetra { get; set; }
            public String PorcentajeComision { get; set; }
            public String ReferenciaBanco { get; set; }
            public String SucursalMunicipio { get; set; }
            public String SucursalEstado { get; set; }
            public String CreditoMaximoCtaCorrriente { get; set; }
            public String CreditoMaximoCtaCorrrienteLetra { get; set; }
            public String EsCheque { get; set; }
            public String EsTarjeta { get; set; }
            public String BancoCuenta { get; set; }
            public String BancoCliente { get; set; }
            public String EsTransferencia { get; set; }
            public String BancoClabe { get; set; }
            public String BancoClienteClabe { get; set; }
            public String EspagoVentanilla { get; set; }
            public String MunicipioFirma { get; set; }
            public String MunicipioEstado { get; set; }
            public String DiaDispersion { get; set; }
            public String MesDispersion { get; set; }
            public String AnioDispersion { get; set; }
        }
        public class InputReferenciaPago
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public DateTime FechaOperacion { get; set; }
            public String PagoPeriodicidadMonto { get; set; }
            public String ClienteNombre { get; set; }
            public String creditoPeriodicidad { get; set; }
            public String NoCredito { get; set; }
            public String FormaPagoCTABancariaBBVA { get; set; }
            public String FormaPagoReferenciaConceptoPagoBBVA { get; set; }
            public String FormaPagoReferenciaOxxo { get; set; }
            public String FormaPagoBancoInstitucionOtros { get; set; }
            public String FormaPagoClabeOtros { get; set; }
            public String ConceptoMotivoPagoOtros { get; set; }
        }
        public class InputSolicitud
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            //Datos complementarios
            [Key]
            public string NoPagare { get; set; }
            public string TipoCredito { get; set; }
            public string DestinoCredito { get; set; }
            public string Fecha { get; set; }
            public string Nombres { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string SexoMasculino { get; set; }
            public string SexoFemenino { get; set; }
            public string Edad { get; set; }
            public string Rfc { get; set; }
            public string FechaNacimiento { get; set; }
            public string EntidadFederativaNacimiento { get; set; }
            public string PaisNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Curp { get; set; }
            public string FolioIne { get; set; }
            public string ClaveElector { get; set; }
            public string CorreoEletronico { get; set; }
            public string Telefono1 { get; set; }
            public string Telefono2 { get; set; }
            public string DomicilioParticularCalleNumero { get; set; }
            public string Colonia { get; set; }
            public string CP { get; set; }
            public string MunicipioPoblacionEstadoPais { get; set; }
            public string TiempoResidencia { get; set; }
            public string EsPropia { get; set; }
            public string EsRentada { get; set; }
            public string EsPrestada { get; set; }
            public string EsViveConPadres { get; set; }
            public string EsOtra { get; set; }
            public string EstaLibre { get; set; }
            public string EstaGravada { get; set; }
            public string NombreArrendador { get; set; }
            public string DomicilioArrendador { get; set; }
            public string TelefonoArrendador { get; set; }
            public string EdoCivilSoltero { get; set; }
            public string EdoCivilCasado { get; set; }
            public string EdoCivilDivorciado { get; set; }
            public string EdoCivilViudo { get; set; }
            public string EdoCivilUnionLibre { get; set; }
            public string DependientesEconomicos { get; set; }
            public string NombreConyuge { get; set; }
            public string ApellidoPaternoConyuge { get; set; }
            public string ApellidoMaternoConyuge { get; set; }
            public string SexoMasculinoConyuge { get; set; }
            public string SexoFemeninoConyuge { get; set; }
            public string EdadConyuge { get; set; }
            public string RfcConyuge { get; set; }
            public string FechaNacimientoConyuge { get; set; }
            public string EntidadFederativaNacimientoConyuge { get; set; }
            public string PaisNacimientoConyuge { get; set; }
            public string NacionalidadConyuge { get; set; }
            public string CurpConyuge { get; set; }
            public string FolioIneConyuge { get; set; }
            public string ClaveElectorConyuge { get; set; }
            public string CorreoEletronicoConyuge { get; set; }
            public string Telefono1Conyuge { get; set; }
            public string Telefono2Conyuge { get; set; }
            public string NombreReferencia1 { get; set; }
            public string DomicilioReferencia1 { get; set; }
            public string TelefonoReferencia1 { get; set; }
            public string NombreReferencia2 { get; set; }
            public string DomicilioReferencia2 { get; set; }
            public string TelefonoReferencia2 { get; set; }
            public string NombreEmpresaSolic { get; set; }
            public string ActividadGiroSolic { get; set; }
            public string TipoEmpleadoSolic { get; set; }
            public string EscolaridadSolic { get; set; }
            public string DomicilioEmpleoSolic { get; set; }
            public string JefeInmediatoSolic { get; set; }
            public string TelefonoEmpleoSolic { get; set; }
            public string AntiguedadEmpleoSolic { get; set; }
            public string IngresosMensualesEmpleoSolic { get; set; }
            public string OtrosIngresosSolic { get; set; }
            public string ConceptoOtrosIngresosSolic { get; set; }
            public string EntregaRecursosTarjetaBancaria { get; set; }
            public string EntregaRecursosTransferencia { get; set; }
            public string EntregaRecursosCheque { get; set; }
            public string EntregaRecursosVentanilla { get; set; }
            public string EntregaRecursosOtro { get; set; }
            public string DescripcionEntregaRecursosOtro { get; set; }
            public string EntregaRecursosBanco { get; set; }
            public string EntregaRecursosCuentaClabe { get; set; }
            public string CeclarativaOperPropiasSi { get; set; }
            public string CeclarativaOperPropiasNo { get; set; }
            public string CeclarativaOperPropiasPropietarioReal { get; set; }
            public string CeclarativaPepsSi { get; set; }
            public string CeclarativaPepsNo { get; set; }
            public string CeclarativaPepsNombreFuncionario { get; set; }
            public string CeclarativaPepsCargo { get; set; }
            public string CeclarativaPepsParentesco { get; set; }
            public string CeclarativaPepsPeriodo { get; set; }
            public string NombreFirmaDeclarativas { get; set; }
            public string NombreClienteConsultaSIC { get; set; }
            public string RfcCurpConsultaSIC { get; set; }
            public string DomicilioCompletoConsultaSIC { get; set; }
            public string LugarFechaFirmaConsultaSIC { get; set; }
            public string NombreFirmaClienteConsultaSIC { get; set; }
            public string NombreFirmaClientePublicitarios { get; set; }
            public string NombreFirmaDeclaratoriaUsoRecursos { get; set; }
            public string MontoPresupuestoMejora { get; set; }
            public string NombreFirmaPresupuestoMejora { get; set; }
            public string NumPagareDomicilacion { get; set; }
            public string ProductoDomiciliacion { get; set; }
            public string FechaOperacionDomiciliacion { get; set; }
            public string FechaVencimientoDomiciliacion { get; set; }
            public Int32 NumeroPagosDomiciliacion { get; set; }
            public string PeridicidadDomiciliacion { get; set; }
            public string CantidadPagosnumeroyletrasDomiciliacion { get; set; }
            public string BancoDomicilacion { get; set; }
            public string NumeroClabeDomiciliacion { get; set; }
            public string MovilAsociadoDomiciliacion { get; set; }
            public string NumeroTarjetaDebitoDomiciliacion { get; set; }
            public string FechaFirmaDomiciliacion { get; set; }
            public string FechaFirmaAvisoPriovacidad { get; set; }
            public string NombreFirmaAvisoPrivacidad { get; set; }
            public string NombrePromotor { get; set; }

            //Nuevos datos
            public string bienesCasaValor { get; set; }
            public string bienesCasaSaldoHipoteca { get; set; }
            public string bienesCasaEmpresaFinanciadora { get; set; }
            public string bienesCasaTelefono { get; set; }
            public string bienesCasaValorRentaHipoteca { get; set; }
            public string bienesAutoSiTiene { get; set; }
            public string bienesAutoNoTiene { get; set; }
            public string bienesAutoPropio { get; set; }
            public string bienesAutoPagandolo { get; set; }
            public string bienesAutoMarca { get; set; }
            public string bienesAutoModelo { get; set; }
            public string bienesAutoSeguroSi { get; set; }
            public string bienesAutoSeguroNo { get; set; }
            public string bienesAutoSaldo { get; set; }
            public string bienesAutoMensualidad { get; set; }
            public string bienesAutoEmpresaFinanciadora { get; set; }
            public string bienesAutoTelefono { get; set; }
            public string conyugeEmpleoNombreEmpresa { get; set; }
            public string conyugeEmpleoPuesto { get; set; }
            public string conyugeEscolaridad { get; set; }
            public string conyugeEmpleoDomicilio { get; set; }
            public string conyugeEmpleoJefeInmediato { get; set; }
            public string conyugeEmpleoTelefono { get; set; }
            public string conyugeEmpleoAntiguedad { get; set; }
            public string conyugeEmpleoIngresosMensuales { get; set; }
            public string conyugeEmpleoOtrosIngresos { get; set; }
            public string conyugeEmpleoConceptoOtrosIngresos { get; set; }

        }
        public class InputSolicitudMejoramiento
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            //Datos complementarios
            [Key]
            public string NoPagare { get; set; }
            public string TipoCredito { get; set; }
            public string DestinoCredito { get; set; }
            public string Fecha { get; set; }
            public string Nombres { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string SexoMasculino { get; set; }
            public string SexoFemenino { get; set; }
            public string Edad { get; set; }
            public string Rfc { get; set; }
            public string FechaNacimiento { get; set; }
            public string EntidadFederativaNacimiento { get; set; }
            public string PaisNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Curp { get; set; }
            public string FolioIne { get; set; }
            public string ClaveElector { get; set; }
            public string CorreoEletronico { get; set; }
            public string Telefono1 { get; set; }
            public string Telefono2 { get; set; }
            public string DomicilioParticularCalleNumero { get; set; }
            public string Colonia { get; set; }
            public string CP { get; set; }
            public string MunicipioPoblacionEstadoPais { get; set; }
            public string TiempoResidencia { get; set; }
            public string EsPropia { get; set; }
            public string EsRentada { get; set; }
            public string EsPrestada { get; set; }
            public string EsViveConPadres { get; set; }
            public string EsOtra { get; set; }
            public string EstaLibre { get; set; }
            public string EstaGravada { get; set; }
            public string NombreArrendador { get; set; }
            public string DomicilioArrendador { get; set; }
            public string TelefonoArrendador { get; set; }
            public string EdoCivilSoltero { get; set; }
            public string EdoCivilCasado { get; set; }
            public string EdoCivilDivorciado { get; set; }
            public string EdoCivilViudo { get; set; }
            public string EdoCivilUnionLibre { get; set; }
            public string DependientesEconomicos { get; set; }
            public string NombreConyuge { get; set; }
            public string ApellidoPaternoConyuge { get; set; }
            public string ApellidoMaternoConyuge { get; set; }
            public string SexoMasculinoConyuge { get; set; }
            public string SexoFemeninoConyuge { get; set; }
            public string EdadConyuge { get; set; }
            public string RfcConyuge { get; set; }
            public string FechaNacimientoConyuge { get; set; }
            public string EntidadFederativaNacimientoConyuge { get; set; }
            public string PaisNacimientoConyuge { get; set; }
            public string NacionalidadConyuge { get; set; }
            public string CurpConyuge { get; set; }
            public string FolioIneConyuge { get; set; }
            public string ClaveElectorConyuge { get; set; }
            public string CorreoEletronicoConyuge { get; set; }
            public string Telefono1Conyuge { get; set; }
            public string Telefono2Conyuge { get; set; }
            public string NombreReferencia1 { get; set; }
            public string DomicilioReferencia1 { get; set; }
            public string TelefonoReferencia1 { get; set; }
            public string NombreReferencia2 { get; set; }
            public string DomicilioReferencia2 { get; set; }
            public string TelefonoReferencia2 { get; set; }
            public string NombreEmpresaSolic { get; set; }
            public string ActividadGiroSolic { get; set; }
            public string TipoEmpleadoSolic { get; set; }
            public string EscolaridadSolic { get; set; }
            public string DomicilioEmpleoSolic { get; set; }
            public string JefeInmediatoSolic { get; set; }
            public string TelefonoEmpleoSolic { get; set; }
            public string AntiguedadEmpleoSolic { get; set; }
            public string IngresosMensualesEmpleoSolic { get; set; }
            public string OtrosIngresosSolic { get; set; }
            public string ConceptoOtrosIngresosSolic { get; set; }
            public string EntregaRecursosTarjetaBancaria { get; set; }
            public string EntregaRecursosTransferencia { get; set; }
            public string EntregaRecursosCheque { get; set; }
            public string EntregaRecursosVentanilla { get; set; }
            public string EntregaRecursosOtro { get; set; }
            public string DescripcionEntregaRecursosOtro { get; set; }
            public string EntregaRecursosBanco { get; set; }
            public string EntregaRecursosCuentaClabe { get; set; }
            public string CeclarativaOperPropiasSi { get; set; }
            public string CeclarativaOperPropiasNo { get; set; }
            public string CeclarativaOperPropiasPropietarioReal { get; set; }
            public string CeclarativaPepsSi { get; set; }
            public string CeclarativaPepsNo { get; set; }
            public string CeclarativaPepsNombreFuncionario { get; set; }
            public string CeclarativaPepsCargo { get; set; }
            public string CeclarativaPepsParentesco { get; set; }
            public string CeclarativaPepsPeriodo { get; set; }
            public string NombreFirmaDeclarativas { get; set; }
            public string NombreClienteConsultaSIC { get; set; }
            public string RfcCurpConsultaSIC { get; set; }
            public string DomicilioCompletoConsultaSIC { get; set; }
            public string LugarFechaFirmaConsultaSIC { get; set; }
            public string NombreFirmaClienteConsultaSIC { get; set; }
            public string NombreFirmaClientePublicitarios { get; set; }
            public string NombreFirmaDeclaratoriaUsoRecursos { get; set; }
            public string MontoPresupuestoMejora { get; set; }
            public string NombreFirmaPresupuestoMejora { get; set; }
            public string NumPagareDomicilacion { get; set; }
            public string ProductoDomiciliacion { get; set; }
            public string FechaOperacionDomiciliacion { get; set; }
            public string FechaVencimientoDomiciliacion { get; set; }
            //public Int32 NumeroPagosDomiciliacion { get; set; }

            public string PeridicidadDomiciliacion { get; set; }
            public string CantidadPagosnumeroyletrasDomiciliacion { get; set; }
            public string BancoDomicilacion { get; set; }
            //public string NumeroClabeDomiciliacion { get; set; }
            //public string? MovilAsociadoDomiciliacion { get; set; }
            //public string NumeroTarjetaDebitoDomiciliacion { get; set; }
            public string FechaFirmaDomiciliacion { get; set; }
            public string FechaFirmaAvisoPriovacidad { get; set; }
            public string NombreFirmaAvisoPrivacidad { get; set; }
            public string NombrePromotor { get; set; }

            //Nuevos datos
            public string bienesCasaValor { get; set; }
            public string bienesCasaSaldoHipoteca { get; set; }
            public string bienesCasaEmpresaFinanciadora { get; set; }
            public string bienesCasaTelefono { get; set; }
            public string bienesCasaValorRentaHipoteca { get; set; }
            public string bienesAutoSiTiene { get; set; }
            public string bienesAutoNoTiene { get; set; }
            public string bienesAutoPropio { get; set; }
            public string bienesAutoPagandolo { get; set; }
            public string bienesAutoMarca { get; set; }
            public string bienesAutoModelo { get; set; }
            public string bienesAutoSeguroSi { get; set; }
            public string bienesAutoSeguroNo { get; set; }
            public string bienesAutoSaldo { get; set; }
            public string bienesAutoMensualidad { get; set; }
            public string bienesAutoEmpresaFinanciadora { get; set; }
            public string bienesAutoTelefono { get; set; }
            public string conyugeEmpleoNombreEmpresa { get; set; }
            public string conyugeEmpleoPuesto { get; set; }
            public string conyugeEscolaridad { get; set; }
            public string conyugeEmpleoDomicilio { get; set; }
            public string conyugeEmpleoJefeInmediato { get; set; }
            public string conyugeEmpleoTelefono { get; set; }
            public string conyugeEmpleoAntiguedad { get; set; }
            public string conyugeEmpleoIngresosMensuales { get; set; }
            public string conyugeEmpleoOtrosIngresos { get; set; }
            public string conyugeEmpleoConceptoOtrosIngresos { get; set; }

        }

        public class InputArticulosLegales
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }
        public class InputPresupuestoObra
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            //Datos complementarios
            [Key]
            public string municipioEstado { get; set; }
            public string diaFecha { get; set; }
            public string mesFecha { get; set; }
            public string anioFecha { get; set; }
            public string presupuestoSolucion { get; set; }
            public string nombreCliente { get; set; }

        }
        public class InputProyeccionObra
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            //Datos complementarios
            [Key]
            public string municipioEstado { get; set; }
            public string diaFecha { get; set; }
            public string mesFecha { get; set; }
            public string anioFecha { get; set; }
            public string nombreCliente { get; set; }
            public string domicilioCalleNumero { get; set; }
            public string colonia { get; set; }
            public string municipio { get; set; }
            public string estado { get; set; }
            public string codigoPostal { get; set; }

        }
        public class InputCartaEntrega
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            //Datos complementarios
            [Key]
            public string domicilioCalleNumero { get; set; }
            public string domicilioColonia { get; set; }
            public string domicilioMunicipio { get; set; }
            public string domicilioEstado { get; set; }
            public string domicilioCodigoPostal { get; set; }
            public string nombreCliente { get; set; }

        }
        public class CodigoProducto
        {
            [Key]
            public string Cod_Producto { get; set; }


        }

        //Domiciliado
        public class InputSolicitudDomiciliado
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }
            //Datos complementarios
            [Key]
            public string NoPagare { get; set; }
            public string TipoCredito { get; set; }
            public string DestinoCredito { get; set; }
            public string Fecha { get; set; }
            public string Nombres { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string SexoMasculino { get; set; }
            public string SexoFemenino { get; set; }
            public string Edad { get; set; }
            public string Rfc { get; set; }
            public string FechaNacimiento { get; set; }
            public string EntidadFederativaNacimiento { get; set; }
            public string PaisNacimiento { get; set; }
            public string Nacionalidad { get; set; }
            public string Curp { get; set; }
            public string FolioIne { get; set; }
            public string ClaveElector { get; set; }
            public string CorreoEletronico { get; set; }
            public string Telefono1 { get; set; }
            public string Telefono2 { get; set; }
            public string DomicilioParticularCalleNumero { get; set; }
            public string Colonia { get; set; }
            public string CP { get; set; }
            public string MunicipioPoblacionEstadoPais { get; set; }
            public string TiempoResidencia { get; set; }
            public string EsPropia { get; set; }
            public string EsRentada { get; set; }
            public string EsPrestada { get; set; }
            public string EsViveConPadres { get; set; }
            public string EsOtra { get; set; }
            public string EstaLibre { get; set; }
            public string EstaGravada { get; set; }
            public string NombreArrendador { get; set; }
            public string DomicilioArrendador { get; set; }
            public string TelefonoArrendador { get; set; }
            public string EdoCivilSoltero { get; set; }
            public string EdoCivilCasado { get; set; }
            public string EdoCivilDivorciado { get; set; }
            public string EdoCivilViudo { get; set; }
            public string EdoCivilUnionLibre { get; set; }
            public string DependientesEconomicos { get; set; }
            public string NombreConyuge { get; set; }
            public string ApellidoPaternoConyuge { get; set; }
            public string ApellidoMaternoConyuge { get; set; }
            public string SexoMasculinoConyuge { get; set; }
            public string SexoFemeninoConyuge { get; set; }
            public string EdadConyuge { get; set; }
            public string RfcConyuge { get; set; }
            public string FechaNacimientoConyuge { get; set; }
            public string EntidadFederativaNacimientoConyuge { get; set; }
            public string PaisNacimientoConyuge { get; set; }
            public string NacionalidadConyuge { get; set; }
            public string CurpConyuge { get; set; }
            public string FolioIneConyuge { get; set; }
            public string ClaveElectorConyuge { get; set; }
            public string CorreoEletronicoConyuge { get; set; }
            public string Telefono1Conyuge { get; set; }
            public string Telefono2Conyuge { get; set; }
            public string NombreReferencia1 { get; set; }
            public string DomicilioReferencia1 { get; set; }
            public string TelefonoReferencia1 { get; set; }
            public string NombreReferencia2 { get; set; }
            public string DomicilioReferencia2 { get; set; }
            public string TelefonoReferencia2 { get; set; }
            public string NombreEmpresaSolic { get; set; }
            public string ActividadGiroSolic { get; set; }
            public string TipoEmpleadoSolic { get; set; }
            public string EscolaridadSolic { get; set; }
            public string DomicilioEmpleoSolic { get; set; }
            public string JefeInmediatoSolic { get; set; }
            public string TelefonoEmpleoSolic { get; set; }
            public string AntiguedadEmpleoSolic { get; set; }
            public string IngresosMensualesEmpleoSolic { get; set; }
            public string OtrosIngresosSolic { get; set; }
            public string ConceptoOtrosIngresosSolic { get; set; }
            public string EntregaRecursosTarjetaBancaria { get; set; }
            public string EntregaRecursosTransferencia { get; set; }
            public string EntregaRecursosCheque { get; set; }
            public string EntregaRecursosVentanilla { get; set; }
            public string EntregaRecursosOtro { get; set; }
            public string DescripcionEntregaRecursosOtro { get; set; }
            public string EntregaRecursosBanco { get; set; }
            public string EntregaRecursosCuentaClabe { get; set; }
            public string CeclarativaOperPropiasSi { get; set; }
            public string CeclarativaOperPropiasNo { get; set; }
            public string CeclarativaOperPropiasPropietarioReal { get; set; }
            public string CeclarativaPepsSi { get; set; }
            public string CeclarativaPepsNo { get; set; }
            public string CeclarativaPepsNombreFuncionario { get; set; }
            public string CeclarativaPepsCargo { get; set; }
            public string CeclarativaPepsParentesco { get; set; }
            public string CeclarativaPepsPeriodo { get; set; }
            public string NombreFirmaDeclarativas { get; set; }
            public string NombreClienteConsultaSIC { get; set; }
            public string RfcCurpConsultaSIC { get; set; }
            public string DomicilioCompletoConsultaSIC { get; set; }
            public string LugarFechaFirmaConsultaSIC { get; set; }
            public string NombreFirmaClienteConsultaSIC { get; set; }
            public string NombreFirmaClientePublicitarios { get; set; }
            public string NombreFirmaDeclaratoriaUsoRecursos { get; set; }
            public string MontoPresupuestoMejora { get; set; }
            public string NombreFirmaPresupuestoMejora { get; set; }
            public string NumPagareDomicilacion { get; set; }
            public string ProductoDomiciliacion { get; set; }
            public string FechaOperacionDomiciliacion { get; set; }
            public string FechaVencimientoDomiciliacion { get; set; }
            public Int32 NumeroPagosDomiciliacion { get; set; }
            public string PeridicidadDomiciliacion { get; set; }
            public string CantidadPagosnumeroyletrasDomiciliacion { get; set; }
            public string BancoDomicilacion { get; set; }
            public string NumeroClabeDomiciliacion { get; set; }
            public string MovilAsociadoDomiciliacion { get; set; }
            public string NumeroTarjetaDebitoDomiciliacion { get; set; }
            public string FechaFirmaDomiciliacion { get; set; }
            public string FechaFirmaAvisoPriovacidad { get; set; }
            public string NombreFirmaAvisoPrivacidad { get; set; }
            public string NombrePromotor { get; set; }

            //Nuevos datos
            public string bienesCasaValor { get; set; }
            public string bienesCasaSaldoHipoteca { get; set; }
            public string bienesCasaEmpresaFinanciadora { get; set; }
            public string bienesCasaTelefono { get; set; }
            public string bienesCasaValorRentaHipoteca { get; set; }
            public string bienesAutoSiTiene { get; set; }
            public string bienesAutoNoTiene { get; set; }
            public string bienesAutoPropio { get; set; }
            public string bienesAutoPagandolo { get; set; }
            public string bienesAutoMarca { get; set; }
            public string bienesAutoModelo { get; set; }
            public string bienesAutoSeguroSi { get; set; }
            public string bienesAutoSeguroNo { get; set; }
            public string bienesAutoSaldo { get; set; }
            public string bienesAutoMensualidad { get; set; }
            public string bienesAutoEmpresaFinanciadora { get; set; }
            public string bienesAutoTelefono { get; set; }
            public string conyugeEmpleoNombreEmpresa { get; set; }
            public string conyugeEmpleoPuesto { get; set; }
            public string conyugeEscolaridad { get; set; }
            public string conyugeEmpleoDomicilio { get; set; }
            public string conyugeEmpleoJefeInmediato { get; set; }
            public string conyugeEmpleoTelefono { get; set; }
            public string conyugeEmpleoAntiguedad { get; set; }
            public string conyugeEmpleoIngresosMensuales { get; set; }
            public string conyugeEmpleoOtrosIngresos { get; set; }
            public string conyugeEmpleoConceptoOtrosIngresos { get; set; }

        }
        public class InputContratoDomiciliado
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public String numeroContrato { get; set; }
            public String RepresentanteLegal { get; set; }
            public String ClienteNomCompleto { get; set; }
            public String SucursalDomicilio { get; set; }
            public String SucursalColonia { get; set; }
            public String SucursalCP { get; set; }
            public String TasaInsoluta { get; set; }
            public String CreditoTipoPeriodicidad { get; set; }
            public String TasaMora { get; set; }
            public String CreditoTotal { get; set; }
            public String CreditoTotalLetra { get; set; }
            public String CreditoPlazo { get; set; }
            public String CreditoNoPagos { get; set; }
            public String CreditoTipoCredito { get; set; }
            public String CreditoMontoParcialidad { get; set; }
            public String CreditoMontoParcialidadLetra { get; set; }
            public String ComisionPagoFijo { get; set; }
            public String ComisionPagoFijoLetra { get; set; }
            public String PorcentajeComision { get; set; }
            public String ReferenciaBanco { get; set; }
            public String SucursalMunicipio { get; set; }
            public String SucursalEstado { get; set; }
            public String CreditoMaximoCtaCorrriente { get; set; }
            public String CreditoMaximoCtaCorrrienteLetra { get; set; }
            public String EsCheque { get; set; }
            public String EsTarjeta { get; set; }
            public String BancoCuenta { get; set; }
            public String BancoCliente { get; set; }
            public String EsTransferencia { get; set; }
            public String BancoClabe { get; set; }
            public String BancoClienteClabe { get; set; }
            public String EspagoVentanilla { get; set; }
            public String MunicipioFirma { get; set; }
            public String MunicipioEstado { get; set; }
            public String DiaDispersion { get; set; }
            public String MesDispersion { get; set; }
            public String AnioDispersion { get; set; }
        }
        public class InputCaratulaDomiciliacion
        {
            [NotMapped]
            public string? TipoExpediente { get; set; }
            [NotMapped]
            public string? TipoSubExpediente { get; set; }
            [NotMapped]
            public string? formato { get; set; }
            [NotMapped]
            public string? Version { get; set; }

            [Key]
            public decimal CAT { get; set; }
            public double TasaInsolutra { get; set; }
            public double TasaMoraa { get; set; }
            public decimal MontoLineaCredito { get; set; }
            public String MontoTotalPagar { get; set; }
            public String CreditoPeriodicidad { get; set; }
            public Int32 CreditoPlazo { get; set; }
            public String ClienteNombreCompleto { get; set; }

        }
        public class InputArticulosLegalesDomiciliacion
        {
            [NotMapped]
            public string TipoExpediente { get; set; }
            [NotMapped]
            public string TipoSubExpediente { get; set; }
            [NotMapped]

            public string formato { get; set; }
            [NotMapped]
            public string Version { get; set; }

        }

        public class InputConceptosDomiciliacion
        {
            [NotMapped]
            public string TipoExpediente { get; set; }
            [NotMapped]
            public string TipoSubExpediente { get; set; }
            [NotMapped]
            public string formato { get; set; }
            [NotMapped]
            public string Version { get; set; }
            [Key]
            public string conceptosNombre { get; set; }

        }
        public class InputIntegracionPreeliminarDomiciliacion
        {
            [NotMapped]
            public string TipoExpediente { get; set; }
            [NotMapped]
            public string TipoSubExpediente { get; set; }
            [NotMapped]
            public string formato { get; set; }
            [NotMapped]
            public string Version { get; set; }
            [Key]
            public string sucursalNombreEstado { get; set; }
            public string asesorNombre { get; set; }
            public string noCliente { get; set; }
            public string noPagare { get; set; }
            public string entregaRecursosTransferencia { get; set; }
            public string entregaRecursosCheque { get; set; }
            public string entregaRecursosVentanilla { get; set; }
            public string entregaRecursosTarjetaBancaria { get; set; }
            public string EntregaRecursosOtro { get; set; }
            public string acreditadoNombre { get; set; }
            public string acreditadoTelefono { get; set; }
            public string referencia1nombre { get; set; }
            public string referencia1Telefono { get; set; }
            public string referencia2nombre { get; set; }
            public string referencia2Telefono { get; set; }
            public string referencia3nombre { get; set; }
            public string referencia3Telefono { get; set; }


        }
        public class InputCheckListDomiciliacion
        {
            [NotMapped]
            public string TipoExpediente { get; set; }
            [NotMapped]
            public string TipoSubExpediente { get; set; }
            [NotMapped]
            public string formato { get; set; }
            [NotMapped]
            public string Version { get; set; }
            [Key]

            public string checklistNombre { get; set; }
            public string checklistFecha { get; set; }
            public string checklistNumeroCredito { get; set; }
            public string checklistProducto { get; set; }
            public string checklistSucursal { get; set; }
            public string cheklistPlaza { get; set; }



        }

    
}
}