using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtAutHeaderContrato
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
            strDocumento += "     <td width='33.3%'>                                                                                                                                                                            ";
            strDocumento += "           <b>  <p align='center' class='b'>Número de Cliente: </p>   </b>                                                                                                                                                                  ";
            strDocumento += "      </td>                                                                                                                                                                ";
            strDocumento += "      <td width='33.3%'>                                                                                                                                                                     ";
            strDocumento += "                <div align='center' >                                                                                                                                                             ";
            strDocumento += "                           <img src='" + logo + "' width='133' height='65' />                                                                                                                                                     ";
            strDocumento += "                 </div>                                                                                                                                                              ";
            strDocumento += "       </td>                                                                                                                                                         ";
            strDocumento += "      <td width='33.3 %'>                                                                                                                                                              ";
            strDocumento += "          <b>  <p align='center' class='b'>Número de Contrato:" + data.dataContratoConsumo.numeroContrato + "  </p>              </b                                                                                                                                                            ";
            strDocumento += "     </td>                                                                                                                                                                          ";
            strDocumento += "</tr>                                                                                                                                                                        ";
            strDocumento += "                                                                                                                                                                               ";
            strDocumento += "              </table>                                                                                                                                                                      ";
            strDocumento += @"                                                                                                     ";
            strDocumento += @"</body>                                                                                                                   ";
            strDocumento += @"</html>                                                                                                                   "; 


            return strDocumento;
        }
    }
}
