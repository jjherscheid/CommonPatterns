using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobilePhones.DataAcess.Model
{
    /// <summary>
    /// Manufactor of Mobile Phones
    /// </summary>
    public class Manufacturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }

        public virtual ICollection<MobilePhone> Devices { get; set; }
    }
}
