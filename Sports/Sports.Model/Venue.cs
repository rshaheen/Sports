namespace Sports.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venue")]
    public partial class Venue
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? City { get; set; }

        public int? Country { get; set; }

        public string Picture { get; set; }
    }
}
