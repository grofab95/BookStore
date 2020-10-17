using BookStore.Domain.Validators;
using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; }
        public Category Category { get; }
        public List<Author> Authors { get; }

        public Book(string title, Category category, List<Author> authors)
        {
            BookValidators.ValidTitle(title);
            BookValidators.ValidAuthors(authors);

            Title = title;            
            Category = category;
            Authors = authors;
        }
    }
}
