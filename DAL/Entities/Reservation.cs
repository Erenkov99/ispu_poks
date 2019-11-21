namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [Key]
        public int NumberR { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public int RoomNumber { get; set; }

        public DateTime Rstart { get; set; }

        public DateTime Rend { get; set; }

        public virtual Room Room { get; set; }
    }
}
