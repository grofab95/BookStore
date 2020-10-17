using BookStore.Common.Exceptions;
using BookStore.Domain.Abstract;

namespace BookStore.Domain.Entities
{
    public class ShoppingCartPosition<T> where T : StockInfo
    {
        public T Position { get; set; }
        public int Quantity { get; set; }

        public ShoppingCartPosition(T position, int quantity)
        {
            if (quantity <= 0)
                throw new NegativeQuantity();

            Position = position;
            Quantity = quantity;
        }

        public void AddQuantity(int value)
        {
            if (value <= 0)
                throw new NegativeQuantity();

            if (Position.GetQuantity() < value)
                throw new NotEnoughQuantity();

            Quantity += value;
        }

        public void SubtractQuantity(int value)
        {
            if (value <= 0)
                throw new NegativeQuantity();

            var quantityAfterDecrase = Quantity -= value;
            if (quantityAfterDecrase < 0)
                throw new MissingQuantityToDecrease();

            Quantity = quantityAfterDecrase;
        }
    }
}
