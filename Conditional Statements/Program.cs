namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userName = "admin";
            string password = "1234";

            Console.WriteLine("enter userName");

            string userInput = Console.ReadLine();

            Console.WriteLine("enter passsword");
            string passInput = Console.ReadLine();

            if (userInput == userName && passInput == password)
            {
                Console.WriteLine("welcome to the system");



            }
            else
            {
                Console.WriteLine("invalid username or password");
            }
        } 
    }
}
