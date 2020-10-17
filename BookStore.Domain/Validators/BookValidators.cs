using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Domain.Validators
{
    public class BookValidators
    {
        public static void ValidTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new MissingTitle();
        }

        public static void ValidAuthors(List<Author> authors)
        {
            if (authors == null)
                throw new MissingAuthors();

            if (!authors.Any())
                throw new MissingAuthors();
        }
    }
}
