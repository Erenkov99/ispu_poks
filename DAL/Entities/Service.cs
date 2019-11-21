namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            ServiceCustomers = new HashSet<ServiceCustomers>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string serviceName { get; set; }

        [Column(TypeName = "money")]
        public decimal cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceCustomers> ServiceCustomers { get; set; }
    }
}
