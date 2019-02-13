namespace Sports.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TeamPlayer")]
    public partial class TeamPlayer
    {
        public int Id { get; set; }

        public int? PlayerId { get; set; }

        public int? TeamId { get; set; }

        public int? TeamRoleId { get; set; }

        public virtual Player Player { get; set; }

        public virtual Team Team { get; set; }

        public virtual TeamRole TeamRole { get; set; }
    }
}
