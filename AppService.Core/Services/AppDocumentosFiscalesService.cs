using System;
using AppService.Core.DTOs.Especificaciones;
using AppService.Core.Responses;
using System.Threading.Tasks;
using AppService.Core.Entities;
using iText.Forms.Xfdf;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using AppService.Core.Interfaces;
using System.Text;
using System.IO;
using iText.Layout;
using iText.IO.Image;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.IO.Util;
using iText.Kernel.Pdf.Xobject;
using iText.Layout.Properties;
using Markdig.Extensions.Tables;
using System.Linq.Expressions;
using AppService.Core.DTOs.DocumentosFiscales;
using Org.BouncyCastle.Asn1.Ocsp;
using AppService.Core.DTOs;
using AppService.Core.EntitiesEstadisticas;
using AppService.Core.EntitiesFacturacion;
using AppService.Core.EntitiesPlanta;
using System.Collections.Generic;

namespace AppService.Core.Services
{
	public class AppDocumentosFiscalesService: IAppDocumentosFiscalesService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppDocumentosFiscalesService(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;

        }

        public  string ReadTextPdf(string src)
        {
            //var src = "/Users/freveron/Documents/Moore/Facturacion/enProceso/Factura_2200732866.pdf";
            var pdfDocument = new PdfDocument(new PdfReader(src));
            var strategy =  new LocationTextExtractionStrategy();
            string text = string.Empty;
            for(int i=1; i <= pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
               // text = PdfTextExtractor.GetTextFromPage(page);

                PdfDictionary infoDictionary = pdfDocument.GetTrailer().GetAsDictionary(PdfName.Info);
                foreach (PdfName key in infoDictionary.KeySet())
                {
                    text = $"{text}{key}: {infoDictionary.GetAsString(key)}";
                }
                    



            }
            return text;

        }
        public string[] GetFicheros()
        {
            string directorio = @"/Users/freveron/Documents/Moore/Facturacion/enProceso/";

            string[] ficheros = Directory.GetFiles(directorio);
            return ficheros;
        }

