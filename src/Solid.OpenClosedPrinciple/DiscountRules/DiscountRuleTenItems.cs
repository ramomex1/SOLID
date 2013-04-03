namespace Solid.OpenClosedPrinciple.DiscountRules
{
    public class DiscountRuleTenItems : IDiscountRule
    {
        public decimal DiscountAmount
        {
            get { return 15; }
        }

        public bool Match(int itemCount)
        {
            return itemCount >= 10 && itemCount < 15;
        }
    }
}