// Decompiled with JetBrains decompiler
// Type: AppService.Core.DTOs.AppPriceGetDto
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using System;

namespace AppService.Core.DTOs
{
    public class AppPriceGetDto
    {
        public int Id { get; set; }

        public int AppproductsId { get; set; }

        public int? CalculoId { get; set; }

        public Decimal Desde { get; set; }

        public Decimal Hasta { get; set; }


        public Decimal Tasa { get; set; }
        public Decimal Precio { get; set; }

        public Decimal Flete { get; set; }

        public Decimal PrecioMasFlete { get; set; }

        public Decimal PrecioBs { get; set; }

        public Decimal FleteBs { get; set; }

        public Decimal PrecioMasFleteBs { get; set; }
        public Decimal SubTotalBs { get; set; }

        public Decimal SubTotal
        {
            get
            {

                return Utility.TruncateDec.TruncateDecimal((Decimal)CantidadConvertida * PrecioMasFlete, 2);
            }

        }




        public Decimal? CantidadConvertida { get; set; } = 0;

        public AppProductsGetDto AppProduct { get; set; }

    }
}
