using ApiCreacionDocs.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginaWebApp.Models.Formatos
{
    public class fmtfmtCaratula
    {
        public string strDocumento;

        public string FormatoHTML(InputData data, string imgLogo)
        {

            strDocumento = @"

                                        <html>
                                        <head>
                                            <style>
                                                p{
                                                    font-family: calibri;
                                                    font-size: 9pt;
                                                }

                                                p.negrita {
                                                    font-family: Arial;
                                                    font-weight: bold;
                                                }

                                                font.l {
                                                    font-weight: bold;
                                                }

                                                font.z {
                                                    text-align: right;
                                                }

                                                p.solid {
                                                    border-style: groove;
                                                }

                                                table.data, td.data, th {
                                                    border: 1px solid black;
                                                }

                                                table.data {
                                                    width: 100%;
                                                    border-collapse: collapse;
                                                }

                                                table.x, td.x, th.x {
                                                    border: 0px solid black;
                                                }
                                            </style>
                                            <meta name=""+tipo_contenido+"" content=""text/html;"" http-equiv=""content-type"" charset=""utf-8"">
                                        </head>

                                        <body style=""text-align: justify;"">
                                        <div align=""center"" >
                                        <img src='"" + imgLogo + ""' width='133' height='65' />
                                        </div>
                                         <p style=""text-align:CENTER;"">
                                        <b>CARÁTULA DE CRÉDITO</b>
                                         </p>
                                            <table class=""data"" border=""1""  WIDTH=""100%"">
  
                                          <tbody>
                                            <tr>
                                              <td colspan=""4"">
                                              <p><b>Nombre comercial del Producto:</b> Aprecia tu Nómina</p>
                                               <p><b>Tipo de Crédito:</b> Crédito de Nómina</p>
                                              </td>
                                            </tr>
                                            <tr>
                                              <td>
                                              <p><b>CAT (Costo Anual Total)</b></p>
                                              </td>
                                               <td>
                                              <p><b>TASA DE INTERÉS ANUAL ORDINARIA Y MORATORIA</b></p>
                                              </td>
                                                <td>
                                              <p><b>MONTO O LÍNEA DE CRÉDITO</b></p>
                                              </td>
                                                <td>
                                              <p><b>MONTO TOTAL A PAGAR O MÍNIMO A PAGAR</b></p>
                                              </td>
                                            </tr>
                                              <tr>
                                              <td>
                                              <p>% Sin IVA 
                                        Para fines informativos y de Comparación
                                        </p>
                                              </td>
                                               <td>
                                              <p>
                                        Tasa Ordinaria Fija Sin IVA
                                        </p>
                                         <p>Tasa Moratoria Fija Sin IVA
                                        </p>
                                              </td>
                                                <td>
                                               <p>$ Pesos</p>
                                              </td>
                                                <td>
                                              <p>$ Pesos</p>
                                              </td>
                                            </tr>
                                           <tr >
    
                                                <td colspan=""2"">
                                               <p><b>PLAZO DEL CRÉDITO:</b> </p>
                                              </td>
                                                <td colspan=""2"">
                                              <p><b>Fecha límite de pago:</b> los días «DIASPAGO» de cada mes.</p>
                                               <p><b>Fecha de Corte:</b> los días «DIACORTE» de cada mes.</p>
                                              </td>
                                           </tr> 
                                            <tr >
    
                                                <td colspan=""4"">
                                               <p style=""text-align:center;"">COMISIONES RELEVANTES </p>
                                              </td>
     
                                           </tr> 
                                             <tr >
    
                                                <td colspan=""2"">
                                               <p style=""text-align:left;""><b>•	Apertura:</b> (0%) No aplica </p>
                                               <p style=""text-align:left;""><b>•	Anualidad:</b> (0%) No aplica </p>
                                               <p style=""text-align:left;""><b>•	Prepago:</b> (0%) Sin pena alguna por pago anticipado </p>
                                               <p style=""text-align:left;""><b>•	Pago tardío (mora): </b>(0%) No aplica</p>
                                                   <p style=""text-align:left;""><b>•	Comisión por administración:</b> «PorcentajeComision»% sobre los pagos durante la vida del crédito, respecto al monto total del crédito</p>
                                              </td>
                                              <td colspan=""2"">
                                               <p style=""text-align:left;""><b>•	Reposición de tarjeta:</b> No aplica. </p>
                                                 <p style=""text-align:left;""><b>•	Reclamación improcedente:</b> No aplica </p>
                                                   <p style=""text-align:left;""><b>•	Cobranza:</b> No aplica </p>
                                              </td>
                                           </tr> 
                                            <tr >
    
                                                <td colspan=""4"">
                                               <p style=""text-align:left;""><b>ADVERTENCIAS</b> </p>
                                                <p style=""text-align:left;"">a)	“Incumplir tus obligaciones te puede generar comisiones e intereses moratorios.” </p>
                                                 <p style=""text-align:left;"">b)	“Contratar créditos por arriba de tu capacidad de pago puede afectar tu historial crediticio.” </p>
                                              </td>
     
                                           </tr> 
                                             <tr >
    
                                                <td colspan=""4"">
                                               <p style=""text-align:center;""><b>SEGUROS</b> </p>
                                              </td>
     
                                           </tr> 
                                               <tr >
    
                                                <td colspan=""1"">
                                               <p style=""text-align:center;""><b>Seguro:</b> Vida 
                                        Obligatorio
                                         </p>
                                              </td>
                                                <td colspan=""1"">
                                               <p style=""text-align:center;""><b>Aseguradora:</b> «NombreAseguradora» </p>
                                              </td>
                                                <td colspan=""2"">
                                               <p style=""text-align:center;""><b>Cláusula: DECIMA SEXTA</b> </p>
                                                 <p style=""text-align:center;"">FOMEPADE S.A.P.I. de C.V. SOFOM E.N.R., podrá contratar a su nombre el seguro, previa autorización de “EL CLIENTE” </p>
                                              </td>
     
                                           </tr>
                                             <tr >
    
                                                <td colspan=""4"">
                                               <p style=""text-align:left;""><b>ESTADO DE CUENTA</b> </p>
                                                 <p style=""text-align:left;""><b>Enviar a: </b> Domicilio [  ]        <b>Consulta:</b>  Vía Internet [   ]          <b>Envío por:</b> Envío por correo electrónico  [  ]  </p>
                                              </td>
     
                                           </tr> 
                                               <tr >
    
                                                <td colspan=""4"">
      
                                                 <p style=""text-align:left;""><b>Aclaraciones y reclamaciones:</b>
                                        Unidad Especializada de Atención a Usuarios:
                                        Domicilio: Boulevard Atlixco número 3115 Interior 1, Colonia Nueva Antequera, C.P. 72180, Puebla, Puebla.
                                        Teléfono: <b>(222) 1698090  y (800) 9909192</b>  Correo Electrónico: <b>une@aprecia.com.mx</b>
                                        Página de internet: <b style=""color:blue"">www.aprecia.com.mx</b>
                                         </p>
                                              </td>
     
                                           </tr>
                                                  <tr >
    
                                                <td colspan=""4"">
      
                                                 <p style=""text-align:left;"">
                                                 <b>Registro de Contratos de Adhesión Número: 2028-440-004742/17-00217-0121</b>
                                        Comisión Nacional para la Protección y Defensa de los Usuarios de Servicios Financieros (CONDUSEF):
                                        Teléfono: <b>(800) 999 8080 y (55) 5340 0999.</b>  Página de Internet. <b style=""color:blue"">www.condusef.gob.mx</b>

                                         </p>
                                              </td>
     
                                           </tr>
                                          </tbody>
                                        </table>
                                         <p style=""text-align:left;"">
                                        De conformidad con la presente carátula y toda vez que el presente documento forma parte integrante del contrato de adhesión, firma el cliente a su entera satisfacción.
                                         </p>
                                          <p style=""text-align:CENTER;"">

                                         </p>
                                         <p style=""text-align:CENTER;"">
                                        <b>""EL CLIENTE""</b>
                                         </p>
                                         <p style=""text-align:CENTER;"">
                                         ____________________<br>
                                        <b>Nombre y firma</b>
                                         </p>
                                        </body>
                                        </html>																																";
           
            return strDocumento;
        }
    }
}
