using System;
using System.Collections.Generic;

namespace NTI_NG_MAUI.DataModels;

public partial class Zone
{
    public string Warehouseid { get; set; }

    public string Zoneid { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Typecode { get; set; }

    public string Userid { get; set; }

    public DateTime? Createtime { get; set; }

    public decimal? Field1 { get; set; }

    public string Field2 { get; set; }

    public string Field3 { get; set; }

    public string Field4 { get; set; }

    public string Field5 { get; set; }

    public string ActStatus { get; set; }
}
