namespace Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transfer_History
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Product_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime Production_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime Exp_Date { get; set; }

        [Required]
        [StringLength(30)]
        public string From_WH { get; set; }

        [Required]
        [StringLength(30)]
        public string To_WH { get; set; }

        [Required]
        [StringLength(30)]
        public string Supplier_Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime Transaction_Date { get; set; }

        public virtual Product Product { get; set; }
    }
}
