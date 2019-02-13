namespace Sports.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatchRound")]
    public partial class MatchRound
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
