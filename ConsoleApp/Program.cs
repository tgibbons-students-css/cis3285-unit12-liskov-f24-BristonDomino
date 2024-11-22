using SubtypeCovariance;

class Program
{
    static void Main(string[] args)
    {

        IEntityRepository<User> userRepository = new UserRepository();
        User myUser = userRepository.GetByID(Guid.NewGuid());

        myUser.Name = "Tom";
        Console.WriteLine("New entity ID: " + myUser.ID.ToString());
        Console.WriteLine("New entity Name: " + myUser.Name);

    }
}