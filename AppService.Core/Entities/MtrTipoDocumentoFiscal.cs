// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrTipoDocumentoFiscal
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System.Collections.Generic;

namespace AppService.Core.Entities
{
  public class MtrTipoDocumentoFiscal
  {
    public MtrTipoDocumentoFiscal() => this.PrcNumeracionFiscal = (ICollection<AppService.Core.Entities.PrcNumeracionFiscal>) new HashSet<AppService.Core.Entities.PrcNumeracionFiscal>();

    public string TipoDocumento { get; set; }

    public string Descripcion { get; set; }

    public bool ValidaNumero { get; set; }

    public int IdFormato { get; set; }

    public virtual ICollection<AppService.Core.Entities.PrcNumeracionFiscal> PrcNumeracionFiscal { get; set; }
  }
}
