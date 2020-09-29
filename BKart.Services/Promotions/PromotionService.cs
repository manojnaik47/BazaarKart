using BKart.Domain.Promotion;
using System;
using System.Collections.Generic;
using System.Text;
using BKart.Services.User;
using BKart.Services.Logger;
using BKart.Services.Product;


namespace BKart.Services.Promotions
{
    public class PromotionService : IPromotionService
    {

        private  IUserService _userService;
        private  IProductService _productService;
        private  ILoggerService _loggerService;


        public PromotionService(IUserService userService,
                IProductService productService,
                ILoggerService loggerService    
        )
        {
            _userService = userService;
            _productService = productService;
            _loggerService = loggerService;            
        }

        public void AddPromotion(Promotion promotion){}
        public void UpdatePromotion(Promotion promotion) { }
        public void DeletePromotion(Promotion promotion) { }
        public Promotion GetPromotionById(long Id) { return null; }
        public double GetDiscountAmount(Promotion promotion, double amount) { return 0.0; }
        public List<Promotion> GetPreferredPromotion(IList<Promotion> promotions,
            double amount, out double discountAmount) 
        {
            discountAmount = 0;
            return null; 
        }
        public bool ContainsDiscount(IList<Promotion> discounts, Promotion promotion) { return false; }
    }
}
