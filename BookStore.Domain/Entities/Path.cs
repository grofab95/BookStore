using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class Path : EntityBase
    {
        public string Value { get; }

        public Path(string value)
        {
            PathValidators.ValidPath(value);

            Value = value;
        }
    }
}
