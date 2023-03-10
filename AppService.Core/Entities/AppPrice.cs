

using System;

namespace AppService.Core.Entities
{
  public class AppPrice
  {
    public int Id { get; set; }

    public int AppproductsId { get; set; }

    public Decimal Desde { get; set; }

    public Decimal Hasta { get; set; }

    public Decimal Precio { get; set; }

    public virtual AppProducts Appproducts { get; set; }
  }
}
