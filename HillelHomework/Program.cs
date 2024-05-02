namespace HillelHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(9);
            user.ChangeFirstName();
            user.ChangeLastName();
            user.ChangeGender();
            Console.WriteLine(user.ToString());

        }
    }
}
