using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement.Entities
{
    public class OrderDetail
    {
        [Key, System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [StringLength(250)]
        public string PositionCode { get; set; }
        [StringLength(250)]
        public string ColorId { get; set; }
        public int OrderCount { get; set; }
        [StringLength(250)]
        public string ReleasedCount { get; set; }
        [StringLength(800)]
        public string Explanation { get; set; }
        public int Priorty { get; set; }
    }
}
