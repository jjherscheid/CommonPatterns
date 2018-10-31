using System.Data.Entity;

namespace MobilePhones.DataAccess
{
    public class MobilePhonesInitialize : DropCreateDatabaseIfModelChanges<MobilePhonesContext>
    {
        protected override void Seed(MobilePhonesContext context)
        {
            MobilePhonesSeed.Manufacturers.ForEach(m => context.Manufacturers.Add(m));
            MobilePhonesSeed.MobilePhones.ForEach(mp => context.MobilePhones.Add(mp));
        }
    }
}
