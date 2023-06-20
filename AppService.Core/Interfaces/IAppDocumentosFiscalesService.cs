using System;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
	public interface IAppDocumentosFiscalesService
	{

        string ReadTextPdf(string src = "/Users/freveron/Documents/Moore/Facturacion/enProceso/Factura_2200732866.pdf");
        Task<string> ReadLineByLineTextPdf(string src);
    }
}

