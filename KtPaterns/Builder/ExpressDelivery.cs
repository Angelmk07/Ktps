namespace KtPaterns.Builder
{
    class ExpressDelivery : OrderDecorator
    {
        public ExpressDelivery(IOrder order) : base(order) { }

        public override string GetDescription()
        {
            return order.GetDescription() + ", оперативная доставка";
        }

        public override int GetPrice()
        {
            return order.GetPrice() + 20; 
        }
    }
}
