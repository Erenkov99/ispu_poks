namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Types()
        {
            Room = new HashSet<Room>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomType { get; set; }

        [Required]
        [StringLength(50)]
        public string description { get; set; }

        [Column(TypeName = "money")]
        public decimal dayCost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Room { get; set; }
    }
}
