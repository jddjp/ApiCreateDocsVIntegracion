using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class MejoramientofmtfmtCartaEntrega
    {
        public string strDocumento;

        public string FormatoHTML(InputData data)
        {


            strDocumento = @"<html>																																			";
            strDocumento += @"<head>                                                                                                                                       ";
            strDocumento += @"    <style>                                                                                                                                  ";
            strDocumento += @"        p.b {                                                                                                                                ";
            strDocumento += @"            font-family: Arial;                                                                                                              ";
            strDocumento += @"            font-size: 20px;                                                                                                                 ";
            strDocumento += @"            color: #552988;                                                                                                                  ";
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
            strDocumento += @"                                                                                                                                             ";
            strDocumento += @"        p.solid {                                                                                                                            ";
            strDocumento += @"            border-style: ridge;                                                                                                             ";
            strDocumento += @"            font-family: Arial;                                                                                                              ";
            strDocumento += @"            font-size: 12px;                                                                                                                 ";
            strDocumento += @"        }                                                                                                                                    ";
            strDocumento += @"    </style>                                                                                                                                 ";
            strDocumento += @"    <meta name=""tipo_contenido"" content=""text/html;"" http-equiv=""content-type"" charset=""utf-8"">                                      ";
            strDocumento += @"</head>                                                                                                                                      ";
            strDocumento += @"<body style=""text-align: justify;"">                                                                                                        ";
            strDocumento += @"    <p style=""margin-top:0pt; margin-bottom:0pt; text-align:justify; font-size:12pt;"">                                                     ";
            strDocumento += @"	<span style=""height:0pt; text-align:left; display:block; position:absolute; z-index:0;"">                                                 ";
            strDocumento += @"	<img src=""https://myfiles.space/user_files/75531_ee21bbd708a9a111/1611347165_entrega-de-obra/1611347165_entrega-de-obra.002.png""         ";
            strDocumento += @"	width=""337"" height=""57"" alt="""" style=""margin: 0 0 0 auto; text-align: right; display: block; ""></span>                             ";
            strDocumento += @"	<img src=""https://myfiles.space/user_files/75531_ee21bbd708a9a111/1611347165_entrega-de-obra/1611347165_entrega-de-obra.001.png""         ";
            strDocumento += @"	width=""133"" height=""64"" alt=""Descripción: 2013-12-20-18-21-33_Logo Apreicia Hor - Sin Fondo""                                         ";
            strDocumento += @"	style=""float: right; text-align: right; display: inline-block; ""></p>                                                                    ";
            strDocumento += @"    <p style=""margin-top:0pt; margin-bottom:0pt; text-align:right; font-size:11pt;"">                                                       ";
            strDocumento += @"	<span style=""font-family:Calibri; color:#552988;"">&nbsp;</span></p>                                                                      ";
            strDocumento += @"    <p style=""margin-top:0pt; margin-bottom:0pt; text-align:right; font-size:11pt;"">                                                       ";
            strDocumento += @"	<span style=""font-family:Calibri; color:#552988;"">&nbsp;</span></p>                                                                      ";
            strDocumento += @"    <p style=""margin-top:0pt; margin-bottom:0pt; text-align:right; font-size:11pt;"">                                                       ";
            strDocumento += @"	<span style=""font-family:Calibri; color:#552988;"">&nbsp;</span></p>                                                                      ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <p align=""right"" class=""b"">En:______________a_______de____________del______________</p>                                              ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <br>                                                                                                                                     ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        Reunidos  en el  domicilio particular  en Calle <u>" + data.dataCartaEntrega.domicilioCalleNumero + "</u>                                           ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        Col.<u>" + data.dataCartaEntrega.domicilioColonia + "</u> Municipio<u>" + data.dataCartaEntrega.domicilioMunicipio + "</u>- Estado</u>" + data.dataCartaEntrega.domicilioEstado + "</u> C.P. <u>" + data.dataCartaEntrega.domicilioCodigoPostal + "</u>-                                                ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        El Sr. (a)<u>" + data.dataCartaEntrega.nombreCliente + "</u>quien entrega la obra realizada al Sr                                             ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        (a)_____________________________________________, mismo que verifica su estructura y/o                                               ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        funcionamiento de acuerdo a las condiciones pactadas en la “Proyección de Obra” .                                                    ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        Así mismo Yo-__________________________, manifiesto que recibo la obra a entera                                                      ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <p align=""left"" class=""b"">                                                                                                           ";
            strDocumento += @"        satisfacción y dejo constancia en el presente documento.                                                                             ";
            strDocumento += @"    </p>                                                                                                                                     ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <br />                                                                                                                                   ";
            strDocumento += @"    <table>                                                                                                                                  ";
            strDocumento += @"        <tr>                                                                                                                                 ";
            strDocumento += @"            <td width=""500"">                                                                                                               ";
            strDocumento += @"                <p style=""text-align:center;"" class=""b"">Entrega</p>                                                                      ";
            strDocumento += @"               <span style=""font-family:Calibri; color:#552988;"">&nbsp;</span>                                                           ";
            strDocumento += @"				<span style=""font-family:'Arial Black'; color:#552988;"">&nbsp;</span></p>                                                    ";
            strDocumento += @"            <td>                                                                                                                             ";
            strDocumento += @"                <p style=""text-align:center;"" class=""b"">Recibe de conformidad</p>                                                        ";
            strDocumento += @"                                                                                                                                             ";
            strDocumento += @"                <p style=""margin-top:0pt; margin-bottom:0pt; text-align:center; font-size:12pt;"">                                          ";
            strDocumento += @"				<span style=""font-family:Calibri; color:#552988;"">&nbsp;</span>                                                              ";
            strDocumento += @"				<span style=""font-family:Calibri; color:#552988;""></span></p>                                                                ";
            strDocumento += @"            </td>                                                                                                                            ";
            strDocumento += @"        </tr>                                                                                                                                ";
            strDocumento += @"        <tr>                                                                                                                                 ";
            strDocumento += @"            <td width=""500"">                                                                                                               ";
            strDocumento += @"                <p style=""margin-top:0pt; margin-bottom:0pt; text-align:center; font-size:11pt;"">                                          ";
            strDocumento += @"				<span style=""font-family:Calibri; color:#552988;"">&nbsp;</span></p>                                                          ";
            strDocumento += @"                <p style=""margin-top:0pt; margin-bottom:0pt; text-align:center; font-size:11pt;""><u>                                       ";
            strDocumento += @"				<span style=""font-family:Calibri; color:#552988;"">___________________________</span></u></p>                                 ";
            strDocumento += @"                <p style=""text-align:center;"" class=""b"">Nombre Completo y Firma</p>                                                      ";
            strDocumento += @"                <p style=""margin-top:0pt; margin-bottom:0pt; font-size:14pt;"">                                                             ";
            strDocumento += @"				<span style=""font-family:'Arial Black'; color:#552988;"">&nbsp;</span></p>                                                    ";
            strDocumento += @"            <td>                                                                                                                             ";
            strDocumento += @"                <p style=""margin-top:0pt; margin-bottom:0pt; text-align:center; font-size:11pt;""><u>                                       ";
            strDocumento += @"				<span style=""font-family:Calibri; color:#552988;"">___________________________</span></u></p>                                 ";
            strDocumento += @"                <p style=""text-align:center;"" class=""b"">Nombre Completo y Firma</p>                                                      ";
            strDocumento += @"            </td>                                                                                                                            ";
            strDocumento += @"        </tr>                                                                                                                                ";
            strDocumento += @"    </table>                                                                                                                                 ";
            strDocumento += @"</body>                                                                                                                                      ";
            strDocumento += @"</html>         ";

            return strDocumento;
        }
    }
}
