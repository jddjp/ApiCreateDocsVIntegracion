using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static ApiCreacionDocs.Models.InformacionDocs;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtfmtTablaAmortizacion
    {
        public string strDocumento;

        public string FormatoHTML(InputData data,string logo)
        {


            strDocumento = @"													";
            strDocumento += @"<!doctype html>                                                                                                           ";
            strDocumento += @"<html>                                                                                                                    ";
            strDocumento += @"<head>                                                                                                                    ";
            strDocumento += @"    <style>                                                                                                               ";
            strDocumento += @"        p.b {                                                                                                             ";
            strDocumento += @"            font-family: Arial;                                                                                           ";
            strDocumento += @"            font-size: 12pt;                                                                                              ";
            strDocumento += @"        }                                                                                                                 ";
            strDocumento += @"                                                                                                                          ";
            strDocumento += @"        u.b {                                                                                                             ";
            strDocumento += @"            font-family: Arial;                                                                                           ";
            strDocumento += @"            font-size: 12px;                                                                                              ";
            strDocumento += @"        }                                                                                                                 ";
            strDocumento += @"                                                                                                                          ";
            strDocumento += @"        p.negrita {                                                                                                       ";
            strDocumento += @"            font-family: Arial;                                                                                           ";
            strDocumento += @"            font-weight: bold;                                                                                            ";
            strDocumento += @"        }                                                                                                                 ";
            strDocumento += @"                                                                                                                          ";
            strDocumento += @"        font.l {                                                                                                          ";
            strDocumento += @"            font-weight: bold;                                                                                            ";
            strDocumento += @"        }                                                                                                                 ";
            strDocumento += @"                                                                                                                          ";
            strDocumento += @"        font.z {                                                                                                          ";
            strDocumento += @"            text-align: right;                                                                                            ";
            strDocumento += @"        }                                                                                                                 ";
            strDocumento += @"         #tablaamor td {                                                                                                                     ";
            strDocumento += @"               font-family: Arial;                                                                                            ";
            strDocumento += @"              padding: 8px;                                                                                          ";
            strDocumento += @"           font-size: 10pt;                                                                                                            ";
            strDocumento += @"                      text-align: center;       }                                                                                              ";
            strDocumento += @"                                                                                                                   ";
            strDocumento += @"         #tablaamor th {              font-family: Arial;           font-size: 10pt;                                                                                                    ";
            strDocumento += @"             padding-top: 12px;                                                                                                  ";
            strDocumento += @"             padding-bottom: 12px;                                                                                             ";
            strDocumento += @"             text-align: center;                                                                                       ";
            strDocumento += @"             background-color: #4682b4;                                                                                                 ";
            strDocumento += @"             color: black;          }                                                                                    ";
            strDocumento += @"                                                                                                                   ";
            strDocumento += @"                                                                                                                   ";
            strDocumento += @"                                                                                                                   ";

            strDocumento += @"    </style>                                                                                                              ";
            strDocumento += @"</head>                                                                                                                   ";
            strDocumento += @"<body style=""text-align: justify;"">                                                                                     ";
            strDocumento += @"    <table>                                                                                                               ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""550px"">                                                                                          ";
            strDocumento += @"                <img align='left' src='"+logo+"' width='140' height='80' />              ";
            strDocumento += @"                <br>                                                                                                      ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                <p class=""b""><b>Fecha de Otorgamiento:<br>Fecha de Vencimiento:</b></p>                                 ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td><p><u>"+ data.dataTAmortizacion.TablaInfoAmortiza.fechaOperacion + "<br>" + data.dataTAmortizacion.TablaInfoAmortiza.fechaVence + "</u></p></td>                                       ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"    </table>        <br> <br>               <br>                                                                                                         ";
            strDocumento += @"    <table>                                                                                                               ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""200px""><b>No de Cliente:	</b></td>                                                                  ";
            strDocumento += @"            <td> <u>" + data.dataTAmortizacion.TablaInfoAmortiza.idPersona + "</u></td>                                                                                    ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""200px""><b>No de Crédito:</b></td>                                                                          ";
            strDocumento += @"              <td> <u>" + data.dataTAmortizacion.TablaInfoAmortiza.idCredito + "</u></td>                                                                          ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Tipo de Crédito:</b></td>                                                                              ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                <p class=""b""> <u>                                                                                          ";
            strDocumento += @"                    " + data.dataTAmortizacion.TablaInfoAmortiza.producto + "      </u>                                                                            ";
            strDocumento += @"<p>                                                                                                                       ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"    </table>                                                                                                              ";
            strDocumento += @"    <p><b>Cliente</b></p>                                                                                                 ";
            strDocumento += @"    <table>                                                                                                               ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""200px""><b>Nombre Cliente:</b></td>                                                               ";
            strDocumento += @"            <td><u>" + data.dataTAmortizacion.TablaInfoAmortiza.clienteNombre + "</u></td>                                                                                 ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""100px""><b>Domicilio:</b></td>                                                                    ";
            strDocumento += @"            <td><u>" + data.dataTAmortizacion.TablaInfoAmortiza.domicilioCliente + "</u></td>                                                                                     ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Colonia:</b></td>                                                                                      ";
            strDocumento += @"            <td><u>" + data.dataTAmortizacion.TablaInfoAmortiza.coloniaCliente + "</u></td>                                                                                       ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Ciudad:</b></td>                                                                                       ";
            strDocumento += @"            <td><u>" + data.dataTAmortizacion.TablaInfoAmortiza.ciudadCliente + "</u></td>                                                                                        ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Telefono:</b></td>                                                                                     ";
            strDocumento += @"            <td><u>" + data.dataTAmortizacion.TablaInfoAmortiza.telefonoCliente + "</u></td>                                                                                      ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"    </table>                                                                                                              ";
            strDocumento += @"    <p align=""center"" class=""b""><b>TABLA DE AMORTIZACIÓNES</b></p>                                                    ";
            strDocumento += @"    <DIV align=""center"">                                                                                                ";
           
            strDocumento += @"        <table id='tablaamor'  width=""100%"">                                                                                                           ";
            strDocumento += @"            <tr   width=""100%"">                                                                      ";
            strDocumento += @"                <th>No</th>                                                                                               ";
            strDocumento += @"                <th>Inicio</th>                                                                                           ";
            strDocumento += @"                <th>Vencimiento</th>                                                                                      ";
            strDocumento += @"                <th>Saldo Inicial</th>                                                                                    ";
            strDocumento += @"                <th>Capital</th>                                                                                          ";
            strDocumento += @"                <th>Interes</th>                                                                                          ";
            strDocumento += @"                <th>IVA</th>                                                                                              ";
            strDocumento += @"                <th>Subtotal</th>                                                                                         ";
            strDocumento += @"                <th>Comisión</th>                                                                                         ";
            strDocumento += @"                <th>Seguro</th>                                                                                           ";
            strDocumento += @"                <th>Pago</th>                                                                                             ";
            strDocumento += @"                <th>                                                                                                      ";
            strDocumento += @"                    Saldo                                                                                                 ";
            strDocumento += @"                    Final                                                                                                 ";
            strDocumento += @"                </th>                                                                                                     ";
            strDocumento += @"            </tr>                                                                                                         ";

            foreach (TAmortizacion item in data.dataTAmortizacion.ListaTAmortiza)
            {
                

                strDocumento += "<tr  width='100%' >                                                                                  " +
                     "	<td >" + item.No + "</td>                                                                        " +
                     "	<td >" + item.inicio+ "</td>                                                                   " +
                     "	<td >" + item.vencimiento + "</td>                                                                " +
                     "	<td >" + item.saldoInicial + "</td>                                                                  " +
                     "	<td >" + item.capital + "</td>                                                                  " +
                     "	<td >" + item.interes+ "</td>                                                                  " +
                     "	<td >" + item.iva + "</td>                                                               " +
                     "	<td >" + item.subtotal + "</td>                                                                " +
                     "	<td >" + item.comision + "</td>                                                                 " +
                     "	<td >" + item.seguro + "</td>                                                                 " +
                     "	<td >" + item.pago + "</td>                                                                 " +
                      "	<td >" + item.saldoFinal + "</td>                                                                 " +
                     "</tr>                                                                                  ";
            }
            strDocumento += @"         </table>                                                                                                         ";
            strDocumento += @"                                                                                                              ";
            strDocumento += @"             <br>                                                                                                 ";
            strDocumento += @"                  <br>                                                                                                 ";
            strDocumento += @"                                                                                                              ";
            strDocumento += @"        <p class=""b"" align=""left"">                                                                                                   ";
            strDocumento += @"            <b>                                                                                                           ";
            strDocumento += @"               Monto total a pagar:<u>$" + data.dataTAmortizacion.TablaInfoAmortiza.credTotal+" (" + data.dataTAmortizacion.TablaInfoAmortiza.credTotalLetra + "   )     </u>                            ";
            strDocumento += @"            </b>                                                                                                          ";
            strDocumento += @"        </p>                                                                                                              ";
            strDocumento += @"        <p class=""b"" align=""left"">                                                                                                   ";
            strDocumento += @"                                                                                                                ";
            strDocumento += @"              *Cantidad resultante de la suma de los <b>  <u>" + data.dataTAmortizacion.TablaInfoAmortiza.credNumPagos + "</u></b>    pagos periódicos                 ";
            strDocumento += @"                                                                                                                    ";
            strDocumento += @"        </p>                                                                                                              ";
            strDocumento += @"            <br>                                                                                                          ";
            strDocumento += @"              <br>        <br>                                                                                                    ";



            strDocumento += @"        <p class=""b"" >                                                                                                   ";
            strDocumento += @"            <b>                                                                                                           ";
            strDocumento += @"                <u>" + data.dataTAmortizacion.TablaInfoAmortiza.clienteNombreAliasFirma + "        </u>                            ";
            strDocumento += @"            </b>                                                                                                          ";
            strDocumento += @"        </p>                                                                                                              ";
            strDocumento += @"        <p class=""b"">                                                                                                   ";
            strDocumento += @"            <b>Firma Cliente</b>                                                                                          ";
            strDocumento += @"        <p>                                                                                                               ";
            strDocumento += @"    </DIV>                                                                                                                ";
            strDocumento += @"</body>                                                                                                                   ";
            strDocumento += @"</html>                                                                                                                   "; 


            return strDocumento;
        }
    }
}
