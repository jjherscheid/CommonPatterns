using System.Collections.Generic;
using MobilePhones.DataAcess.Model;

namespace MobilePhones.DataAccess
{
    public static class MobilePhonesSeed
    {
        #region Models for Basic Specifications

        public static List<Manufacturer> Manufacturers = new List<Manufacturer>
        {
            new Manufacturer { Name = "Samsung" },
            new Manufacturer { Name = "Nokia" },
            new Manufacturer { Name = "Sony" },
        };

        public static List<MobilePhone> MobilePhones = new List<MobilePhone>
        {
            new MobilePhone { Name = "S6", Manufacturer = Manufacturers[0], Price = 700, ScreenSize = new ScreenSize { Height = 5, Width = 2 }, Features = Features.BackCamera | Features.Bluetooth | Features.FrontCamera },
            new MobilePhone { Name = "S1", Manufacturer = Manufacturers[0], Price = 100, ScreenSize = new ScreenSize { Height = 8, Width = 3 }, Features = Features.BackCamera | Features.FrontCamera | Features.Headphone  },
            new MobilePhone { Name = "N930", Manufacturer = Manufacturers[1], Price = 400, ScreenSize = new ScreenSize { Height = 6, Width = 3 }, Features = Features.BackCamera | Features.Bluetooth | Features.Headphone },
            new MobilePhone { Name = "N650", Manufacturer = Manufacturers[1], Price = 150, ScreenSize = new ScreenSize { Height = 5, Width = 3 }, Features = Features.BackCamera | Features.UsbC | Features.Headphone  },
            new MobilePhone { Name = "Experia", Manufacturer = Manufacturers[2], Price = 300, ScreenSize = new ScreenSize { Height = 8, Width = 2 }, Features = Features.BackCamera | Features.Bluetooth | Features.Headphone  },
        };

        #endregion
    }
}
