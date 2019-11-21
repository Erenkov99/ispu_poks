namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceCustomers
    {
        [Key]
        public int NumberSC { get; set; }

        public int ID { get; set; }

        public int Scode { get; set; }

        public int PaymentFact { get; set; }

        public DateTime ServTime { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }
    }
}
