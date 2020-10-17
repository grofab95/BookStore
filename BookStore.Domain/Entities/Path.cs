using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class Path
    {
        public string Value { get; set; }

        public Path(string value)
        {
            PathValidators.ValidPath(value);

            Value = value;
        }
    }
}
