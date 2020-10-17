using BookStore.Domain.Abstract;
using BookStore.Domain.Validators;
using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class Book : EntityBase, StockInfo
    {
        public string Title { get; }
        public Category Category { get; }
        public Stock Stock { get; set; }
        public List<Author> Authors { get; }

        public Book(string title, Category category, int vat, List<Author> authors)
        {
            BookValidators.ValidTitle(title);
            BookValidators.ValidAuthors(authors);

            Title = title;            
            Category = category;
            Authors = authors;
            Stock = new Stock(vat);
        }

        public int GetQuantity() => Stock.Quantity;
    }
}
