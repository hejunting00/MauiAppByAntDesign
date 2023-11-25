using System;
using System.Collections.Generic;

namespace NTI_NG_MAUI.DataModels;

public partial class WcsTaskinfo
{
    public string Taskid { get; set; }

    public decimal Taskno { get; set; }

    public string Wmstaskno { get; set; }

    public string Barcode { get; set; }

    public string Fromstation { get; set; }

    public string Tostation { get; set; }

    public string Priority { get; set; }

    public string Tasktype { get; set; }

    public string Taskstatus { get; set; }

    public string Ledtext { get; set; }

    public string Wmsorderno { get; set; }

    public decimal? Wmsorderqty { get; set; }

    public string Wmsbatchno { get; set; }

    public string Wmsgroupno { get; set; }

    public string Wmssequenceno { get; set; }

    public string Itemno { get; set; }

    public string Itemname { get; set; }

    public decimal? Itemqty { get; set; }

    public string Field1 { get; set; }

    public string Field2 { get; set; }

    public string Field3 { get; set; }

    public string Field4 { get; set; }

    public string Field5 { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Updatetime { get; set; }

    public string Warehouseid { get; set; }

    public string Version { get; set; }

    public string Goodstype { get; set; }

    public string Wmstaskflag { get; set; }

    public string Outsequenceflag { get; set; }

    public string Bufferflag { get; set; }

    public string Zone { get; set; }

    public string ActStatus { get; set; }
}
