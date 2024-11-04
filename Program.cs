namespace assignment1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine("My name is " +myName + ",I am " +age +",and I live on " +address +".");
        }
    }
}
