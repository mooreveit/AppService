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

namespace AppService.Core.Services
{
	public class AppDocumentosFiscalesService: IAppDocumentosFiscalesService
    {
		public AppDocumentosFiscalesService()
		{
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

        public string ReadLineByLineTextPdf(string src)
        {
            //var src = "/Users/freveron/Documents/Moore/Facturacion/enProceso/Factura_2200732866.pdf";
            var pdfDocument = new PdfDocument(new PdfReader(src));
            StringBuilder processed = new StringBuilder();
            var strategy = new LocationTextExtractionStrategy();
            string text = "";
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
                text += PdfTextExtractor.GetTextFromPage(page, strategy);
                processed.Append(text);
            }
            //text.Split('\n');
            //string line = "";
            //line = text + "&";
            string[] newLines = text.Split('\n');
            var line1 = newLines[0].Split(':')[1].ToString();
            var line2= newLines[0].Split(':')[2].ToString();
            pdfDocument.Close();
            return text;

        }


    }
}

