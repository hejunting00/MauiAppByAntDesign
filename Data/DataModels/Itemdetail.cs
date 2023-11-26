using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

[Keyless]
[Table("ITEMDETAIL")]
[Index("Zoneid", "Itemposition", "Containerbarcode", "Version", Name = "ITEMDETAIL_INDEX")]
public partial class Itemdetail
{
    [Column("CONTAINERDETAILID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Containerdetailid { get; set; } = null!;

    [Column("ZONEID")]
    [StringLength(50)]
    public string Zoneid { get; set; } = null!;

    [Column("CONTAINERBARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Containerbarcode { get; set; } = null!;

    [Column("ITEMID")]
    [StringLength(32)]
    [Unicode(false)]
    public string Itemid { get; set; } = null!;

    [Column("ITEMNAME")]
    [StringLength(50)]
    public string? Itemname { get; set; }

    [Column("ITEMBARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Itembarcode { get; set; }

    [Column("ITEMPOSITION")]
    [StringLength(50)]
    public string? Itemposition { get; set; }

    [Column("THICKNESS", TypeName = "NUMBER(38)")]
    public decimal? Thickness { get; set; }

    [Column("VOLTAGE1", TypeName = "NUMBER(18,3)")]
    public decimal? Voltage1 { get; set; }

    [Column("CURRENT1", TypeName = "NUMBER(18,3)")]
    public decimal? Current1 { get; set; }

    [Column("CAPACITY1", TypeName = "NUMBER(18,3)")]
    public decimal? Capacity1 { get; set; }

    [Column("ERRORCODE1")]
    [StringLength(50)]
    public string? Errorcode1 { get; set; }

    [Column("VOLTAGE2", TypeName = "NUMBER(18,3)")]
    public decimal? Voltage2 { get; set; }

    [Column("CURRENT2", TypeName = "NUMBER(18,3)")]
    public decimal? Current2 { get; set; }

    [Column("CAPACITY2", TypeName = "NUMBER(18,3)")]
    public decimal? Capacity2 { get; set; }

    [Column("ERRORCODE2")]
    [StringLength(50)]
    public string? Errorcode2 { get; set; }

    [Column("OCVVOLTAGE1", TypeName = "NUMBER(18,3)")]
    public decimal? Ocvvoltage1 { get; set; }

    [Column("OCVVOLTAGE2", TypeName = "NUMBER(18,3)")]
    public decimal? Ocvvoltage2 { get; set; }

    [Column("OCVVOLTAGE3", TypeName = "NUMBER(18,3)")]
    public decimal? Ocvvoltage3 { get; set; }

    [Column("DCIRRESISTANCE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Dcirresistance { get; set; }

    [Column("DCIRNG")]
    [StringLength(32)]
    public string? Dcirng { get; set; }

    [Column("FXCAPACITY4", TypeName = "NUMBER(18,3)")]
    public decimal? Fxcapacity4 { get; set; }

    [Column("FXCAPACITY2", TypeName = "NUMBER(18,3)")]
    public decimal? Fxcapacity2 { get; set; }

    [Column("STARTTIME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Starttime { get; set; }

    [Column("FINISHEDTIME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Finishedtime { get; set; }

    [Column("CHECKCURRENT", TypeName = "NUMBER(18,3)")]
    public decimal? Checkcurrent { get; set; }

    [Column("PICKSTATUS")]
    [StringLength(32)]
    public string? Pickstatus { get; set; }

    [Column("CREATETIME", TypeName = "DATE")]
    public DateTime? Createtime { get; set; }

    [Column("VOLTAGE3", TypeName = "NUMBER(18,3)")]
    public decimal? Voltage3 { get; set; }

    [Column("VOLTAGE4", TypeName = "NUMBER(18,3)")]
    public decimal? Voltage4 { get; set; }

    [Column("VOLTAGE5", TypeName = "NUMBER(18,3)")]
    public decimal? Voltage5 { get; set; }

    [Column("VOLTAGE6", TypeName = "NUMBER(18,3)")]
    public decimal? Voltage6 { get; set; }

    [Column("ERRORCODE3")]
    [StringLength(50)]
    public string? Errorcode3 { get; set; }

    [Column("ERRORCODE4")]
    [StringLength(50)]
    public string? Errorcode4 { get; set; }

    [Column("ERRORCODE5")]
    [StringLength(50)]
    public string? Errorcode5 { get; set; }

    [Column("ERRORCODE6")]
    [StringLength(50)]
    public string? Errorcode6 { get; set; }

    [Column("VTIME1")]
    [StringLength(50)]
    public string? Vtime1 { get; set; }

    [Column("T1VOLTAGE", TypeName = "NUMBER(18,3)")]
    public decimal? T1voltage { get; set; }

    [Column("T2VOLTAGE", TypeName = "NUMBER(18,3)")]
    public decimal? T2voltage { get; set; }

    [Column("T3VOLTAGE", TypeName = "NUMBER(18,3)")]
    public decimal? T3voltage { get; set; }

    [Column("CURRENT3", TypeName = "NUMBER(18,3)")]
    public decimal? Current3 { get; set; }

    [Column("CURRENT4", TypeName = "NUMBER(18,3)")]
    public decimal? Current4 { get; set; }

    [Column("CURRENT5", TypeName = "NUMBER(18,3)")]
    public decimal? Current5 { get; set; }

    [Column("CURRENT6", TypeName = "NUMBER(18,3)")]
    public decimal? Current6 { get; set; }

    [Column("CAPACITY3", TypeName = "NUMBER(18,3)")]
    public decimal? Capacity3 { get; set; }

    [Column("CAPACITY4", TypeName = "NUMBER(18,3)")]
    public decimal? Capacity4 { get; set; }

    [Column("CAPACITY5", TypeName = "NUMBER(18,3)")]
    public decimal? Capacity5 { get; set; }

    [Column("CAPACITY6", TypeName = "NUMBER(18,3)")]
    public decimal? Capacity6 { get; set; }

    [Column("CVTIME1")]
    [StringLength(50)]
    public string? Cvtime1 { get; set; }

    [Column("CVTIME2")]
    [StringLength(50)]
    public string? Cvtime2 { get; set; }

    [Column("CVTIME3")]
    [StringLength(50)]
    public string? Cvtime3 { get; set; }

    [Column("CVTIME4")]
    [StringLength(50)]
    public string? Cvtime4 { get; set; }

    [Column("CVTIME5")]
    [StringLength(50)]
    public string? Cvtime5 { get; set; }

    [Column("CVTIME6")]
    [StringLength(50)]
    public string? Cvtime6 { get; set; }

    [Column("CVCAPACITY1", TypeName = "NUMBER(18,3)")]
    public decimal? Cvcapacity1 { get; set; }

    [Column("CVCAPACITY2", TypeName = "NUMBER(18,3)")]
    public decimal? Cvcapacity2 { get; set; }

    [Column("CVCAPACITY3", TypeName = "NUMBER(18,3)")]
    public decimal? Cvcapacity3 { get; set; }

    [Column("CVCAPACITY4", TypeName = "NUMBER(18,3)")]
    public decimal? Cvcapacity4 { get; set; }

    [Column("CVCAPACITY5", TypeName = "NUMBER(18,3)")]
    public decimal? Cvcapacity5 { get; set; }

    [Column("CVCAPACITY6", TypeName = "NUMBER(18,3)")]
    public decimal? Cvcapacity6 { get; set; }

    [Column("VTIME2")]
    [StringLength(50)]
    public string? Vtime2 { get; set; }

    [Column("VTIME3")]
    [StringLength(50)]
    public string? Vtime3 { get; set; }

    [Column("VTIME4")]
    [StringLength(50)]
    public string? Vtime4 { get; set; }

    [Column("VTIME5")]
    [StringLength(50)]
    public string? Vtime5 { get; set; }

    [Column("VTIME6")]
    [StringLength(50)]
    public string? Vtime6 { get; set; }

    [Column("AVERAGEVOLTAGE", TypeName = "NUMBER(18,3)")]
    public decimal? Averagevoltage { get; set; }

    [Column("ITEMLEVEL")]
    [StringLength(50)]
    public string? Itemlevel { get; set; }

    [Column("GONGYI_HC")]
    [StringLength(20)]
    public string? GongyiHc { get; set; }

    [Column("GONGYI_CD")]
    [StringLength(20)]
    public string? GongyiCd { get; set; }

    [Column("GONGYI_FR")]
    [StringLength(20)]
    public string? GongyiFr { get; set; }

    [Column("UPDATETIME", TypeName = "DATE")]
    public DateTime? Updatetime { get; set; }

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

    [Column("FIELD6")]
    [StringLength(50)]
    public string? Field6 { get; set; }

    [Column("TEMPERATURE1", TypeName = "NUMBER(18,3)")]
    public decimal? Temperature1 { get; set; }

    [Column("TEMPERATURE2", TypeName = "NUMBER(18,3)")]
    public decimal? Temperature2 { get; set; }

    [Column("TEMPERATURE3", TypeName = "NUMBER(18,3)")]
    public decimal? Temperature3 { get; set; }

    [Column("TEMPERATURE4", TypeName = "NUMBER(18,3)")]
    public decimal? Temperature4 { get; set; }

    [Column("TEMPERATURE5", TypeName = "NUMBER(18,3)")]
    public decimal? Temperature5 { get; set; }

    [Column("TEMPERATURE6", TypeName = "NUMBER(18,3)")]
    public decimal? Temperature6 { get; set; }

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

    [Column("T_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TId { get; set; }

    [Column("REWORKFLAG", TypeName = "NUMBER")]
    public decimal? Reworkflag { get; set; }

    [Column("VERSION")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Version { get; set; }

    [Column("FROMSTATION")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Fromstation { get; set; }

    [Column("BINDRESULT")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Bindresult { get; set; }

    [Column("OPERATION_NG")]
    [StringLength(20)]
    public string? OperationNg { get; set; }

    [Column("STATUS_HC", TypeName = "NUMBER(38)")]
    public decimal? StatusHc { get; set; }

    [Column("STATUSFLAG")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Statusflag { get; set; }

    [Column("STATUS_OCV1", TypeName = "NUMBER(38)")]
    public decimal? StatusOcv1 { get; set; }

    [Column("STATUS_OCV2", TypeName = "NUMBER(38)")]
    public decimal? StatusOcv2 { get; set; }

    [Column("STATUS_OCVB", TypeName = "NUMBER(38)")]
    public decimal? StatusOcvb { get; set; }

    [Column("STATUS_OCVC", TypeName = "NUMBER(38)")]
    public decimal? StatusOcvc { get; set; }

    [Column("OCVOUTTYPE", TypeName = "NUMBER(38)")]
    public decimal? Ocvouttype { get; set; }

    [Column("CONTAINERID")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Containerid { get; set; }

    [Column("HEATTIME", TypeName = "NUMBER")]
    public decimal? Heattime { get; set; }

    [Column("HC_RESULT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? HcResult { get; set; }

    [Column("OCV1_RESULT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Ocv1Result { get; set; }
}
