using System;
using System.Collections.Generic;

namespace NTI_NG_MAUI.DataModels;

public partial class LmepSystemUser
{
    public decimal TId { get; set; }

    public string Userid { get; set; }

    public string Userpswd { get; set; }

    public string Username { get; set; }

    public string Usersex { get; set; }

    public string Usergroup { get; set; }

    public string Userarea { get; set; }

    public string Userip { get; set; }

    public DateTime? Userlogindt { get; set; }

    public decimal? Userloginnum { get; set; }

    public string Userloginapp { get; set; }

    public string Note { get; set; }

    public DateTime? CreateDate { get; set; }

    public string CreatedBy { get; set; }

    public string ModifyIp { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string LastModifiedBy { get; set; }

    public string ActStatus { get; set; }
}
