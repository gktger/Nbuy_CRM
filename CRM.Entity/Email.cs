namespace CRM.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column("Email")]
        [StringLength(250)]
        public string Email1 { get; set; }

        public int? CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
