namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            while (true)
            {

                Console.WriteLine(" Welcome to the Upward Bank!");
                Console.WriteLine($"How much do you want to deposit?");
                double amountToAdd;
                bool willParse = double.TryParse(Console.ReadLine(), out amountToAdd);
                while (!willParse)
                {
                    Console.WriteLine($"Invalid, Please Try Again.");
                    Console.WriteLine("Enter a valid amount:");
                    willParse = double.TryParse(Console.ReadLine(), out amountToAdd);

                }
                account.Deposit(amountToAdd);
                Console.WriteLine($"Ammount Deposited!");

                Console.WriteLine($"Do you want to see your balance?");
                Console.WriteLine($"Please enter 'yes' or 'no'");

                var cont = Console.ReadLine();
                while (cont != "yes" && cont != "no")
                {
                    Console.WriteLine($"Invalid please enter 'yes' or 'no'");
                    cont = Console.ReadLine();
                }

                switch (cont)
                {
                    case "yes":
                        Console.WriteLine($"Current Balance {account.GetBalance()}");
                        break;

                    case "no":
                        Console.WriteLine($"No Problem, Have a good day!");
                        return;

                }

            }
        }

    }
}
