using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Table("NG_LOG")]
public partial class NgLog
{
    [Key]
    [Column("T_ID", TypeName = "NUMBER")]
    public decimal TId { get; set; }

    [Column("USERNUMBER")]
    [StringLength(100)]
    public string Usernumber { get; set; } = null!;

    [Column("USERNAME")]
    [StringLength(100)]
    public string Username { get; set; } = null!;

    [Column("T_LOG")]
    [StringLength(100)]
    public string TLog { get; set; } = null!;

    [Column("CREATIME", TypeName = "DATE")]
    public DateTime Creatime { get; set; }

    [Column("BARCODE")]
    [StringLength(100)]
    public string? Barcode { get; set; }

    [Column("ITEMCODE")]
    [StringLength(200)]
    public string? Itemcode { get; set; }
}
