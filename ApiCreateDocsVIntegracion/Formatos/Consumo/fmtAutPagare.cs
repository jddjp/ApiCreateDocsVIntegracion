using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class ConsumofmtfmtPagare
    {
        public string strDocumento;

        public string FormatoHTML(InputData data)
        {


            strDocumento = @"																					";
            strDocumento += @"<!doctype html>                                                                                                                              ";
            strDocumento += @"<html>                                                                                                                                       ";
            strDocumento += @"<head>                                                                                                                                       ";
            strDocumento += @"    <style>                                                                                                                                  ";
            strDocumento += @"        p.b {                                                                                                                                ";
            strDocumento += @"            font-family: Arial;                                                                                                              ";
            strDocumento += @"            font-size: 14px;                                                                                                                 ";
            strDocumento += @"        }                                                                                                                                    ";
            strDocumento += @"                                                                                                                                             ";
            strDocumento += @"        p.negrita {                                                                                                                          ";
            strDocumento += @"            font-family: Arial;                                                                                                              ";
            strDocumento += @"            font-weight: bold;                                                                                                               ";
            strDocumento += @"        }                                                                                                                                    ";
            strDocumento += @"                                                                                                                                             ";
            strDocumento += @"        font.l {                                                                                                                             ";
            strDocumento += @"            font-weight: bold;                                                                                                               ";
            strDocumento += @"        }                                                                                                                                    ";
            strDocumento += @"                                                                                                                                             ";
            strDocumento += @"        font.z {                                                                                                                             ";
            strDocumento += @"            text-align: right;                                                                                                               ";
            strDocumento += @"        }                                                                                                                                    ";
            strDocumento += @"    </style>                                                                                                                                 ";
            strDocumento += @"    <meta name=""tipo_contenido"" content=""text/html;"" http-equiv=""content-type"" charset=""utf-8"">                                      ";
            strDocumento += @"</head>                                                                                                                                      ";
            strDocumento += @"<body style=""text-align: justify;"">                                                                                                        ";
            strDocumento += @"    <p align=""center"">SIN PROTESTO</p>                                                                                                     ";
            strDocumento += @"    <p align=""center""><b>P A G A R É</b></p>                                                                                               ";
            strDocumento += @"    <p align=""left"">NÚMERO DE CONTRATO: <U><b>" + data.dataPagare.NumeroContrato + "</b></U></p>                                                            ";
            strDocumento += @"    <p style=""margin:0;display:inline;float:left"">NUMERO DE PAGARE: <u><b>" + data.dataPagare.NumeroPagare + "</b></u></p>                                  ";
            strDocumento += @"    <p style=""margin:0;display:inline;float:right"">BUENO POR $ <U><b>" + data.dataPagare.Cantidadpagare + "</b></U></p>                                     ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <p class=""b"">                                                                                                                          ";
            strDocumento += @"        <font>                                                                                                                               ";
            strDocumento += @"            POR ESTE PAGARE, DEBO, PROMETO Y ME OBLIGO A PAGAR EN FORMA INCONDICIONAL A LA ORDEN                                             ";
            strDocumento += @"            DE LA PERSONA MORAL DENOMINADA FOMEPADE S.A.P.I. DE C.V. SOFOM E.N.R. O A QUIEN SUS DERECHOS REPRESENTE                          ";
            strDocumento += @"			EN SU DOMICILIO UBICADO                                                                                                            ";
            strDocumento += @"            EN <font class=""l""><ins>BOULEVARD ATLIXCO NO. 3115 INTERIOR 1</ins></font> DE LA COLONIA <u>                                   ";
            strDocumento += @"			<b>NUEVA ANTEQUERA C.P. 72180</b></u> DE LA CIUDAD DE                                                                              ";
            strDocumento += @"            <u><b>PUEBLA PUEBLA MEXICO</b></u>. Y/O EN SU DOMICILIO UBICADO EN: <u><b>" + data.dataPagare.DireccionEmite + "</b></u> COLONIA                  ";
            strDocumento += @"            <u><b>" + data.dataPagare.ColoniaEmite + "</b></u> DE LA CIUDAD DE <u><b>" + data.dataPagare.CiudadEmite + "," + data.dataPagare.PaisEmite + "</b></u>                              ";
            strDocumento += @"			LA CANTIDAD EN EFECTIVO DE <u>                                                                                                     ";
            strDocumento += @"                <b>                                                                                                                          ";
            strDocumento += @"                    " + data.dataPagare.CantidadpagareNumLetras + "                                                                                           ";
            strDocumento += @"                </b>                                                                                                                         ";
            strDocumento += @"            </u>LO CUAL HARE MEDIANTE <u><b>" + data.dataPagare.NumAmortizaciones + "</b></u> PAGOS                                                           ";
            strDocumento += @"            <u><b>" + data.dataPagare.PagosPeridicidad + "</b></u> Y CONSECUTIVOS, CADA UNO DE ELLOS POR LA CANTIDAD DE                                       ";
            strDocumento += @"            <u>                                                                                                                              ";
            strDocumento += @"                <b>                                                                                                                          ";
            strDocumento += @"                    " + data.dataPagare.CantidadPagosnumeroyletras + "                                                                                        ";
            strDocumento += @"                </b>                                                                                                                         ";
            strDocumento += @"            </u>                                                                                                                             ";
            strDocumento += @"            INICIANDO EL PRIMER PAGO, A PARTIR DEL DIA <u><b>" + data.dataPagare.DiaPrimerPago + "</b></u> DEL MES DE <u>                                     ";
            strDocumento += @"			<b>" + data.dataPagare.MesPrimerPago + "</b></u> DEL AÑO <u><b>" + data.dataPagare.AnioPrimerpago + "</b></u> Y VENCIENDO EL                                         ";
            strDocumento += @"            ULTIMO PAGO EL DÍA <u><b>" + data.dataPagare.DiaUltimoPago + "</b></u> DEL MES DE <u><b>" + data.dataPagare.MesUltimoPago + "</b></u>                              ";
            strDocumento += @"			DEL AÑO <u><b>" + data.dataPagare.AnioUltimoPago + "</b></u>.                                                                                       ";
            strDocumento += @"        </font>                                                                                                                              ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p class=""b"">                                                                                                                          ";
            strDocumento += @"        VALOR RECIBIDO EN MONEDA NACIONAL A MI ENTERA SATISFACCIÓN Y CONFORMIDAD. ASÍ MISMO, DE                                              ";
            strDocumento += @"        MANERA EXPRESA ME COMPROMETO A QUE ESTE PAGARE CAUSARÁ INTERESES ORDINARIOS A RAZÓN                                                  ";
            strDocumento += @"        DEL <u><b>" + data.dataPagare.TasaOrdinaria + "</b></u> POR CIENTO ANUAL, POR CADA MES O FRACCIÓN, LOS CUALES DEBERÉ PAGAR                            ";
            strDocumento += @"        CONJUNTAMENTE CON EL CAPITAL ADEUDADO.                                                                                               ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p class=""b"">                                                                                                                          ";
            strDocumento += @"        DE IGUAL FORMA, ME COMPROMETO A QUE EN CASO DE INCUMPLIMIENTO EN EL PAGO DE UNA O MAS                                                ";
            strDocumento += @"        DE LAS AMORTIZACIONES CONVENIDAS, A PAGAR LOS INTERESES MORATORIOS QUE SE GENEREN A                                                  ";
            strDocumento += @"        PARTIR DE LA FECHA DEL INCUMPLIMIENTO Y HASTA QUE EL ADEUDO SEA TOTALMENTE PAGADO A                                                  ";
            strDocumento += @"        FOMEPADE S.A.P.I. DE C.V. SOFOM E.N.R. LOS CUALES SE CAUSARAN SOBRE EL CAPITAL VENCIDO Y                                             ";
            strDocumento += @"        SERÁN CALCULADOS A UNA TASA DE INTERÉS MORATORIO DEL <u><b>" + data.dataPagare.TasaMoratoria + "</b></u> POR CIENTO MENSUAL, POR                      ";
            strDocumento += @"        CADA MES O FRACCIÓN, LOS CUALES DEBO( PAGAR CONJUNTAMENTE CON LAS AMORTIZACIONES DE                                                  ";
            strDocumento += @"        CAPITAL VENCIDO.                                                                                                                     ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <div>                                                                                                                                    ";
            strDocumento += @"        <p class=""b"">                                                                                                                      ";
            strDocumento += @"            QUEDA EXPRESAMENTE CONVENIDO QUE LA FALTA DE PAGO OPORTUNO DE UNO O MAS DE LOS                                                   ";
            strDocumento += @"            PAGOS CONVENIDOS DARA DERECHO A FOMEPADE SAPI DE CV SOFOM ENR A DAR POR VENCIDO                                                  ";
            strDocumento += @"            EN FORMA ANTICIPADA EL PLAZO CONVENIDO Y A EXIGIR YA SEA POR LA VÍA EXTRAJUDICIAL O                                              ";
            strDocumento += @"            JUDICIAL EL PAGO DEL TOTAL DE LA DEUDA EXISTENTE Y SUS ACCESORIOS GENERADOS LO                                                   ";
            strDocumento += @"            ANTERIOR DE CONFORMIDAD CON LO DISPUESTO POR LOS ARTÍCULOS 79 EN RELACIÓN CON EL 174 DE                                          ";
            strDocumento += @"            LA LEY GENERAL DE TITULOS Y OPERACIONES DE CRÉDITO.                                                                              ";
            strDocumento += @"        </p>                                                                                                                                 ";
            strDocumento += @"    </div>                                                                                                                                   ";
            strDocumento += @"    <p class=""b"">                                                                                                                          ";
            strDocumento += @"        DE IGUAL FORMA SE CONVIENE, QUE TODOS LOS ABONOS QUE REALICE EL SUSCRIPTOR DEL PRESENTE PAGARE,                                      ";
            strDocumento += @"        DEBERÁN ESTAR AMPARADOS EN TODOS LOS CASOS, POR EL DESCUENTO DEL CRÉDITO EN LA NÓMINA DEL ACREDITADO,                                ";
            strDocumento += @"        AVAL O SOLIDARIO RESPONSABLE, MISMO QUE ESTE DEBIDAMENTE CUBIERTO A LA FINANCIERA “FOMEPADE S.A.P.I. DE C.V.                         ";
            strDocumento += @"        SOFOM E.N.R.” POR PARTE DE LA ENTIDAD O DEPENDENCIA RETENEDORA, POR EL RECIBO OFICIAL QUE EXPIDA FOMEPADE                            ";
            strDocumento += @"        S.A.P.I. DE C.V. SOFOM E.N.R. O EL DEPÓSITO RECIBIDO EN SU CUENTA BANCARIA EN SU FAVOR, DE LO CONTRARIO NO                           ";
            strDocumento += @"        PODRÁN SER RECONOCIDOS COMO TALES.                                                                                                   ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p class=""b"">                                                                                                                          ";
            strDocumento += @"        LAS PARTES CONVIENEN EN FORMA EXPRESA, QUE EN CASO DE QUE FOMEPADE S.A.P.I. DE C.V. SOFOM E.N.R. INICIE                              ";
            strDocumento += @"        ACCIONES JUDICIALES PARA RECUPERAR EL IMPORTE DEL PRESENTE PAGARE, ASÍ COMO POR CUALQUIER OTRA                                       ";
            strDocumento += @"        CONTROVERSIA QUE LLEGARE A SURGIR, EXPRESAMENTE SE SOMETEN A LOS TRIBUNALES COMPETENTES DE LA CIUDAD                                 ";
            strDocumento += @"        DE <u><b>" + data.dataPagare.CiudadEmite + "</b></u> RENUNCIANDO EL SUSCRIPTOR Y SU AVAL SI LO HUBIERE, A CUALQUIER OTRO DOMICILIO O                  ";
            strDocumento += @"        FUERO QUE PUDIERE CORRESPONDERLES POR RAZÓN DE SUS DOMICILIOS PRESENTES O FUTUROS.                                                   ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <p class=""b""> EL PRESENTE PAGARE SE SUSCRIBE EN LA CIUDAD DE <u><b>" + data.dataPagare.PersonaCiudad + "</b></u>,                                       ";
            strDocumento += @"	EL DÍA <u><b>@DateTime.Now.ToString(""dd"")</b></u> DEL MES DE <u><b>@DateTime.Now.ToString(""MMMM"").ToUpper()</b></u> DEL</p>            ";
            strDocumento += @"    <p class=""b"">AÑO <U><b>@DateTime.Now.ToString(""yyyy"")</b></U>.</p>                                                                   ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <p class=""b"">NOMBRE Y FIRMA DEL SUSCRIPTOR Y/O DEUDOR:</p>                                                                             ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <p class=""b"">                                                                                                                          ";
            strDocumento += @"        FIRMA:<U><b>___________________</b></U><br />                                                                                        ";
            strDocumento += @"        NOMBRE: <U><b>" + data.dataPagare.PersonaNombre + "</b></U><br />                                                                                     ";
            strDocumento += @"        DOMICILIO:<U><b>" + data.dataPagare.PersonaDomicilio + "</b></U><br />                                                                                ";
            strDocumento += @"        COLONIA O FRACCIONAMIENTO:<U><b>" + data.dataPagare.PersonaColonia + "</b></U><br />                                                                  ";
            strDocumento += @"        CIUDAD:<U><b>" + data.dataPagare.PersonaCiudad + "</b></U><br />                                                                                      ";
            strDocumento += @"        TELÉFONO(S):<U><b>" + data.dataPagare.PersonaTelefono + "</b></U> Y <U><b>" + data.dataPagare.PersonaTelefono + "</b></U>                                              ";
            strDocumento += @"    <p />                                                                                                                                    ";
            strDocumento += @"</body>                                                                                                                                      ";
            strDocumento += @"</html> ";
            return strDocumento;
        }
    }
}
