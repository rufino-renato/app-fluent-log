namespace TesteLog.Domain.Entities
{
    public class User : Entity<User>
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
