using Microsoft.EntityFrameworkCore;

namespace BapApi.Models
{
    public class StoreAppsContext : DbContext
    {
        public DbSet<StoreApp> StoreApps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=storeapps.db");
    }

}
