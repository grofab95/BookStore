using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class Image
    {
        public string Path { get; }

        public Image(Path path)
        {
            Path = path.Value;

            ImageValidators.ValidImageExtension(Path);
        }
    }
}
