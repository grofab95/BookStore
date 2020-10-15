using BookStore.Common.Enums;
using BookStore.Common.Validators;
using System;

namespace BookStore.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var path = "localization/file.exe";

            ImageValidators.ValidImageExtension(path);

            var test = Enum.IsDefined(typeof(ImageExtension), path);
        }
    }
}
