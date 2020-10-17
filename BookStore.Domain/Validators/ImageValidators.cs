using BookStore.Common.Enums;
using BookStore.Common.Exceptions;
using System;
using System.Linq;

namespace BookStore.Domain.Validators
{
    public class ImageValidators
    {
        public static void ValidImageExtension(string path)
        {
            var extension = path.Split('.').LastOrDefault()
                ?? throw new MissingExtension();

            if (!Enum.IsDefined(typeof(ImageExtension), extension.Trim()))
                throw new InvalidImageExtension();
        }
    }
}
