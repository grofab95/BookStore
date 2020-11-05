using BookStore.Common.Extensions;
using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Domain.Validators
{
    public class BookValidators
    {
        public static void ValidTitle(string title)
        {
            if (title.IsNotExist())
                throw new ArgumentException("Title is required.");
        }

        public static void ValidAuthors(List<Author> authors)
        {
            if (authors == null || !authors.Any())
                throw new ArgumentException("Authors are required.");
        }
    }
}
