using BookStore.Validators;

namespace BookStore.Domain.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        public Category(string name)
        {
            CategoryValidator.ValidName(name);

            Name = name;
        }
    }
}
