using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Table("WCS_SUBTASKINFO")]
public partial class WcsSubtaskinfo
{
    [Key]
    [Column("SUBTASKNO")]
    [StringLength(32)]
    [Unicode(false)]
    public string Subtaskno { get; set; } = null!;

    [Column("TASKNO", TypeName = "NUMBER")]
    public decimal Taskno { get; set; }

    [Column("EQUIPMENTTYPE")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Equipmenttype { get; set; }

    [Column("FROMSTATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fromstation { get; set; }

    [Column("MIDSTATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Midstation { get; set; }

    [Column("TOSTATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Tostation { get; set; }

    [Column("CURRENTSTATION")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Currentstation { get; set; }

    [Column("TASKSTATUS")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Taskstatus { get; set; }

    [Column("BARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Barcode { get; set; }

    [Column("UPDATETIME", TypeName = "DATE")]
    public DateTime? Updatetime { get; set; }

    [Column("WAREHOUSEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Warehouseid { get; set; }

    [Column("RUNSTATUS")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Runstatus { get; set; }

    [Column("EQUIPMENTNUMBER")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Equipmentnumber { get; set; }

    [Column("AGVIKEY", TypeName = "NUMBER")]
    public decimal? Agvikey { get; set; }

    [Column("AGVINDEX")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Agvindex { get; set; }

    [Column("AGVMAGIC")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Agvmagic { get; set; }

    [Column("AGVCARNO")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Agvcarno { get; set; }

    [Column("AGVSTATUS")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Agvstatus { get; set; }

    [Column("CREATETIME", TypeName = "DATE")]
    public DateTime? Createtime { get; set; }

    [Column("VERSION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Version { get; set; }

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

    [Column("ZONE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Zone { get; set; }

    [Column("FIELD6", TypeName = "DATE")]
    public DateTime? Field6 { get; set; }

    [Column("FINISHEDTIME", TypeName = "DATE")]
    public DateTime? Finishedtime { get; set; }

    [Column("USERID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Userid { get; set; }

    [Column("ACT_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ActStatus { get; set; }
}
