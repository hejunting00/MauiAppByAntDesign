using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Table("WCS_TASKINFO")]
public partial class WcsTaskinfo
{
    [Key]
    [Column("TASKID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Taskid { get; set; } = null!;

    [Column("TASKNO", TypeName = "NUMBER")]
    public decimal Taskno { get; set; }

    [Column("WMSTASKNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wmstaskno { get; set; }

    [Column("BARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Barcode { get; set; }

    [Column("FROMSTATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fromstation { get; set; }

    [Column("TOSTATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Tostation { get; set; }

    [Column("PRIORITY")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [Column("TASKTYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tasktype { get; set; }

    [Column("TASKSTATUS")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Taskstatus { get; set; }

    [Column("LEDTEXT")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? Ledtext { get; set; }

    [Column("WMSORDERNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wmsorderno { get; set; }

    [Column("WMSORDERQTY", TypeName = "NUMBER")]
    public decimal? Wmsorderqty { get; set; }

    [Column("WMSBATCHNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wmsbatchno { get; set; }

    [Column("WMSGROUPNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wmsgroupno { get; set; }

    [Column("WMSSEQUENCENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wmssequenceno { get; set; }

    [Column("ITEMNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Itemno { get; set; }

    [Column("ITEMNAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Itemname { get; set; }

    [Column("ITEMQTY", TypeName = "NUMBER")]
    public decimal? Itemqty { get; set; }

    [Column("FIELD1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Field1 { get; set; }

    [Column("FIELD2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Field2 { get; set; }

    [Column("FIELD3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Field3 { get; set; }

    [Column("FIELD4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Field4 { get; set; }

    [Column("FIELD5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Field5 { get; set; }

    [Column("CREATETIME", TypeName = "DATE")]
    public DateTime? Createtime { get; set; }

    [Column("UPDATETIME", TypeName = "DATE")]
    public DateTime? Updatetime { get; set; }

    [Column("WAREHOUSEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseid { get; set; } = null!;

    [Column("VERSION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Version { get; set; }

    [Column("GOODSTYPE")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Goodstype { get; set; }

    [Column("WMSTASKFLAG")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Wmstaskflag { get; set; }

    [Column("OUTSEQUENCEFLAG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Outsequenceflag { get; set; }

    [Column("BUFFERFLAG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Bufferflag { get; set; }

    [Column("ZONE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Zone { get; set; }

    [Column("ACT_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ActStatus { get; set; }
}
