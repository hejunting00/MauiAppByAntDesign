using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Table("LMEP_SYSTEM_USER")]
public partial class LmepSystemUser
{
    [Key]
    [Column("T_ID", TypeName = "NUMBER(22)")]
    public decimal TId { get; set; }

    [Column("USERID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Userid { get; set; } = null!;

    [Column("USERPSWD")]
    [StringLength(100)]
    [Unicode(false)]
    public string Userpswd { get; set; } = null!;

    [Column("USERNAME")]
    [StringLength(100)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("USERSEX")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Usersex { get; set; }

    [Column("USERGROUP")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Usergroup { get; set; }

    [Column("USERAREA")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Userarea { get; set; }

    [Column("USERIP")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Userip { get; set; }

    [Column("USERLOGINDT", TypeName = "DATE")]
    public DateTime? Userlogindt { get; set; }

    [Column("USERLOGINNUM", TypeName = "NUMBER(32)")]
    public decimal? Userloginnum { get; set; }

    [Column("USERLOGINAPP")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Userloginapp { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note { get; set; }

    [Column("CREATE_DATE", TypeName = "DATE")]
    public DateTime? CreateDate { get; set; }

    [Column("CREATED_BY")]
    [StringLength(32)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column("MODIFY_IP")]
    [StringLength(32)]
    [Unicode(false)]
    public string? ModifyIp { get; set; }

    [Column("MODIFY_DATE", TypeName = "DATE")]
    public DateTime? ModifyDate { get; set; }

    [Column("LAST_MODIFIED_BY")]
    [StringLength(32)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [Column("ACT_STATUS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ActStatus { get; set; }
}
