using System;
using System.Collections.Generic;

namespace ProjectCoreApI.Database;

public partial class Item
{
    public int ItemId { get; set; }

    public string? ItemType { get; set; }

    public int? BrandId { get; set; }

    public decimal? Price { get; set; }

    public string? Image { get; set; }

    public virtual Brand? Brand { get; set; }
}
