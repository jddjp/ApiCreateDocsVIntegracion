﻿using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            strDocumento += @"            font-size: 12px;                                                                                              ";
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
            strDocumento += @"            <td><p>" + data.dataTAmortizacion.FechadeOtorgamiento + "<br>" + data.dataTAmortizacion.FechadeVencimiento + "</p></td>                                       ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"    </table>                                                                                                              ";
            strDocumento += @"    <table>                                                                                                               ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""200px""><b>No de Pagare</b></td>                                                                  ";
            strDocumento += @"            <td>" + data.dataTAmortizacion.NodePagare + "</td>                                                                                    ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Monto de Renovación:</b></td>                                                                          ";
            strDocumento += @"            <td>$ " + data.dataTAmortizacion.MontodeRenovación + "</td>                                                                           ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Tipo de Crédito:</b></td>                                                                              ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                <p class=""b"">                                                                                           ";
            strDocumento += @"                    " + data.dataTAmortizacion.TipodeCredito + "                                                                                  ";
            strDocumento += @"<p>                                                                                                                       ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"    </table>                                                                                                              ";
            strDocumento += @"    <p><b>Cliente</b></p>                                                                                                 ";
            strDocumento += @"    <table>                                                                                                               ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""200px""><b>Nombre Cliente:</b></td>                                                               ";
            strDocumento += @"            <td>" + data.dataTAmortizacion.NombreCliente + "</td>                                                                                 ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td width=""100px""><b>Domicilio:</b></td>                                                                    ";
            strDocumento += @"            <td>" + data.dataTAmortizacion.Domicilio + "</td>                                                                                     ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Colonia:</b></td>                                                                                      ";
            strDocumento += @"            <td>" + data.dataTAmortizacion.Colonia + "</td>                                                                                       ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Ciudad:</b></td>                                                                                       ";
            strDocumento += @"            <td>" + data.dataTAmortizacion.Ciudad + "</td>                                                                                        ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td><b>Telefono:</b></td>                                                                                     ";
            strDocumento += @"            <td>" + data.dataTAmortizacion.Telefono + "</td>                                                                                      ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"    </table>                                                                                                              ";
            strDocumento += @"    <p align=""center"" class=""b""><b>TABLA DE AMORTIZACIÓNES</b></p>                                                    ";
            strDocumento += @"    <DIV align=""center"">                                                                                                ";
            strDocumento += @"        <table>                                                                                                           ";
            strDocumento += @"            <tr style=""background-color: #4682b4"">                                                                      ";
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
            strDocumento += @"                                                                                                                          ";
            strDocumento += @"                @foreach (var item in " + data.dataTAmortizacion.listTamortizacion + ")                                                           ";
            strDocumento += @"                {                                                                                                         ";
            strDocumento += @"        <tr>                                                                                                              ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.inicio                                                                                              ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.vencimiento                                                                                         ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.saldoInicial                                                                                        ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.capital                                                                                             ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.interes                                                                                             ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.iva                                                                                                 ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.subtotal                                                                                            ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.comision                                                                                            ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.seguro                                                                                              ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.pago                                                                                                ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"            <td>                                                                                                          ";
            strDocumento += @"                @item.saldoInicial                                                                                        ";
            strDocumento += @"            </td>                                                                                                         ";
            strDocumento += @"        </tr>                                                                                                             ";
            strDocumento += @"            }                                                                                                             ";
            strDocumento += @"         </table>                                                                                                         ";
            strDocumento += @"        <hr>                                                                                                              ";
            strDocumento += @"        <p class=""b"">                                                                                                   ";
            strDocumento += @"            <b>                                                                                                           ";
            strDocumento += @"                " + data.dataTAmortizacion.NombreCliente + "                                                                ";
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
