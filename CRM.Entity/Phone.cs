namespace CRM.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column("Phone")]
        [StringLength(11)]
        public string Phone1 { get; set; }

        public int? CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
