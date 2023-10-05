using System;
using System.Collections.Generic;

namespace PAI_USA.Models;

public partial class Bank
{
    public string? PayCode { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public bool BankAttachment { get; set; }

    public string? LiteralConstant { get; set; }

    public bool? YearClose { get; set; }

    public string? TaxAssociate { get; set; }

    public string? TaxType { get; set; }
}
