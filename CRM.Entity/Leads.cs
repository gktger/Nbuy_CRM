namespace CRM.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leads
    {
        [Key]
        public int LeadID { get; set; }

        public int CustomerID { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        public string LeadNote { get; set; }

        public DateTime Tarih { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
