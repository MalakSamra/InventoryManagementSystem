namespace Inventory_System
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Request")]
    public partial class Request
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Req_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Supplier_Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string WH_Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime Production_Date { get; set; }

        [Required]
        [StringLength(30)]
        public string Validity_Period { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