        public void Convert(string srcFile, string outFileName)
        {
            try
            {
             

                PdfDocument pdf = new PdfDocument(new PdfReader(srcFile), new PdfWriter(outFileName));
          
                Document doc = new Document(pdf);




                string imageFile = "/Users/freveron/Documents/Moore/Facturacion/image/encabezado.jpg";
                string imageFilePie = "/Users/freveron/Documents/Moore/Facturacion/image/PiePagina.png";

                PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(imageFile));
                Image image = new Image(xObject, 100).SetHorizontalAlignment(HorizontalAlignment.LEFT);
                doc.SetTopMargin(0);
                doc.SetBottomMargin(0);
                //doc.SetRightMargin(0);
                var witch = image.GetImageScaledWidth();
                var height = image.GetImageScaledHeight();
                image.ScaleToFit(13500, height * 50);
                doc.Add(image);


                PdfImageXObject xObjectPie = new PdfImageXObject(ImageDataFactory.Create(imageFilePie));
                Image imagePie = new Image(xObjectPie, 100).SetHorizontalAlignment(HorizontalAlignment.LEFT);

                //doc.SetRightMargin(0);

                imagePie.ScaleToFit(13500, height * 50);
                imagePie.SetFixedPosition(5, 15);
                doc.Add(imagePie);

                Paragraph pControl = new Paragraph("XXXXXXXX").SetFontColor(iText.Kernel.Colors.ColorConstants.RED).SetFontSize(14);
                pControl.SetFixedPosition(480, 17, 200);
                doc.Add(pControl);


                doc.Close();
                pdf.Close();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException.Message;
            }
          

        }

        public async Task<string> ReadLineByLineTextPdf(string src)
        {
            //string srcFile = @"/Users/freveron/Documents/Moore/Facturacion/enProceso/Factura_2200732871.pdf";
            string outFileName = @"";
            var destino = "/Users/freveron/Documents/Moore/Facturacion/historico/";
            //Convert(srcFile, outFileName);

            var ficheros = GetFicheros();
            string text1 = "";



            text1 = $"{ficheros.Length} Archivos procesados";

            foreach (string file in ficheros)
            {
                
                var srcFileArr = file.Split("/");
                var fileName = srcFileArr[srcFileArr.Length - 1];
                outFileName = $"{destino}{fileName}";
                var isValid = IsValidPdf(file);
                if (isValid)
                {
                    Convert(file, outFileName);
                    if (File.Exists(file) && File.Exists(outFileName))
                    {
                        File.Delete(file);
                        await UpdateFile(fileName);
                    }
                }
                else
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                }
            }


        
            return text1;

        }

        public async Task UpdateFile(string fileName)
        {
            string result = string.Empty;
            var tipoDocumento = GetTipoDocumento(fileName);
            var documento = GetDocumento(fileName);
            var ordenCotizacion = await GetOrdenCotizacion(tipoDocumento, documento);

            //var ofdTipoDocumento = await _unitOfWork.OfdTipoDocumentoRepository.GetByFileNAme(fileName);

            OfdAdjunto ofdAdjunto = new OfdAdjunto();
            ofdAdjunto.NombreArchivo = fileName;

           // ofdAdjunto.Archivo = new byte[file.ContentLength];
           // file.InputStream.Read(ofdadjunto.Archivo, 0, file.ContentLength);


            byte[] bytes = File.ReadAllBytes(fileName);
            ofdAdjunto.Archivo = bytes;
            ofdAdjunto.IdUsuarioCreacion = "SISTEMA";
            ofdAdjunto.FechaCreacion = DateTime.Now;
            var created =  await _unitOfWork.OfdAdjuntoRepository.Add(ofdAdjunto);

            string valor = string.Empty;

            short idCriterioBusquedaOrden = 5;
            short idCriterioBusquedaCotizacion = 6;
            short idCriterioBusquedaCliente = 7;
            short idCriterioBusquedaRif = 8;
            short idCriterioBusquedaFactura = 9;
            short idCriterioBusquedaNotaEntrega = 11;
            short idCriterioBusquedaNotaCredito = 12;
            short idCriterioBusquedaNotaDebito = 12;
            if (ordenCotizacion.Orden > 0)
            {
                valor = ordenCotizacion.Orden.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaOrden, valor);

               
            }
            if (ordenCotizacion.Cotizacion.Length > 0)
            {
              
                valor = ordenCotizacion.Cotizacion.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaCotizacion, valor);
            }
            if (ordenCotizacion.Cliente.Length > 0)
            {
                valor = ordenCotizacion.Cliente.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaCliente, valor);
            }
            if (ordenCotizacion.Rif.Length > 0)
            {
                valor = ordenCotizacion.Rif.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaRif, valor);
            }
            if(tipoDocumento== "Factura")
            {
                valor = documento.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaFactura, valor);
            }
            if (tipoDocumento == "Nota_Crédito")
            {
                valor = documento.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaNotaCredito, valor);
            }
            if (tipoDocumento == "Nota_Débito")
            {
                valor = documento.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaNotaDebito, valor);
            }
            if (tipoDocumento == "Entrega")
            {
                valor = documento.ToString();
                await AddAdjuntoCriterio(created.IdAdjunto, idCriterioBusquedaNotaEntrega, valor);
            }

       
        

        }

        private async Task<OfdAdjuntoCriterio> AddAdjuntoCriterio(long IdAdjunto, Int16 IdCriterioBusqueda, string Valor)
        {
            OfdAdjuntoCriterio AdjCri = new OfdAdjuntoCriterio();
            try
            {
                AdjCri.IdAdjunto = IdAdjunto;
                AdjCri.IdCriterioBusqueda = IdCriterioBusqueda;
                AdjCri.Valor = Valor;
                AdjCri.IdUsuarioCreacion = "CLIENTE";
                AdjCri.FechaCreacion = DateTime.Now;
                var created = await _unitOfWork.OfdAdjuntoCriterioRepository.Add(AdjCri);
                return created;
            }
            catch
            {
                throw;
            }

        }

        public List<CriterioBusqueda> GetCriterioBusqueda()
        {

            List<CriterioBusqueda> lista = new List<CriterioBusqueda>()
            {
                new CriterioBusqueda() { Id = 5, Descripcion= "Orden" },
                new CriterioBusqueda() { Id = 6, Descripcion= "Cotizacion" },
                new CriterioBusqueda() { Id = 7, Descripcion= "Cliente" },
                new CriterioBusqueda() { Id = 8, Descripcion= "RIF" },
                new CriterioBusqueda() { Id = 9, Descripcion= "Factura" },
                new CriterioBusqueda() { Id = 11, Descripcion= "Remision" },
                new CriterioBusqueda() { Id = 12, Descripcion= "Nota Credito" },
                 new CriterioBusqueda() { Id = 13, Descripcion= "Nota Debito" },

            };

            return lista;

        }

        public string GetTipoDocumento(string fileName)
        {
            string result = string.Empty;

            var esFactura = fileName.Contains("Factura");
            var esNotaCredito = fileName.Contains("Nota_Crédito");
            var esNotaDebito = fileName.Contains("Nota_Débito");
            var esEntrega = fileName.Contains("Entrega");
            if (esFactura) result = "Factura";
            if (esNotaCredito) result = "Nota_Crédito";
            if (esNotaDebito) result = "Nota_Débito";
            if (esEntrega) result = "Entrega";
            return result;
        }
        public string GetNumeroDocumento(string fileName)
        {
            string result = string.Empty;

            var ultimos = fileName.PadRight(14);
            var docArray = ultimos.Split(".");
            result = docArray[0];

            return result;
        }
        public async Task<OrdenCotizacion> GetOrdenCotizacion(string tipoDocumento ,int documento)
        {
            OrdenCotizacion result = new OrdenCotizacion();

            switch (tipoDocumento)
            {
                case "Factura":
                    var factura = await _unitOfWork.Ciny057Repository.GetByNumero(documento);
                    if (factura != null)
                    {
                        result.Orden = factura.Orden;
                        var ventas = await _unitOfWork.VentasRepository.GetByOrden(factura.Orden);
                        if (ventas != null)
                        {
                            result.Cotizacion = ventas.CotizacionCorta;
                            result.Cliente = ventas.Cliente.ToString();
                            var cliente = await _unitOfWork.MtrClienteRepository.GetByIdAsync(ventas.Cliente.ToString());
                            if(cliente!=null)
                            {
                                result.Rif = cliente.NoRegTribut;
                            }
                            else
                            {
                                result.Rif = "";
                            }
                        }

                    }

                    // code block
                    break;
                case "Nota_Crédito":
                    var notaCredito = await _unitOfWork.Ciny057Repository.GetNotaCreditoByNumero(documento);
                    if (notaCredito!=null)
                    {
                        var facturaNota = await _unitOfWork.Ciny057Repository.GetByNumero(notaCredito.Factura);
                        if (facturaNota != null)
                        {
                            result.Orden = facturaNota.Orden;
                            var ventas = await _unitOfWork.VentasRepository.GetByOrden(facturaNota.Orden);
                            if (ventas != null)
                            {
                                result.Cotizacion = ventas.CotizacionCorta;
                                result.Cliente = ventas.Cliente.ToString();
                                var cliente = await _unitOfWork.MtrClienteRepository.GetByIdAsync(ventas.Cliente.ToString());
                                if (cliente != null)
                                {
                                    result.Rif = cliente.NoRegTribut;
                                }
                                else
                                {
                                    result.Rif = "";
                                }
                            }

                        }
                    }
                    
                    // code block
                    break;
                case "Nota_Débito":
                  
                    // code block
                    break;
                case "Entrega":
                   
                    // code block
                    break;
                default:
                    // code block
                    break;
            }



           
            return result;

        }
        public int GetDocumento(string fileName)
        {
            int result = 0;
        
            var tipoDocumento = GetTipoDocumento(fileName);
            var numeroDocumento = GetNumeroDocumento(fileName);

            switch (tipoDocumento)
            {
                case "Factura":
                    var facturaString = numeroDocumento.PadRight(6);
                    result = Int32.Parse(facturaString);
                    // code block
                    break;
                case "Nota_Crédito":
                    var notaCreditoString = numeroDocumento.PadRight(5);
                    result = Int32.Parse(notaCreditoString);
                    // code block
                    break;
                case "Nota_Débito":
                    var notaDebitoString = numeroDocumento.PadRight(5);
                    result = Int32.Parse(notaDebitoString);
                    // code block
                    break;
                case "Entrega":
                    var notaEntregaString = numeroDocumento.PadRight(5);
                    result = Int32.Parse(notaEntregaString);
                    // code block
                    break;
                default:
                    // code block
                    break;
            }


            return result;
        }

        public bool IsValidPdf(string fileName)
        {
            try
            {
                new PdfReader(fileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




    }
}

