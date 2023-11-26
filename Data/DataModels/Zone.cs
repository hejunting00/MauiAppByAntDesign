using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Table("ZONE")]
[Index("Warehouseid", "Code", Name = "U_ZONE1", IsUnique = true)]
public partial class Zone
{
    [Column("WAREHOUSEID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Warehouseid { get; set; }

    [Key]
    [Column("ZONEID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Zoneid { get; set; } = null!;

    [Column("CODE")]
    [StringLength(50)]
    public string? Code { get; set; }

    [Column("NAME")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(100)]
    public string? Description { get; set; }

    [Column("TYPECODE")]
    [StringLength(50)]
    public string? Typecode { get; set; }

    [Column("USERID")]
    [StringLength(50)]
    public string? Userid { get; set; }

    [Column("CREATETIME", TypeName = "DATE")]
    public DateTime? Createtime { get; set; }

    [Column("FIELD1", TypeName = "NUMBER")]
    public decimal? Field1 { get; set; }

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
}
