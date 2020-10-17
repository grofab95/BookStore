using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;
using BookStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Domain.Validators
{
    public class BookValidators
    {
        public static void ValidTitle(string title)
        {
            if (title.IsNotExist())
                throw new MissingTitle();
        }

        public static void ValidAuthors(List<Author> authors)
        {
            if (authors == null || !authors.Any())
                throw new MissingAuthors();
        }
    }
}
