using BKart.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BKart.Domain.Promotion
{
    public class Promotion : BaseEntity
    {
        public string Name { get; set; }
        public string AdminComment { get; set; }
        public int DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? MaximumDiscountAmount { get; set; }
        public DateTime? StartDate{ get; set; }
        public DateTime? EndDate { get; set; }
        public string CouponCode { get; set; }
    }
}
