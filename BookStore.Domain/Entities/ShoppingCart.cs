using BookStore.Domain.Abstract;
using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class ShoppingCart<T> where T : StockInfo
    {
        public Customer Customer { get; }
        public List<ShoppingCartPosition<T>> Positions { get; set; }

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
        }
    }
}
