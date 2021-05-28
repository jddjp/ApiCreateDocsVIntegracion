using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtAutFooterContrato
    {
        public string strDocumento;

        public string FormatoHTML(InputData data,string logo)
        {


                                                                                                        
            strDocumento += @"<html>                                                                                                                    ";
            strDocumento += @"<head>                                                                                                                    ";
            strDocumento += @"</head>                                                                                                                   ";
            strDocumento += @"<body style=""text-align: justify;"">                                                                                     ";
            strDocumento += "                                                                                                                                                                     ";
            strDocumento += "                                                                                                                                              ";
            strDocumento += "                                                                                                                                                                               ";
            strDocumento += "                                                                                                                                                                            ";
            strDocumento += "                                                                                                                                                                 ";
            strDocumento += "                                                                                                                                                                      ";
            strDocumento += "                                                                                                                                                               ";
            strDocumento += "                                                                                                                                                           ";
            strDocumento += "                                                                                                                                                                   ";
            strDocumento += "                                                                                                                                                         ";
            strDocumento += "                                                                                                                                                                  ";
            strDocumento += "          <b>  <p align='center' class='b'>NÚMERO DE REGISTRO DE CONTRATOS DE ADHESIÓN: 2028-440-004742/17-00217-0121 </p> </b>                                                                                                                                                                          ";
            strDocumento += "                                                                                                                                                                           ";
            strDocumento += "                                                                                                                                                                     ";
            strDocumento += "                                                                                                                                                                               ";
            strDocumento += "                                                                                                                                                                               ";
            strDocumento += @"                                                                                                     ";
            strDocumento += @"</body>                                                                                                                   ";
            strDocumento += @"</html>                                                                                                                   "; 


            return strDocumento;
        }
    }
}
