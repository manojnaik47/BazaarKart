using BKart.Domain.Promotion;
using System;
using System.Collections.Generic;
using System.Text;

namespace BKart.Services.Promotions
{
    public interface IPromotionService
    {
        void AddPromotion(Promotion promotion);
        void UpdatePromotion(Promotion promotion);
        void DeletePromotion(Promotion promotion);
        Promotion GetPromotionById(long Id);
        decimal GetDiscountAmount(Promotion promotion, decimal amount);
        List<Promotion> GetPreferredPromotion(IList<Promotion> promotions,
            decimal amount, out decimal discountAmount);
        bool ContainsDiscount(IList<Promotion> discounts, Promotion promotion);
    }
}
