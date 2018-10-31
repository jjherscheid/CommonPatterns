using System;

namespace MobilePhones.DataAcess.Model
{
    /// <summary>
    /// Enum for holding features
    /// </summary>
    [Flags]
    public enum Features
    {
        None = 0,
        Bluetooth = 1,
        FrontCamera = 2,
        BackCamera = 4,
        UsbC = 8,
        Headphone = 16
    }
}
