using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NTI_NG_MAUI.DataModels;

public partial class ModelContext : DbContext
{
    private static string dbIpaddress = "172.168.11.3";
    private static string username = "cwms";
    private static string password = "ntidba";
    private static string serviceName = "ORCL";
    string connect = string.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={1})));User Id={2};Password={3};", dbIpaddress, serviceName, username, password); 
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Itemdetail> Itemdetails { get; set; }

    public virtual DbSet<LmepSystemUser> LmepSystemUsers { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<WcsSubtaskinfo> WcsSubtaskinfos { get; set; }

    public virtual DbSet<WcsTaskinfo> WcsTaskinfos { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle(connect,t=>t.UseOracleSQLCompatibility("11"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("CWMS");

        modelBuilder.Entity<Itemdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITEMDETAIL");

            entity.HasIndex(e => new { e.Zoneid, e.Itemposition, e.Containerbarcode, e.Version }, "ITEMDETAIL_INDEX");

            entity.Property(e => e.ActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("1\n")
                .IsFixedLength()
                .HasColumnName("ACT_STATUS");
            entity.Property(e => e.Averagevoltage)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("AVERAGEVOLTAGE");
            entity.Property(e => e.Bindresult)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("BINDRESULT");
            entity.Property(e => e.Capacity1)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CAPACITY1");
            entity.Property(e => e.Capacity2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CAPACITY2");
            entity.Property(e => e.Capacity3)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CAPACITY3");
            entity.Property(e => e.Capacity4)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CAPACITY4");
            entity.Property(e => e.Capacity5)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CAPACITY5");
            entity.Property(e => e.Capacity6)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CAPACITY6");
            entity.Property(e => e.Checkcurrent)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CHECKCURRENT");
            entity.Property(e => e.Containerbarcode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTAINERBARCODE");
            entity.Property(e => e.Containerdetailid)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONTAINERDETAILID");
            entity.Property(e => e.Containerid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONTAINERID");
            entity.Property(e => e.CreateDate)
                .HasColumnType("DATE")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Createtime)
                .HasColumnType("DATE")
                .HasColumnName("CREATETIME");
            entity.Property(e => e.Current1)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CURRENT1");
            entity.Property(e => e.Current2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CURRENT2");
            entity.Property(e => e.Current3)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CURRENT3");
            entity.Property(e => e.Current4)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CURRENT4");
            entity.Property(e => e.Current5)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CURRENT5");
            entity.Property(e => e.Current6)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CURRENT6");
            entity.Property(e => e.Cvcapacity1)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CVCAPACITY1");
            entity.Property(e => e.Cvcapacity2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CVCAPACITY2");
            entity.Property(e => e.Cvcapacity3)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CVCAPACITY3");
            entity.Property(e => e.Cvcapacity4)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CVCAPACITY4");
            entity.Property(e => e.Cvcapacity5)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CVCAPACITY5");
            entity.Property(e => e.Cvcapacity6)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("CVCAPACITY6");
            entity.Property(e => e.Cvtime1)
                .HasMaxLength(50)
                .HasColumnName("CVTIME1");
            entity.Property(e => e.Cvtime2)
                .HasMaxLength(50)
                .HasColumnName("CVTIME2");
            entity.Property(e => e.Cvtime3)
                .HasMaxLength(50)
                .HasColumnName("CVTIME3");
            entity.Property(e => e.Cvtime4)
                .HasMaxLength(50)
                .HasColumnName("CVTIME4");
            entity.Property(e => e.Cvtime5)
                .HasMaxLength(50)
                .HasColumnName("CVTIME5");
            entity.Property(e => e.Cvtime6)
                .HasMaxLength(50)
                .HasColumnName("CVTIME6");
            entity.Property(e => e.Dcirng)
                .HasMaxLength(32)
                .HasColumnName("DCIRNG");
            entity.Property(e => e.Dcirresistance)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DCIRRESISTANCE");
            entity.Property(e => e.Errorcode1)
                .HasMaxLength(50)
                .HasColumnName("ERRORCODE1");
            entity.Property(e => e.Errorcode2)
                .HasMaxLength(50)
                .HasColumnName("ERRORCODE2");
            entity.Property(e => e.Errorcode3)
                .HasMaxLength(50)
                .HasColumnName("ERRORCODE3");
            entity.Property(e => e.Errorcode4)
                .HasMaxLength(50)
                .HasColumnName("ERRORCODE4");
            entity.Property(e => e.Errorcode5)
                .HasMaxLength(50)
                .HasColumnName("ERRORCODE5");
            entity.Property(e => e.Errorcode6)
                .HasMaxLength(50)
                .HasColumnName("ERRORCODE6");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .HasColumnName("FIELD1");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .HasColumnName("FIELD2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .HasColumnName("FIELD3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .HasColumnName("FIELD4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .HasColumnName("FIELD5");
            entity.Property(e => e.Field6)
                .HasMaxLength(50)
                .HasColumnName("FIELD6");
            entity.Property(e => e.Finishedtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FINISHEDTIME");
            entity.Property(e => e.Fromstation)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("FROMSTATION");
            entity.Property(e => e.Fxcapacity2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("FXCAPACITY2");
            entity.Property(e => e.Fxcapacity4)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("FXCAPACITY4");
            entity.Property(e => e.GongyiCd)
                .HasMaxLength(20)
                .HasColumnName("GONGYI_CD");
            entity.Property(e => e.GongyiFr)
                .HasMaxLength(20)
                .HasColumnName("GONGYI_FR");
            entity.Property(e => e.GongyiHc)
                .HasMaxLength(20)
                .HasColumnName("GONGYI_HC");
            entity.Property(e => e.HcResult)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HC_RESULT");
            entity.Property(e => e.Heattime)
                .HasColumnType("NUMBER")
                .HasColumnName("HEATTIME");
            entity.Property(e => e.Itembarcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEMBARCODE");
            entity.Property(e => e.Itemid)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ITEMID");
            entity.Property(e => e.Itemlevel)
                .HasMaxLength(50)
                .HasColumnName("ITEMLEVEL");
            entity.Property(e => e.Itemname)
                .HasMaxLength(50)
                .HasColumnName("ITEMNAME");
            entity.Property(e => e.Itemposition)
                .HasMaxLength(50)
                .HasColumnName("ITEMPOSITION");
            entity.Property(e => e.LastModifiedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("LAST_MODIFIED_BY");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("DATE")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("MODIFY_IP");
            entity.Property(e => e.Ocv1Result)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OCV1_RESULT");
            entity.Property(e => e.Ocvouttype)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("OCVOUTTYPE");
            entity.Property(e => e.Ocvvoltage1)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("OCVVOLTAGE1");
            entity.Property(e => e.Ocvvoltage2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("OCVVOLTAGE2");
            entity.Property(e => e.Ocvvoltage3)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("OCVVOLTAGE3");
            entity.Property(e => e.OperationNg)
                .HasMaxLength(20)
                .HasColumnName("OPERATION_NG");
            entity.Property(e => e.Pickstatus)
                .HasMaxLength(32)
                .HasColumnName("PICKSTATUS");
            entity.Property(e => e.Reworkflag)
                .HasColumnType("NUMBER")
                .HasColumnName("REWORKFLAG");
            entity.Property(e => e.Starttime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STARTTIME");
            entity.Property(e => e.StatusHc)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("STATUS_HC");
            entity.Property(e => e.StatusOcv1)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("STATUS_OCV1");
            entity.Property(e => e.StatusOcv2)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("STATUS_OCV2");
            entity.Property(e => e.StatusOcvb)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("STATUS_OCVB");
            entity.Property(e => e.StatusOcvc)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("STATUS_OCVC");
            entity.Property(e => e.Statusflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUSFLAG");
            entity.Property(e => e.T1voltage)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("T1VOLTAGE");
            entity.Property(e => e.T2voltage)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("T2VOLTAGE");
            entity.Property(e => e.T3voltage)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("T3VOLTAGE");
            entity.Property(e => e.TId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("sys_guid()")
                .HasColumnName("T_ID");
            entity.Property(e => e.Temperature1)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("TEMPERATURE1");
            entity.Property(e => e.Temperature2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("TEMPERATURE2");
            entity.Property(e => e.Temperature3)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("TEMPERATURE3");
            entity.Property(e => e.Temperature4)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("TEMPERATURE4");
            entity.Property(e => e.Temperature5)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("TEMPERATURE5");
            entity.Property(e => e.Temperature6)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("TEMPERATURE6");
            entity.Property(e => e.Thickness)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("THICKNESS");
            entity.Property(e => e.Updatetime)
                .HasColumnType("DATE")
                .HasColumnName("UPDATETIME");
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VERSION");
            entity.Property(e => e.Voltage1)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("VOLTAGE1");
            entity.Property(e => e.Voltage2)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("VOLTAGE2");
            entity.Property(e => e.Voltage3)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("VOLTAGE3");
            entity.Property(e => e.Voltage4)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("VOLTAGE4");
            entity.Property(e => e.Voltage5)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("VOLTAGE5");
            entity.Property(e => e.Voltage6)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("VOLTAGE6");
            entity.Property(e => e.Vtime1)
                .HasMaxLength(50)
                .HasColumnName("VTIME1");
            entity.Property(e => e.Vtime2)
                .HasMaxLength(50)
                .HasColumnName("VTIME2");
            entity.Property(e => e.Vtime3)
                .HasMaxLength(50)
                .HasColumnName("VTIME3");
            entity.Property(e => e.Vtime4)
                .HasMaxLength(50)
                .HasColumnName("VTIME4");
            entity.Property(e => e.Vtime5)
                .HasMaxLength(50)
                .HasColumnName("VTIME5");
            entity.Property(e => e.Vtime6)
                .HasMaxLength(50)
                .HasColumnName("VTIME6");
            entity.Property(e => e.Zoneid)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("ZONEID");
        });

        modelBuilder.Entity<LmepSystemUser>(entity =>
        {
            entity.HasKey(e => e.TId).HasName("ID_LMEP_SYSTEM_USER");

            entity.ToTable("LMEP_SYSTEM_USER");

            entity.Property(e => e.TId)
                .HasColumnType("NUMBER(22)")
                .HasColumnName("T_ID");
            entity.Property(e => e.ActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACT_STATUS");
            entity.Property(e => e.CreateDate)
                .HasColumnType("DATE")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.LastModifiedBy)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("LAST_MODIFIED_BY");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("DATE")
                .HasColumnName("MODIFY_DATE");
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("MODIFY_IP");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            entity.Property(e => e.Userarea)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("USERAREA");
            entity.Property(e => e.Usergroup)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("USERGROUP");
            entity.Property(e => e.Userid)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERID");
            entity.Property(e => e.Userip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERIP");
            entity.Property(e => e.Userloginapp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USERLOGINAPP");
            entity.Property(e => e.Userlogindt)
                .HasColumnType("DATE")
                .HasColumnName("USERLOGINDT");
            entity.Property(e => e.Userloginnum)
                .HasColumnType("NUMBER(32)")
                .HasColumnName("USERLOGINNUM");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
            entity.Property(e => e.Userpswd)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USERPSWD");
            entity.Property(e => e.Usersex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("USERSEX");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Locationid).HasName("LOCATION_PK");

            entity.ToTable("LOCATION");

            entity.HasIndex(e => e.Containerid, "LOCATION_U01").IsUnique();

            entity.HasIndex(e => e.Locationstate, "STATE_INDEX");

            entity.HasIndex(e => new { e.Warehouseid, e.Zoneid, e.Locationline, e.Locationcolumn, e.Locationlayer, e.Locationdepth }, "U_LOC").IsUnique();

            entity.Property(e => e.Locationid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LOCATIONID");
            entity.Property(e => e.ActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("1\n")
                .IsFixedLength()
                .HasColumnName("ACT_STATUS");
            entity.Property(e => e.Bomcode)
                .HasMaxLength(50)
                .HasColumnName("BOMCODE");
            entity.Property(e => e.Bomid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BOMID");
            entity.Property(e => e.Commonid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COMMONID");
            entity.Property(e => e.Commonnumber)
                .HasMaxLength(50)
                .HasColumnName("COMMONNUMBER");
            entity.Property(e => e.Containerbarcode)
                .HasMaxLength(50)
                .HasColumnName("CONTAINERBARCODE");
            entity.Property(e => e.Containerid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CONTAINERID");
            entity.Property(e => e.Createtime)
                .HasDefaultValueSql("sysdate ")
                .HasColumnType("DATE")
                .HasColumnName("CREATETIME");
            entity.Property(e => e.Disableputtrayinfo)
                .HasMaxLength(200)
                .HasColumnName("DISABLEPUTTRAYINFO");
            entity.Property(e => e.Errorinfo)
                .HasMaxLength(200)
                .HasColumnName("ERRORINFO");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .HasColumnName("FIELD1");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .HasColumnName("FIELD2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .HasColumnName("FIELD3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .HasColumnName("FIELD4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .HasColumnName("FIELD5");
            entity.Property(e => e.Height)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("HEIGHT");
            entity.Property(e => e.Inbounddate)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("INBOUNDDATE");
            entity.Property(e => e.Inspectflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("1\n")
                .HasColumnName("INSPECTFLAG");
            entity.Property(e => e.Length)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("LENGTH");
            entity.Property(e => e.Locationcolumn)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("LOCATIONCOLUMN");
            entity.Property(e => e.Locationdepth)
                .HasDefaultValueSql("1 ")
                .HasColumnType("NUMBER(38)")
                .HasColumnName("LOCATIONDEPTH");
            entity.Property(e => e.Locationflag)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("LOCATIONFLAG");
            entity.Property(e => e.Locationlayer)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("LOCATIONLAYER");
            entity.Property(e => e.Locationline)
                .HasColumnType("NUMBER(38)")
                .HasColumnName("LOCATIONLINE");
            entity.Property(e => e.Locationnumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("LOCATIONNUMBER");
            entity.Property(e => e.Locationstate)
                .HasMaxLength(50)
                .HasColumnName("LOCATIONSTATE");
            entity.Property(e => e.Locationtype)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("LOCATIONTYPE");
            entity.Property(e => e.Lotid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LOTID");
            entity.Property(e => e.Lotnumber)
                .HasMaxLength(50)
                .HasColumnName("LOTNUMBER");
            entity.Property(e => e.Moveflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MOVEFLAG");
            entity.Property(e => e.Outflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OUTFLAG");
            entity.Property(e => e.Parentid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PARENTID");
            entity.Property(e => e.PerEquipmentid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PER_EQUIPMENTID");
            entity.Property(e => e.PerTechnologyid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PER_TECHNOLOGYID");
            entity.Property(e => e.Priority)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("0\n")
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Receivinglotnumber)
                .HasMaxLength(50)
                .HasColumnName("RECEIVINGLOTNUMBER");
            entity.Property(e => e.Requesttime)
                .HasColumnType("DATE")
                .HasColumnName("REQUESTTIME");
            entity.Property(e => e.Requesttime2)
                .HasColumnType("DATE")
                .HasColumnName("REQUESTTIME2");
            entity.Property(e => e.Requesttime3)
                .HasColumnType("DATE")
                .HasColumnName("REQUESTTIME3");
            entity.Property(e => e.Reworkflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REWORKFLAG");
            entity.Property(e => e.Schemeid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SCHEMEID");
            entity.Property(e => e.Schemenumber)
                .HasMaxLength(50)
                .HasColumnName("SCHEMENUMBER");
            entity.Property(e => e.Sourcebillnumber)
                .HasMaxLength(50)
                .HasColumnName("SOURCEBILLNUMBER");
            entity.Property(e => e.TtStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TT_STATUS");
            entity.Property(e => e.Updatetime)
                .HasMaxLength(20)
                .HasColumnName("UPDATETIME");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("USERID");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .HasColumnName("VERSION");
            entity.Property(e => e.Warehouseid)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WAREHOUSEID");
            entity.Property(e => e.Width)
                .HasColumnType("NUMBER(18,3)")
                .HasColumnName("WIDTH");
            entity.Property(e => e.Zoneid)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ZONEID");
        });

        modelBuilder.Entity<WcsSubtaskinfo>(entity =>
        {
            entity.HasKey(e => e.Subtaskno).HasName("WCS_SUBTASKINFO_PK");

            entity.ToTable("WCS_SUBTASKINFO");

            entity.Property(e => e.Subtaskno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SUBTASKNO");
            entity.Property(e => e.ActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("1\n")
                .HasColumnName("ACT_STATUS");
            entity.Property(e => e.Agvcarno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AGVCARNO");
            entity.Property(e => e.Agvikey)
                .HasColumnType("NUMBER")
                .HasColumnName("AGVIKEY");
            entity.Property(e => e.Agvindex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AGVINDEX");
            entity.Property(e => e.Agvmagic)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AGVMAGIC");
            entity.Property(e => e.Agvstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AGVSTATUS");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BARCODE");
            entity.Property(e => e.Createtime)
                .HasColumnType("DATE")
                .HasColumnName("CREATETIME");
            entity.Property(e => e.Currentstation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CURRENTSTATION");
            entity.Property(e => e.Equipmentnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EQUIPMENTNUMBER");
            entity.Property(e => e.Equipmenttype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EQUIPMENTTYPE");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD1");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD5");
            entity.Property(e => e.Field6)
                .HasColumnType("DATE")
                .HasColumnName("FIELD6");
            entity.Property(e => e.Finishedtime)
                .HasColumnType("DATE")
                .HasColumnName("FINISHEDTIME");
            entity.Property(e => e.Fromstation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FROMSTATION");
            entity.Property(e => e.Midstation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MIDSTATION");
            entity.Property(e => e.Runstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RUNSTATUS");
            entity.Property(e => e.Taskno)
                .HasColumnType("NUMBER")
                .HasColumnName("TASKNO");
            entity.Property(e => e.Taskstatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TASKSTATUS");
            entity.Property(e => e.Tostation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOSTATION");
            entity.Property(e => e.Updatetime)
                .HasColumnType("DATE")
                .HasColumnName("UPDATETIME");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERID");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERSION");
            entity.Property(e => e.Warehouseid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSEID");
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<WcsTaskinfo>(entity =>
        {
            entity.HasKey(e => e.Taskid).HasName("WCS_TASKINFO_PK");

            entity.ToTable("WCS_TASKINFO");

            entity.Property(e => e.Taskid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("TASKID");
            entity.Property(e => e.ActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("1\n")
                .HasColumnName("ACT_STATUS");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BARCODE");
            entity.Property(e => e.Bufferflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("0")
                .HasColumnName("BUFFERFLAG");
            entity.Property(e => e.Createtime)
                .HasColumnType("DATE")
                .HasColumnName("CREATETIME");
            entity.Property(e => e.Field1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD1");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIELD5");
            entity.Property(e => e.Fromstation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FROMSTATION");
            entity.Property(e => e.Goodstype)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("0")
                .HasColumnName("GOODSTYPE");
            entity.Property(e => e.Itemname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEMNAME");
            entity.Property(e => e.Itemno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEMNO");
            entity.Property(e => e.Itemqty)
                .HasColumnType("NUMBER")
                .HasColumnName("ITEMQTY");
            entity.Property(e => e.Ledtext)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("LEDTEXT");
            entity.Property(e => e.Outsequenceflag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("0")
                .HasColumnName("OUTSEQUENCEFLAG");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Taskno)
                .HasColumnType("NUMBER")
                .HasColumnName("TASKNO");
            entity.Property(e => e.Taskstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TASKSTATUS");
            entity.Property(e => e.Tasktype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TASKTYPE");
            entity.Property(e => e.Tostation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOSTATION");
            entity.Property(e => e.Updatetime)
                .HasColumnType("DATE")
                .HasColumnName("UPDATETIME");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERSION");
            entity.Property(e => e.Warehouseid)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WAREHOUSEID");
            entity.Property(e => e.Wmsbatchno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WMSBATCHNO");
            entity.Property(e => e.Wmsgroupno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WMSGROUPNO");
            entity.Property(e => e.Wmsorderno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WMSORDERNO");
            entity.Property(e => e.Wmsorderqty)
                .HasColumnType("NUMBER")
                .HasColumnName("WMSORDERQTY");
            entity.Property(e => e.Wmssequenceno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WMSSEQUENCENO");
            entity.Property(e => e.Wmstaskflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WMSTASKFLAG");
            entity.Property(e => e.Wmstaskno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WMSTASKNO");
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.ToTable("ZONE");

            entity.HasIndex(e => new { e.Warehouseid, e.Code }, "U_ZONE1").IsUnique();

            entity.Property(e => e.Zoneid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ZONEID");
            entity.Property(e => e.ActStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACT_STATUS");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("CODE");
            entity.Property(e => e.Createtime)
                .HasColumnType("DATE")
                .HasColumnName("CREATETIME");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Field1)
                .HasColumnType("NUMBER")
                .HasColumnName("FIELD1");
            entity.Property(e => e.Field2)
                .HasMaxLength(50)
                .HasColumnName("FIELD2");
            entity.Property(e => e.Field3)
                .HasMaxLength(50)
                .HasColumnName("FIELD3");
            entity.Property(e => e.Field4)
                .HasMaxLength(50)
                .HasColumnName("FIELD4");
            entity.Property(e => e.Field5)
                .HasMaxLength(50)
                .HasColumnName("FIELD5");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.Typecode)
                .HasMaxLength(50)
                .HasColumnName("TYPECODE");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("USERID");
            entity.Property(e => e.Warehouseid)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WAREHOUSEID");
        });
        modelBuilder.HasSequence("AUTOADD_CONDITIONSEQ");
        modelBuilder.HasSequence("AUTOADD_DRIVERSEQ");
        modelBuilder.HasSequence("AUTOADD_GROUPSEQ");
        modelBuilder.HasSequence("AUTOADD_TAGSEQ");
        modelBuilder.HasSequence("CONTAINERBARCODE").IsCyclic();
        modelBuilder.HasSequence("ORDERNUMBER").IsCyclic();
        modelBuilder.HasSequence("PALLETCODE").IsCyclic();
        modelBuilder.HasSequence("PLSQL_PROFILER_RUNNUMBER");
        modelBuilder.HasSequence("SEQ_A");
        modelBuilder.HasSequence("SEQ_B");
        modelBuilder.HasSequence("WCS_JKSEQ");
        modelBuilder.HasSequence("WCS_SETSUBTASKNO_S").IsCyclic();
        modelBuilder.HasSequence("WCS_SETTASKNO_S").IsCyclic();
        modelBuilder.HasSequence("WCSDIANCHI_NO").IsCyclic();
        modelBuilder.HasSequence("WCSTASK_NO").IsCyclic();
        modelBuilder.HasSequence("YS_EPTYIN01_S").IsCyclic();
        modelBuilder.HasSequence("YS_EPTYOUT01_S").IsCyclic();
        modelBuilder.HasSequence("YS_FULLIN01_S").IsCyclic();
        modelBuilder.HasSequence("YS_FULLIN02_S").IsCyclic();
        modelBuilder.HasSequence("YS_FULLOUT01_S").IsCyclic();
        modelBuilder.HasSequence("YS_WCS_TASKNOTEMP").IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
