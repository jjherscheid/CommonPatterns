using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobilePhones.DataAcess.Model
{
    /// <summary>
    /// Mobile Phone information
    /// </summary>
    public class MobilePhone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public virtual decimal Price { get; set; }
        public virtual ScreenSize ScreenSize { get; set; }
        public virtual Features Features { get; set; }
    }
}
