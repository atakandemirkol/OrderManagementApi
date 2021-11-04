using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Entities
{
    public class Order
    {
        [Key, System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [StringLength(250)]
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderTypeId { get; set; }
        public int OrderStateId { get; set; }
        public int OrderCount { get; set; }
        public int ModelId { get; set; }
        [StringLength(800)]
        public string Explanation { get; set; }
    }
}
