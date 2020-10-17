using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; }

        public Category(string name)
        {
            CategoryValidators.ValidName(name);

            Name = name;
        }
    }
}
