namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Living")]
    public partial class Living
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumberL { get; set; }

        public int ID { get; set; }

        public int Room_number { get; set; }

        public DateTime Zaselenie { get; set; }

        public DateTime Vyselenie { get; set; }

        [Column(TypeName = "money")]
        public decimal SumToPay { get; set; }

        [Column(TypeName = "money")]
        public decimal Paid { get; set; }

        public virtual Client Client { get; set; }

        public virtual Room Room { get; set; }
    }
}
