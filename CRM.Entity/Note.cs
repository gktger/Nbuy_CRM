namespace CRM.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Note")]
    public partial class Note
    {
        public int NoteID { get; set; }

        public int CustomerID { get; set; }

        [Column("Note")]
        [Required]
        public string Note1 { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
