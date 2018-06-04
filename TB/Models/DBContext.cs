using Microsoft.EntityFrameworkCore;

namespace TB.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> option) : base(option)
        {

        }
        //Database Table Name
        public DbSet<TBL_MS_CHANGWAT> TBL_MS_CHANGWAT { get; set; }
        public DbSet<TBL_MS_TAMBON> TBL_MS_TAMBON { get; set; }
        public DbSet<TBL_MS_AMPUR> TBL_MS_AMPUR { get; set; }
        public DbSet<TBL_REQUEST_USER> TBL_REQUEST_USER { get; set; }
        public DbSet<TBL_MS_HOSP_CODE> TBL_MS_HOSP_CODE { get; set; }
        public DbSet<TBL_MS_DEFINE_CODE> TBL_MS_DEFINE_CODE { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_TB>(entity =>
            {
                entity.HasKey(e => e.TB_ID);

                entity.ToTable("TBL_TB");

                entity.HasIndex(e => e.DATE_REGIS)
                    .HasName("NonClusteredIndex-20171108-140051");

                entity.HasIndex(e => new { e.HOSP_ID, e.TBNO, e.PATIENT_ID })
                    .HasName("NonClusteredIndex-20170830-095913");

                entity.Property(e => e.TB_ID)
                    .HasColumnName("TB_ID")
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd();
            });
                modelBuilder.Entity<TBL_MS_DEFINE_CODE>()
                .HasKey(c => new {c.MAJOR,c.MINOR });
            modelBuilder.Entity<TBL_MS_HOSP_CODE>()
                .Property(c => c.LATITUDE)
                .HasColumnType("float");
            modelBuilder.Entity<TBL_MS_HOSP_CODE>()
                .Property(c => c.LOGITUDE)
                .HasColumnType("float");
            modelBuilder.Entity<TBL_MS_TAMBON>()
                .Property(c => c.LATITUDE)
                .HasColumnType("float");
            modelBuilder.Entity<TBL_MS_TAMBON>()
                .Property(c => c.LONGTITUDE)
                .HasColumnType("float");
            modelBuilder.Entity<TBL_MS_TAMBON>()
                .Property(c => c.POLYGON)
                .HasColumnType("text");
            modelBuilder.Entity<TBL_MS_AMPUR>()
                .Property(c => c.LATITUDE)
                .HasColumnType("float");
            modelBuilder.Entity<TBL_MS_AMPUR>()
                .Property(c => c.LONGTITUDE)
                .HasColumnType("float");
            modelBuilder.Entity<TBL_MS_AMPUR>()
                .Property(c => c.POLYGON)
                .HasColumnType("text");

        }
        public DbSet<TBL_REQUEST_USER_GROUP> TBL_REQUEST_USER_GROUP { get; set; }
        public DbSet<TBL_TB> TBL_TB { get; set; }
    }
}
