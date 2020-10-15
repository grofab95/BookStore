using BookStore.Common.Validators;

namespace BookStore.Domain.Entities
{
    public class Image
    {
        public string Path { get; set; }

        public Image(Path path)
        {
            Path = path.Value;

            ImageValidators.ValidImageExtension(Path);
        }
    }
}
