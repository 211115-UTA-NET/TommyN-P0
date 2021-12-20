namespace Project0App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            bool shopping = true;

            Console.WriteLine($"Welcome to the online shopping console app." +
                $"              \nWhat would you like to do?" +
                $"              \n1. Create online shop account" +
                $"              \n2. Log in to your shop account");
            if (input != null)
            {
                bool validInput = int.TryParse(input, out _);
                if (validInput)
                {
                    switch (int.Parse(input)-1) //swap out with enums
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        default:
                            Console.WriteLine($"{input} is not a valid number. Enter the number in the list and try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid input. Enter the number in the list and try again.");
                }
            }


            string? firstName;
            do
            {
                Console.WriteLine("Please enter your first name.");
                firstName = Console.ReadLine();
            }
            while (firstName == null || firstName == "");
            string? lastName;
            do
            {
                Console.WriteLine("Please enter your first name.");
                lastName = Console.ReadLine();
            }
            while (lastName == null || lastName == "");

            Console.WriteLine($"Welcome {firstName} {lastName}");

            
            while (shopping)
            {
                Console.WriteLine($"What would you like to do?" +
                    $"              \n1. Make an order." +
                    $"              \n2. List order history." +
                    $"              \n3. Quit.");
                if (input != null)
                {
                    bool validInput = int.TryParse(input, out _);
                    if (validInput)
                    {
                        switch (int.Parse(input)-1) //swap out with enums
                        {
                            case 1:
                                break;

                            case 2:
                                break;

                            case 3:
                                Console.WriteLine($"Thank you for using the online shopping console app." +
                                    "              \n Closing program.");
                                shopping = false;
                                break;

                            default:
                                Console.WriteLine($"{input} is not a valid number. Enter the number in the list and try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{input} is not a valid input. Enter the number in the list and try again.");
                    }
                }
            }
        }
    }
}