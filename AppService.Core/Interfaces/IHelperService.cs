using System;
using System.Collections.Generic;
using System.Text;

namespace AppService.Core.Interfaces
{
    public interface IHelperService
    {
        List<string> GetListString(string str, string initialDelimeter, string endDelimeter);

    }
}
