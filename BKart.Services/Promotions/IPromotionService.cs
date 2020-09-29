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
        double GetDiscountAmount(Promotion promotion, double amount);
        List<Promotion> GetPreferredPromotion(IList<Promotion> promotions,
            double amount, out double discountAmount);
        bool ContainsDiscount(IList<Promotion> discounts, Promotion promotion);
    }
}
