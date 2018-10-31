using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MobilePhones.DataAcess.Model;

namespace MobilePhones.DataAccess
{
    public class MobilePhonesContext : DbContext
    {
        public MobilePhonesContext() : base("MobilePhonesContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<MobilePhonesContext>(new MobilePhonesInitialize());
        }

        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.ComplexType<ScreenSize>();
            modelBuilder.ComplexType<ScreenSize>().Property(a => a.Height).HasColumnName("Screen_Heigth");
            modelBuilder.ComplexType<ScreenSize>().Property(a => a.Width).HasColumnName("Screen_Width");

        }
    }
}
