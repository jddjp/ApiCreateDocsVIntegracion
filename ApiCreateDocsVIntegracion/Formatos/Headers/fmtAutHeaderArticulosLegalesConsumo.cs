using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtAutHeaderArticulosLegalesConsumo
    {
        public string strDocumento;

        public string FormatoHTML(InputData data,string logo)
        {



            strDocumento += @"<html>                                                                                                                    ";
            strDocumento += @"<head>                                                                                                                    ";
            strDocumento += @"</head>                                                                                                                   ";
            strDocumento += @"<body style=""text-align: justify;"">                                                                                     ";
            strDocumento += "<table width='100%' height='100%'>                                                                                                                                                                         ";
            strDocumento += "<tr>                                                                                                                                                ";
            strDocumento += "     <td width='10%'>                                                                                                                                                                            ";
            strDocumento += "          <img src='" + logo + "' width='133' height='65' />                                                                                                                                                                    ";
            strDocumento += "      </td>                                                                                                                                                                ";
            strDocumento += "      <td width='90%'>                                                                                                                                                                     ";
            strDocumento += "                                                                                                                                                                   ";
            strDocumento += "               <b><p align='center' class='b'>CONTENIDO DE ARTÍCULOS LEGALES MENCIONADOS EN EL CONTRATO DE ADHESIÓN </p>   </b>                                                                                                                                               ";
            strDocumento += "                                                                                                                                                                      ";
            strDocumento += "       </td>                                                                                                                                                         ";
            strDocumento += "                                                                                                                                                                            ";
            strDocumento += "</tr>                                                                                                                                                                        ";
            strDocumento += "                                                                                                                                                                               ";
            strDocumento += "              </table>                                                                                                                                                                      ";
            strDocumento += @"                                                                                                     ";
            strDocumento += @"</body>                                                                                                                   ";
            strDocumento += @"</html>                                                                                                                        "; 


            return strDocumento;
        }
    }
}
