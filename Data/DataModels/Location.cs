using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Table("LOCATION")]
[Index("Containerid", Name = "LOCATION_U01", IsUnique = true)]
[Index("Locationstate", Name = "STATE_INDEX")]
[Index("Warehouseid", "Zoneid", "Locationline", "Locationcolumn", "Locationlayer", "Locationdepth", Name = "U_LOC", IsUnique = true)]
public partial class Location
{
    [Column("WAREHOUSEID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Warehouseid { get; set; } = null!;

    [Column("ZONEID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Zoneid { get; set; } = null!;

    [Key]
    [Column("LOCATIONID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Locationid { get; set; } = null!;

    [Column("LOCATIONNUMBER")]
    [StringLength(50)]
    public string Locationnumber { get; set; } = null!;

    [Column("LOCATIONLINE", TypeName = "NUMBER(38)")]
    public decimal Locationline { get; set; }

    [Column("LOCATIONCOLUMN", TypeName = "NUMBER(38)")]
    public decimal Locationcolumn { get; set; }

    [Column("LOCATIONLAYER", TypeName = "NUMBER(38)")]
    public decimal Locationlayer { get; set; }

    [Column("LOCATIONDEPTH", TypeName = "NUMBER(38)")]
    public decimal Locationdepth { get; set; }

    [Column("LOCATIONFLAG")]
    [StringLength(50)]
    public string Locationflag { get; set; } = null!;

    [Column("LENGTH", TypeName = "NUMBER(18,3)")]
    public decimal? Length { get; set; }

    [Column("WIDTH", TypeName = "NUMBER(18,3)")]
    public decimal? Width { get; set; }

    [Column("HEIGHT", TypeName = "NUMBER(18,3)")]
    public decimal? Height { get; set; }

    [Column("LOTID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Lotid { get; set; }

    [Column("LOTNUMBER")]
    [StringLength(50)]
    public string? Lotnumber { get; set; }

    [Column("INBOUNDDATE", TypeName = "NUMBER(38)")]
    public decimal? Inbounddate { get; set; }

    [Column("BOMCODE")]
    [StringLength(50)]
    public string? Bomcode { get; set; }

    [Column("CONTAINERID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Containerid { get; set; }

    [Column("VERSION")]
    [StringLength(50)]
    public string? Version { get; set; }

    [Column("RECEIVINGLOTNUMBER")]
    [StringLength(50)]
    public string? Receivinglotnumber { get; set; }

    [Column("CONTAINERBARCODE")]
    [StringLength(50)]
    public string? Containerbarcode { get; set; }

    [Column("BOMID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Bomid { get; set; }

    [Column("SCHEMEID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Schemeid { get; set; }

    [Column("SCHEMENUMBER")]
    [StringLength(50)]
    public string? Schemenumber { get; set; }

    [Column("SOURCEBILLNUMBER")]
    [StringLength(50)]
    public string? Sourcebillnumber { get; set; }

    [Column("COMMONID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Commonid { get; set; }

    [Column("COMMONNUMBER")]
    [StringLength(50)]
    public string? Commonnumber { get; set; }

    [Column("PARENTID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Parentid { get; set; }

    [Column("LOCATIONSTATE")]
    [StringLength(50)]
    public string? Locationstate { get; set; }

    [Column("USERID")]
    [StringLength(50)]
    public string? Userid { get; set; }

    [Column("CREATETIME", TypeName = "DATE")]
    public DateTime Createtime { get; set; }

    [Column("FIELD1")]
    [StringLength(50)]
    public string? Field1 { get; set; }

    [Column("FIELD2")]
    [StringLength(50)]
    public string? Field2 { get; set; }

    [Column("FIELD3")]
    [StringLength(50)]
    public string? Field3 { get; set; }

    [Column("FIELD4")]
    [StringLength(50)]
    public string? Field4 { get; set; }

    [Column("FIELD5")]
    [StringLength(50)]
    public string? Field5 { get; set; }

    [Column("ACT_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ActStatus { get; set; }

    [Column("OUTFLAG")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Outflag { get; set; }

    [Column("TT_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TtStatus { get; set; }

    [Column("DISABLEPUTTRAYINFO")]
    [StringLength(200)]
    public string? Disableputtrayinfo { get; set; }

    [Column("ERRORINFO")]
    [StringLength(200)]
    public string? Errorinfo { get; set; }

    [Column("MOVEFLAG")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Moveflag { get; set; }

    [Column("UPDATETIME")]
    [StringLength(20)]
    public string? Updatetime { get; set; }

    [Column("LOCATIONTYPE")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Locationtype { get; set; }

    [Column("REQUESTTIME", TypeName = "DATE")]
    public DateTime? Requesttime { get; set; }

    [Column("REQUESTTIME2", TypeName = "DATE")]
    public DateTime? Requesttime2 { get; set; }

    [Column("REQUESTTIME3", TypeName = "DATE")]
    public DateTime? Requesttime3 { get; set; }

    [Column("REWORKFLAG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Reworkflag { get; set; }

    [Column("INSPECTFLAG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Inspectflag { get; set; }

    [Column("PRIORITY")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [Column("PER_EQUIPMENTID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? PerEquipmentid { get; set; }

    [Column("PER_TECHNOLOGYID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? PerTechnologyid { get; set; }
}
