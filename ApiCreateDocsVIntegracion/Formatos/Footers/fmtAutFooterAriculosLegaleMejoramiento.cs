using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtAutFooterArticulosLegalesMejormaiento
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
            strDocumento += "          <b>  <p align='center' class='b'>REGISTRO DE CONTRATOS DE ADHESIÓN NÚMERO: 2028-450-034388/01-01123-0321 </p> </b>                                                                                                                                                                          ";
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
