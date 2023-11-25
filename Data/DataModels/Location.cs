using System;
using System.Collections.Generic;

namespace NTI_NG_MAUI.DataModels;

public partial class Location
{
    public string Warehouseid { get; set; }

    public string Zoneid { get; set; }

    public string Locationid { get; set; }

    public string Locationnumber { get; set; }

    public decimal Locationline { get; set; }

    public decimal Locationcolumn { get; set; }

    public decimal Locationlayer { get; set; }

    public decimal Locationdepth { get; set; }

    public string Locationflag { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public string Lotid { get; set; }

    public string Lotnumber { get; set; }

    public decimal? Inbounddate { get; set; }

    public string Bomcode { get; set; }

    public string Containerid { get; set; }

    public string Version { get; set; }

    public string Receivinglotnumber { get; set; }

    public string Containerbarcode { get; set; }

    public string Bomid { get; set; }

    public string Schemeid { get; set; }

    public string Schemenumber { get; set; }

    public string Sourcebillnumber { get; set; }

    public string Commonid { get; set; }

    public string Commonnumber { get; set; }

    public string Parentid { get; set; }

    public string Locationstate { get; set; }

    public string Userid { get; set; }

    public DateTime Createtime { get; set; }

    public string Field1 { get; set; }

    public string Field2 { get; set; }

    public string Field3 { get; set; }

    public string Field4 { get; set; }

    public string Field5 { get; set; }

    public string ActStatus { get; set; }

    public string Outflag { get; set; }

    public string TtStatus { get; set; }

    public string Disableputtrayinfo { get; set; }

    public string Errorinfo { get; set; }

    public string Moveflag { get; set; }

    public string Updatetime { get; set; }

    public string Locationtype { get; set; }

    public DateTime? Requesttime { get; set; }

    public DateTime? Requesttime2 { get; set; }

    public DateTime? Requesttime3 { get; set; }

    public string Reworkflag { get; set; }

    public string Inspectflag { get; set; }

    public string Priority { get; set; }

    public string PerEquipmentid { get; set; }

    public string PerTechnologyid { get; set; }
}
