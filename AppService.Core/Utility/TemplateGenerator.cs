using AppService.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLStringListadoRecibo(List<CobGeneralCobranzaDto> cobGeneralCobranzaDto)
        {


            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                              <style>
                                .header {
                                  text-align: center;
                                  color: green;
                                  padding-bottom: 35px;
                                }

                                table {
                                  width: 80%;
                                  border-collapse: collapse;
                                }

                                td,
                                th {
                                  border: 1px solid gray;
                                  padding: 15px;
                                  font-size: 22px;
                                  text-align: center;
                                }

                                table th {
                                  background-color: green;
                                  color: white;
                                }
                              </style>
                            </head>
                            <body>
                                <div class='header'><h1>Recibo de Cobro</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Documento</th>
                                        <th>Cliente</th>
                                        <th>Vendedor</th>
                                        <th>Monto</th>
                                    </tr>");

            foreach (var item in cobGeneralCobranzaDto)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", item.Documento, item.NombreCliente, item.NombreVendedor, item.MontoTransaccionString);
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }

        public static string GetHTMLStringRecibo(ReciboDto reciboDto)
        {


            var sb = new StringBuilder();

            sb.Append(@"
                        <html>
                            <head>
                              <style>
                                .subheader {
                                  text-align: center;
                                  color: black;
                                  padding-bottom: 15px;
                                }
                                .header {
                                  text-align: center;
                                  color: black;
                                  padding-bottom: 35px;
                                }

                                table {
                                  width: 80%;
                                  border-collapse: collapse;
                                }

                                td,
                                th {
                                  border: 1px solid gray;
                                  padding: 10px;
                                  font-size: 14px;
                                  text-align: center;
                                }

                                table th {
                                  background-color: gray;
                                  color: white;
                                }
                              </style>
                            </head>
                            <body>");
            sb.AppendFormat(@"
                                <div align='center'><h1>Moore de Venezuela, S.A. Rif: J-07506100-4 </h1></div>
                                <div class='header'><h1>Recibo de Cobro: {0}</h1></div>", reciboDto.CobGeneralCobranzaDto.Documento.ToString());
            sb.Append(@"
                                <table align='center'>
                                    <tr>
                                        <th>Hemos Recibido de:</th>
                                        <th>Id Cliente</th>
                                        <th>Monto</th>
                                        <th>Fecha Recibido</th>
                                        <th>Tipo Pago</th>
                                    </tr>");
            sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                  </tr>", reciboDto.CobGeneralCobranzaDto.NombreCliente, reciboDto.CobGeneralCobranzaDto.IdCliente, reciboDto.CobGeneralCobranzaDto.NombreTipoMoneda + " " + reciboDto.CobGeneralCobranzaDto.MontoTransaccionString, reciboDto.CobGeneralCobranzaDto.FechaTransaccionString, reciboDto.CobGeneralCobranzaDto.NombreTipoTransaccion);
            sb.Append(@"
                                <table align='center'>
                                    <tr>
                                        <th>La cantidad de:</th>
                                       
                                    </tr>");
            sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    
                                    </tr>", reciboDto.CobGeneralCobranzaDto.MontoLetras);
            sb.Append(@"
                                <table align='center'>
                                    <tr>
                                        <th>Cuenta Destino:</th>
                                        <th>Planilla</th>
                                    </tr>");
            sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    </tr>", reciboDto.CobGeneralCobranzaDto.NombreBanco, reciboDto.CobGeneralCobranzaDto.NumReferencia);
            
            sb.Append(@"
                                <table align='center'>
                                    <tr>
                                        <th>Consultor:</th>
                                        <th>Email</th>
                                        <th>Telefono</th>
                                    </tr>");
            sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    </tr>", reciboDto.CobGeneralCobranzaDto.NombreVendedor, reciboDto.CobGeneralCobranzaDto.CorreoVendedor, reciboDto.CobGeneralCobranzaDto.TelefonoVendedor);
            sb.Append(@"
                                </table>");
            sb.Append(@"
                                <table align='center'>
                                    <tr>
                                        <th>Documento Afecta</th>
                                        <th>Fecha</th>
                                        <th>Base</th>
                                        <th>Iva</th>
                                        <th>Total Documento</th>
                                        <th>Monto Cobrado</th>
                                        <th>Paga</th>
                                        
                                    </tr>");
            

            foreach (var item in reciboDto.CobGrabacionCobranzaDto)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td style=" + @"text-align:right;" + @">{5}</td>
                                    <td>{6}</td>
                                    
                                  </tr>", item.DocAfectaMostrar, item.FechaDocumentoString, item.BaseImponibleMostrar, item.IvaMostrar,item.MontoOriginalMostrar,item.MontoMostrar,item.PagoCorrespondeIvaString);

                if (item.CobPagosRetencionesDto.Count>0)
                {
                    sb.Append(@"
                                    <tr>
                                        <th>RETENCIONES</th>
                                        <th>Transacciom</th>
                                        <th>Porcentaje</th>
                                        <th>Monto</th>
                                        <th>Comprobante</th>
                                        <th>Fecha Comprobante</th>
                                       
                                        
                                    </tr>");
                    foreach (var itemRet in item.CobPagosRetencionesDto)
                    {
                        sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>{4}</td>
                                    <td>{5}</td>
                                    
                                    
                                  </tr>", "", itemRet.NombreTransaccion, itemRet.Porcentaje, itemRet.MontoString, itemRet.NroComprobante,itemRet.FechaComprobanteString);

                    }
                }
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
