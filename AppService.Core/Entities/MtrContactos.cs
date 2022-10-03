// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrContactos
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public class MtrContactos
    {
        public MtrContactos()
        {
            this.AppGeneralQuotes = (ICollection<AppService.Core.Entities.AppGeneralQuotes>)new HashSet<AppService.Core.Entities.AppGeneralQuotes>();
            this.CrmSeguimiento = (ICollection<AppService.Core.Entities.CrmSeguimiento>)new HashSet<AppService.Core.Entities.CrmSeguimiento>();
            this.OfdCotizacion = (ICollection<AppService.Core.Entities.OfdCotizacion>)new HashSet<AppService.Core.Entities.OfdCotizacion>();
        }

        public long IdContacto { get; set; }

        public string IdCliente { get; set; }

        public string Rif { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public string Area { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string Fax { get; set; }

        public bool? Inactivo { get; set; }

        public bool? Prospecto { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string Usuario { get; set; }

        public bool? AceptaEmail { get; set; }

        public bool? AceptaSms { get; set; }

        public int? IdContactoOdoo { get; set; }

        public int? IdClienteOdoo { get; set; }

        public virtual ICollection<AppService.Core.Entities.AppGeneralQuotes> AppGeneralQuotes { get; set; }

        public virtual ICollection<AppService.Core.Entities.CrmSeguimiento> CrmSeguimiento { get; set; }

        public virtual ICollection<AppService.Core.Entities.OfdCotizacion> OfdCotizacion { get; set; }
    }
}
