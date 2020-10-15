using BookStore.Validators;
using System;
using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class Book : EntityBase
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public List<Author> Authors { get; set; }

        public Book(string title, Category category)
        {
            BookValidators.ValidTitle(title);

            Title = title;            
            Category = category;
            Authors = new List<Author>();
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
