namespace Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string User_Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Password { get; set; }
    }
}
