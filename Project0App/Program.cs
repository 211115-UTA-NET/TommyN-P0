namespace Project0App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /// <summary>
            /// Create an account or log in and shop with this menu.
            /// </summary>
            /// <param name="shopping">Tells if the user wants to shop or not</param>
            /// <param name="logging">Tells if the user is logged in to be able to shop or not</param>
            /// <param name="input">User makes own input</param>
            /// 
            bool shopping = true;
            bool logging = false;
            string? firstName = "";
            string? lastName = "";
            string? username = "";
            string? password = "";
            double funds = 0;
            double cost;
            int limit;

            while (shopping)
            {

                Console.WriteLine($"Welcome to the online shopping console app." +
                    $"              \nWhat would you like to do?" +
                    $"              \n1. Create online shop account" +
                    $"              \n2. Log in to your shop account");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    bool validInput = int.TryParse(input, out _);
                    if (validInput)
                    {
                        switch (int.Parse(input))
                        {
                            case 1:
                                /// <summary>
                                /// Create an account or log in and shop with this menu.
                                /// </summary>
                                /// <param name="shopping">Tells if the user wants to shop or not</param>
                                /// <param name="logging">Tells if the user is logged in to be able to shop or not</param>
                                do
                                {
                                    Console.WriteLine("Please enter your first name.");
                                    firstName = Console.ReadLine();
                                }
                                while (firstName is null or "");
                                do
                                {
                                    Console.WriteLine("Please enter your last name.");
                                    lastName = Console.ReadLine();
                                }
                                while (lastName is null or "");
                                do
                                {
                                    Console.WriteLine("Please enter the username you want to create.");
                                    username = Console.ReadLine();
                                }
                                while (username is null or "");
                                do
                                {
                                    Console.WriteLine("Please enter the password for your username.");
                                    password = Console.ReadLine();
                                }
                                while (password is null or "");
                                Console.Write("For creating a new shopping account, you will receive $10 as bonus credit.\n");
                                funds += 10.00;
                                logging = true;
                                break;

                            case 2:
                                string? tempuser = null;
                                string? temppass = null;
                                while (tempuser != username && temppass != password)
                                {
                                    do
                                    {
                                        Console.WriteLine("Please enter your username.");
                                        tempuser = Console.ReadLine();
                                    }
                                    while (tempuser is null or "");
                                    do
                                    {
                                        Console.WriteLine("Please enter your password.");
                                        temppass = Console.ReadLine();
                                    }
                                    while (temppass is null or "");
                                }
                                logging = true;
                                break;

                            case 3:
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

                while (shopping && logging)
                {
                    Console.WriteLine($"Welcome {firstName} {lastName}");
                    Console.WriteLine($"What would you like to do?" +
                        $"              \n1. Make an order." +
                        $"              \n2. List order history." +
                        $"              \n3. Quit.");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        bool validInput = int.TryParse(input, out _);
                        if (validInput)
                        {
                            switch (int.Parse(input))
                            {
                                case 1:
                                    bool ordering = true;
                                    while (ordering)
                                    {
                                        Console.WriteLine($"What would you like to order?" +
                                            $"              \n1. Orange Juice" +
                                            $"              \n2. Turkey Slices" +
                                            $"              \n3. Water Jug" +
                                            $"              \n4. IPhone Charger" +
                                            $"              \n5. XBox X" +
                                            $"              \n6. Cancel order");
                                        input = Console.ReadLine();
                                        if (input != null)
                                        {
                                            validInput = int.TryParse(input, out _);
                                            if (validInput)
                                            {
                                                switch (int.Parse(input))
                                                {
                                                    case 1:
                                                        limit = 10;
                                                        cost = 1.99;
                                                        Console.WriteLine($"How many do you wish to order? (limit: {limit})");
                                                        input = Console.ReadLine();
                                                        if (input != null)
                                                        {
                                                            validInput = int.TryParse(input, out _);
                                                            if (validInput && int.Parse(input) < limit + 1)
                                                            {
                                                                if ((cost * double.Parse(input)) <= funds)
                                                                {
                                                                    funds = funds - (cost * double.Parse(input));
                                                                    Console.WriteLine($"Thank you for ordering! you ordered:" +
                                                                        $"               \n{input} Orange(s)" +
                                                                        $"               \nYou now have ${funds}");
                                                                    ordering = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Not enough funds!");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Something went wrong; You either sent in a bad input or you asked for amount over the limit.");
                                                            }
                                                        }
                                                        break;
                                                    case 3:
                                                        limit = 4;
                                                        cost = 0.99;
                                                        Console.WriteLine($"How many do you wish to order? (limit: {limit})");
                                                        input = Console.ReadLine();
                                                        if (input != null)
                                                        {
                                                            validInput = int.TryParse(input, out _);
                                                            if (validInput && int.Parse(input) < limit + 1)
                                                            {
                                                                if ((cost * double.Parse(input)) <= funds)
                                                                {
                                                                    funds = funds - (cost * double.Parse(input));
                                                                    Console.WriteLine($"Thank you for ordering! you ordered:" +
                                                                        $"               \n{input} Water Jug(s)" +
                                                                        $"               \nYou now have ${funds}");
                                                                    ordering = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Not enough funds!");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Something went wrong; You either sent in a bad input or you asked for amount over the limit.");
                                                            }
                                                        }
                                                        break;
                                                    case 5:
                                                        limit = 1;
                                                        cost = 299.99;
                                                        Console.WriteLine($"How many do you wish to order? (limit: {limit})");
                                                        input = Console.ReadLine();
                                                        if (input != null)
                                                        {
                                                            validInput = int.TryParse(input, out _);
                                                            if (validInput && int.Parse(input) < limit + 1)
                                                            {
                                                                if ((cost * double.Parse(input)) <= funds)
                                                                {
                                                                    funds = funds - (cost * double.Parse(input));
                                                                    Console.WriteLine($"Thank you for ordering! you ordered:" +
                                                                        $"               \n{input} X Box(es)" +
                                                                        $"               \nYou now have ${funds}");
                                                                    ordering = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Not enough funds!");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine($"Something went wrong; You either sent in a bad input or you asked for amount over the limit.");
                                                            }
                                                        }
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{input} is not a valid input. Enter the number in the list and try again.");
                                            }
                                        }

                                    }

                                    break;

                                case 2:
                                    Console.WriteLine($"Order History Method not implemented.");
                                    break;

                                case 3:
                                    Console.WriteLine($"Thank you for using the online shopping console app.");
                                    logging = false;
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
}