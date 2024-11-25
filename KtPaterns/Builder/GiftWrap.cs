namespace KtPaterns.Builder
{
    class GiftWrap : OrderDecorator
    {
        public GiftWrap(IOrder order) : base(order) { }

        public override string GetDescription()
        {
            return order.GetDescription() + ", упаковка подарка";
        }

        public override int GetPrice()
        {
            return order.GetPrice() + 10;
        }
    }
}
