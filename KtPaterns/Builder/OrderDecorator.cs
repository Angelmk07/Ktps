namespace KtPaterns.Builder
{
    abstract class OrderDecorator : IOrder
    {
        protected IOrder order;

        protected OrderDecorator(IOrder order)
        {
            this.order = order;
        }

        public abstract string GetDescription();

        public abstract int GetPrice();
    }
}
