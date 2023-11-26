using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MauiAppByAntDesign.Data.DataModels;

public partial class ModelContext : DbContext
{
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

    public virtual DbSet<NgLog> NgLogs { get; set; }

    public virtual DbSet<WcsSubtaskinfo> WcsSubtaskinfos { get; set; }

    public virtual DbSet<WcsTaskinfo> WcsTaskinfos { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.168.11.3)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));User Id=cwms;Password=ntidba;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("CWMS");

        modelBuilder.Entity<Itemdetail>(entity =>
        {
            entity.Property(e => e.ActStatus)
                .HasDefaultValueSql("1\n")
                .IsFixedLength();
            entity.Property(e => e.Containerdetailid).IsFixedLength();
            entity.Property(e => e.Containerid).IsFixedLength();
            entity.Property(e => e.Itemid).IsFixedLength();
            entity.Property(e => e.TId).HasDefaultValueSql("sys_guid()");
            entity.Property(e => e.Version).IsFixedLength();
        });

        modelBuilder.Entity<LmepSystemUser>(entity =>
        {
            entity.HasKey(e => e.TId).HasName("ID_LMEP_SYSTEM_USER");

            entity.Property(e => e.ActStatus).IsFixedLength();
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Locationid).HasName("LOCATION_PK");

            entity.Property(e => e.Locationid).IsFixedLength();
            entity.Property(e => e.ActStatus)
                .HasDefaultValueSql("1\n")
                .IsFixedLength();
            entity.Property(e => e.Bomid).IsFixedLength();
            entity.Property(e => e.Commonid).IsFixedLength();
            entity.Property(e => e.Containerid).IsFixedLength();
            entity.Property(e => e.Createtime).HasDefaultValueSql("sysdate ");
            entity.Property(e => e.Inspectflag).HasDefaultValueSql("1\n");
            entity.Property(e => e.Locationdepth).HasDefaultValueSql("1 ");
            entity.Property(e => e.Lotid).IsFixedLength();
            entity.Property(e => e.Parentid).IsFixedLength();
            entity.Property(e => e.Priority).HasDefaultValueSql("0\n");
            entity.Property(e => e.Schemeid).IsFixedLength();
            entity.Property(e => e.Warehouseid).IsFixedLength();
            entity.Property(e => e.Zoneid).IsFixedLength();
        });

        modelBuilder.Entity<NgLog>(entity =>
        {
            entity.HasKey(e => e.TId).HasName("T_ID");
        });

        modelBuilder.Entity<WcsSubtaskinfo>(entity =>
        {
            entity.HasKey(e => e.Subtaskno).HasName("WCS_SUBTASKINFO_PK");

            entity.Property(e => e.ActStatus).HasDefaultValueSql("1\n");
        });

        modelBuilder.Entity<WcsTaskinfo>(entity =>
        {
            entity.HasKey(e => e.Taskid).HasName("WCS_TASKINFO_PK");

            entity.Property(e => e.ActStatus).HasDefaultValueSql("1\n");
            entity.Property(e => e.Bufferflag).HasDefaultValueSql("0");
            entity.Property(e => e.Goodstype).HasDefaultValueSql("0");
            entity.Property(e => e.Outsequenceflag).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.Property(e => e.Zoneid).IsFixedLength();
            entity.Property(e => e.ActStatus).IsFixedLength();
            entity.Property(e => e.Warehouseid).IsFixedLength();
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
