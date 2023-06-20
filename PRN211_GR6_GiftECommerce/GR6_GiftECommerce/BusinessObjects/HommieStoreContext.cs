using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObjects
{
    public partial class HommieStoreContext : DbContext
    {
        public HommieStoreContext()
        {
        }

        public HommieStoreContext(DbContextOptions<HommieStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblcart> Tblcarts { get; set; }
        public virtual DbSet<Tblcategory> Tblcategories { get; set; }
        public virtual DbSet<Tblorder> Tblorders { get; set; }
        public virtual DbSet<TblorderDetail> TblorderDetails { get; set; }
        public virtual DbSet<Tblproduct> Tblproducts { get; set; }
        public virtual DbSet<Tbluser> Tblusers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local); Database=HommieStore; Uid=sa; Pwd=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tblcart>(entity =>
            {
                entity.ToTable("tblcart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastTimeUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("last_time_updated");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Tblcategory>(entity =>
            {
                entity.ToTable("tblcategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Tblorder>(entity =>
            {
                entity.ToTable("tblorder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_updated_time");

                entity.Property(e => e.Message)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.OrderTime)
                    .HasColumnType("datetime")
                    .HasColumnName("order_time");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WardCode).HasColumnName("ward_code");
            });

            modelBuilder.Entity<TblorderDetail>(entity =>
            {
                entity.ToTable("tblorder_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Tblproduct>(entity =>
            {
                entity.ToTable("tblproduct");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("last_updated_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Tbluser>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK_user");

                entity.ToTable("tbluser");

                entity.Property(e => e.Email)
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Address)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(59)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.WardCode).HasColumnName("ward_code");

                entity.Property(e => e.Yob).HasColumnName("yob");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
