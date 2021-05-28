using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtAutHeaderSolicitudConsumo
    {
        public string strDocumento;

        public string FormatoHTML(InputData data,string logo)
        {


                                                                                                        
            strDocumento += @"<html>                                                                                                                    ";
            strDocumento += @"<head>                                                                                                                    ";
            strDocumento += @"</head>                                                                                                                   ";
            strDocumento += @"<body style=""text-align: justify;"">                                                                                     ";
            strDocumento += "             <nav>                                                                                                                                                            ";
            strDocumento += "                     <h5>SOLICITUD DE CRÉDITO</h5>                                                                                                                 ";
            strDocumento += "                               <h7>NUMERO DE REGISTRO DE CONTRATO DE ADHESIÓN : 2028-440-004742/17-00217-0121 </h7>                                                                                                                                                ";
            strDocumento += "                    </nav>                                                                                                                                           ";
            strDocumento += "                                                                                                                                                                     ";
            strDocumento += "    <p align='right' class='b'>                                                                                                                                                                     ";
            strDocumento += "        No.Cliente:" + "Faltaidpersona" + "<br />                                                                                                                                                            ";
            strDocumento += "        No.Contrato:" + data.dataSolicitud.NoPagare + "                                                                                                                                                                 ";
            strDocumento += "    </p>                                                                                                                                                                                            ";
             strDocumento += "                                                                                                                                                                   ";
            strDocumento += "                                                                                                                                                                         ";
            strDocumento += "                                                                                                                                                                           ";
            strDocumento += "                                                                                                                                                     ";
            strDocumento += "                                                                                                                                                             ";
            strDocumento += "                                                                                                                                                                  ";
            strDocumento += "                                                                                                                                                                             ";
            strDocumento += "                                                                                                                                                                  ";
            strDocumento += "                                                                                                                                                                               ";
            strDocumento += "                                                                                                                                                                           ";
            strDocumento += @"                                                                                                     ";
            strDocumento += @"</body>                                                                                                                   ";
            strDocumento += @"</html>                                                                                                                   "; 


            return strDocumento;
        }
    }
}
