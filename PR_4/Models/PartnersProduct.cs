using System;
using System.Collections.Generic;

namespace PR_4.Models;

public partial class PartnersProduct
{
    public short Id { get; set; }

    public short IdPartner { get; set; }

    public short IdProduct { get; set; }

    public int Count { get; set; }

    public DateTime DateSelling { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
