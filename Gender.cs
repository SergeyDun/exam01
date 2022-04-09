namespace exam01
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        [Key]
        [StringLength(1)]
        public string Code { get; set; }

        [StringLength(10)]
        public string Name { get; set; }
    }
}
