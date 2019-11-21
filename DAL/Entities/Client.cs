namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Living = new HashSet<Living>();
            ServiceCustomers = new HashSet<ServiceCustomers>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        public int seria { get; set; }

        public int number { get; set; }

        [Required]
        [StringLength(50)]
        public string adress { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_bith { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Living> Living { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceCustomers> ServiceCustomers { get; set; }
    }
}
