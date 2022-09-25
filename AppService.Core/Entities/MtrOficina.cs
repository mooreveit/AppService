// Decompiled with JetBrains decompiler
// Type: AppService.Core.Entities.MtrOficina
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;
using System.Collections.Generic;

namespace AppService.Core.Entities
{
    public class MtrOficina
    {
        public MtrOficina() => this.MtrVendedor = (ICollection<AppService.Core.Entities.MtrVendedor>)new HashSet<AppService.Core.Entities.MtrVendedor>();

        public Decimal Recnum { get; set; }

        public short CodOficina { get; set; }

        public string NomOficina { get; set; }

        public string Direccion { get; set; }

        public string Direccion2 { get; set; }

        public string Telefono { get; set; }

        public string Fax { get; set; }

        public short CodigoParroq { get; set; }

        public string CodOficina2 { get; set; }

        public string Estado { get; set; }

        public string Municipio { get; set; }

        public string Region { get; set; }

        public string GerenteOficina { get; set; }

        public Decimal Override { get; set; }

        public string OficinaActiva { get; set; }

        public string CarpetaDiseno { get; set; }

        public string Canal { get; set; }

        public string PAusente { get; set; }

        public string CodigoJde { get; set; }

        public int? Idtitulo { get; set; }

        public string SinImpuesto { get; set; }

        public string AdministradoraEmail { get; set; }

        public string AnalistaEmail { get; set; }

        public string Analista2Email { get; set; }

        public string ClienteNacionales { get; set; }

        public string Abreviado { get; set; }

        public string DataManagerEmail { get; set; }

        public string UsuarioAdministradora { get; set; }

        public string UsuarioAnalista { get; set; }

        public int OdooId { get; set; }

        public int IdComercianteOdoo { get; set; }


        public virtual ICollection<AppService.Core.Entities.MtrVendedor> MtrVendedor { get; set; }
    }
}
