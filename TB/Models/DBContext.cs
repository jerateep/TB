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
    }
}
