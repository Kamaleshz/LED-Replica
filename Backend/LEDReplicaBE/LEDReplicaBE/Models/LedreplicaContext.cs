using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LEDReplicaBE.Models;

public partial class LedreplicaContext : DbContext
{
    public LedreplicaContext()
    {
    }

    public LedreplicaContext(DbContextOptions<LedreplicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnnualRequestRole> AnnualRequestRoles { get; set; }

    public virtual DbSet<AnnualRequestRoleMaster> AnnualRequestRoleMasters { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CountryMaster> CountryMasters { get; set; }

    public virtual DbSet<MemberFirm> MemberFirms { get; set; }

    public virtual DbSet<RequestLevel> RequestLevels { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleMaster> RoleMasters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<UserTypeMaster> UserTypeMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source =KANINI-LTP-682; initial catalog = LEDReplica; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnnualRequestRole>(entity =>
        {
            entity.HasKey(e => e.AnnualRequestRoleId).HasName("PK__AnnualRe__EA8EBFDBA5FAF8F7");

            entity.ToTable("AnnualRequestRole");

            entity.Property(e => e.AnnualRequestRoleId).HasColumnName("AnnualRequestRoleID");
            entity.Property(e => e.AnnualRequestRoleMasterId).HasColumnName("AnnualRequestRoleMasterID");
            entity.Property(e => e.RequestLevelId).HasColumnName("RequestLevelID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AnnualRequestRoleMaster).WithMany(p => p.AnnualRequestRoles)
                .HasForeignKey(d => d.AnnualRequestRoleMasterId)
                .HasConstraintName("FK_AnnualRequestRole_AnnualRequestRoleMaster");

            entity.HasOne(d => d.RequestLevel).WithMany(p => p.AnnualRequestRoles)
                .HasForeignKey(d => d.RequestLevelId)
                .HasConstraintName("FK_AnnualRequestRole_RequestLevel");

            entity.HasOne(d => d.User).WithMany(p => p.AnnualRequestRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AnnualRequestRole_Users");
        });

        modelBuilder.Entity<AnnualRequestRoleMaster>(entity =>
        {
            entity.HasKey(e => e.AnnualRequestRoleMasterId).HasName("PK__AnnualRe__881815AC9DF6DE86");

            entity.ToTable("AnnualRequestRoleMaster");

            entity.HasIndex(e => e.AnnualRequestRoleMasterName, "UQ__AnnualRe__67039AFBAB6F6E00").IsUnique();

            entity.Property(e => e.AnnualRequestRoleMasterId).HasColumnName("AnnualRequestRoleMasterID");
            entity.Property(e => e.AnnualRequestRoleMasterName).HasMaxLength(100);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__10D160BF5D2813EE");

            entity.ToTable("Country");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryMasterId).HasColumnName("CountryMasterID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.CountryMaster).WithMany(p => p.Countries)
                .HasForeignKey(d => d.CountryMasterId)
                .HasConstraintName("FK_Country_CountryMaster");

            entity.HasOne(d => d.User).WithMany(p => p.Countries)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Country_Users");
        });

        modelBuilder.Entity<CountryMaster>(entity =>
        {
            entity.HasKey(e => e.CountryMasterId).HasName("PK__CountryM__A62FF52909E7DEFD");

            entity.ToTable("CountryMaster");

            entity.HasIndex(e => e.CountryName, "UQ__CountryM__E056F2011B73F6BA").IsUnique();

            entity.Property(e => e.CountryMasterId).HasColumnName("CountryMasterID");
            entity.Property(e => e.CountryName).HasMaxLength(100);
        });

        modelBuilder.Entity<MemberFirm>(entity =>
        {
            entity.HasKey(e => e.MemberFirmId).HasName("PK__MemberFi__66BE3180B1FA16C9");

            entity.ToTable("MemberFirm");

            entity.HasIndex(e => e.MemberFirmName, "UQ__MemberFi__9BE5C5CF00F21EF5").IsUnique();

            entity.Property(e => e.MemberFirmName).HasMaxLength(100);
        });

        modelBuilder.Entity<RequestLevel>(entity =>
        {
            entity.HasKey(e => e.RequestLevelId).HasName("PK__RequestL__BA4F24E1F0E562DC");

            entity.ToTable("RequestLevel");

            entity.HasIndex(e => e.RequestLevelName, "UQ__RequestL__24DF3010B8B301E2").IsUnique();

            entity.Property(e => e.RequestLevelName).HasMaxLength(100);

            entity.HasOne(d => d.MemberFirm).WithMany(p => p.RequestLevels)
                .HasForeignKey(d => d.MemberFirmId)
                .HasConstraintName("FK_RequesLevel_MemberFirm");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE3A2891B8A8");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleMasterId).HasColumnName("RoleMasterID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.RoleMaster).WithMany(p => p.Roles)
                .HasForeignKey(d => d.RoleMasterId)
                .HasConstraintName("FK_Role_RoleMaster");

            entity.HasOne(d => d.User).WithMany(p => p.Roles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Role_Users");
        });

        modelBuilder.Entity<RoleMaster>(entity =>
        {
            entity.HasKey(e => e.RoleMasterId).HasName("PK__RoleMast__16530E25F15FA403");

            entity.ToTable("RoleMaster");

            entity.HasIndex(e => e.RoleName, "UQ__RoleMast__8A2B6160A213AE71").IsUnique();

            entity.Property(e => e.RoleMasterId).HasColumnName("RoleMasterID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC06F5A7E3");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
        });

        modelBuilder.Entity<UserType>(entity =>
        {
            entity.HasKey(e => e.UserTypeId).HasName("PK__UserType__40D2D8167812B0A2");

            entity.ToTable("UserType");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserTypeMasterId).HasColumnName("UserTypeMasterID");

            entity.HasOne(d => d.User).WithMany(p => p.UserTypes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserType_Users");

            entity.HasOne(d => d.UserTypeMaster).WithMany(p => p.UserTypes)
                .HasForeignKey(d => d.UserTypeMasterId)
                .HasConstraintName("FK_UserType_UserTypeMaster");
        });

        modelBuilder.Entity<UserTypeMaster>(entity =>
        {
            entity.HasKey(e => e.UserTypeMasterId).HasName("PK__UserType__35AAEDDDCC134E0F");

            entity.ToTable("UserTypeMaster");

            entity.HasIndex(e => e.UserTypeName, "UQ__UserType__9262CB71F549863D").IsUnique();

            entity.Property(e => e.UserTypeMasterId).HasColumnName("UserTypeMasterID");
            entity.Property(e => e.UserTypeName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
