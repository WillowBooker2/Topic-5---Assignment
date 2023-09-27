using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace Topic_5___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what would you like to open today?");
            Console.WriteLine("1. Banking");
            Console.WriteLine("2. Garage Sale");
            Console.WriteLine("3. Bill Payment");
            int select = Convert.ToInt32(Console.ReadLine());

            if (select == 1)
            {
                Console.WriteLine("Certainly. Right this way.");
                Thread.Sleep(1000);
                Bank();
            }

            else if (select == 2)
            {
                Console.WriteLine("Certainly. Right this way.");
                Thread.Sleep(1000);
                Parking();
            }

            else if (select == 3) 
            {
                Console.WriteLine("Certainly. Right this way.");
                Thread.Sleep(1000);
                Hurricane();
            }
        }


        public static void Bank() 
        {
            double dollar = 150.0;
            double account = 100.0;
            double total = dollar - 0.75;
            
            
            Console.WriteLine("Hello, please choose one option.");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawl");
            Console.WriteLine("3. Bill Payment (Type bill for short)");
            Console.WriteLine("4. Account Balance Update (Type balance for short)");
            string choose = Console.ReadLine().Trim().ToUpper();

            if (choose == "DEPOSIT" || choose == "DEPOSIT.")
            {
                Console.WriteLine("How much would you like to deposit?");
                double deposit = Convert.ToDouble(Console.ReadLine().Trim().ToUpper());
                if (deposit < 99.25 && deposit > 0)
                {
                    double amount = dollar + deposit - 0.75;
                    Console.WriteLine($"Great. You now have ${amount} left in your bank account.");
                    Thread.Sleep(1000);
                }

                else if (deposit <= 0) 
                {
                    Console.WriteLine("Sorry, we cannot except less than 0 Blorbian dollars.");
                }

                else if (deposit > 99.25)
                {
                    Console.WriteLine("Sorry, but you're depositting too much.");
                }
            }

            else if (choose == "WITHDRAWL" || choose == "WITHDRAWL.")
            {
                Console.WriteLine("You have 150 Blorbian dollars, how much would you like to withdrawl?");
                double withdraw = Convert.ToDouble(Console.ReadLine().Trim().ToUpper());
                if (withdraw < 150 && withdraw > 0) 
                {
                    double all = withdraw - 0.75;
                    Console.WriteLine($"Perfect. You have withdrawed ${all}, have a nice day.");
                    Thread.Sleep(1000);
                    
                }
            }

            else if (choose == "BILL" || choose == "BILL.")
            {
                Console.WriteLine("You have a bill you need to pay, how much would you like to pay?");
                double payment = Convert.ToDouble(Console.ReadLine().Trim().ToUpper());
                double bill = payment - 0.75;
                if ((payment <= dollar - 0.75) && (payment > 0))
                {
                    Console.WriteLine($"You have payed ${bill}, thank you. Have a good day.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Press 2 to check out the Garage Parking across the street, Press 3 to check out the Hurricane down the street, press 4 to leave.");
                }

                else if (payment > dollar - 0.75) 
                {
                    Console.WriteLine("You FISH! How dare you not pay! Now you will pay by leaving!");
                }
            }

            else if (choose == "BALANCE" || choose == "BALANCE.")
            {
                Console.WriteLine($"You have ${dollar} left in your account. (:");
                Thread.Sleep(1000);
                Console.WriteLine("Press 2 to check out the Garage Parking across the street, Press 3 to check out the Hurricane down the street, press 4 to leave.");
                
            }
        }

        public static void Parking()
        {
            Console.WriteLine("Hello, it seems you've used Sam's parking garage. Please let me know how long you've used it in minutes.");
            double time = Convert.ToDouble(Console.ReadLine().Trim().ToUpper());
            double pay = time / 60 * 2 + 2;

            if (time > 0 && time < 540.01)
            {
                Console.WriteLine($"You have used Sam's parking garage for {time}, you'll have to pay {pay.ToString("C")}, please.");
            }

            else if (time > 540.01)
            {
                Console.WriteLine($"Sorry, I can't calculate that high of a price. You'll have to pay $20, please.");
            }

            else if (time < 0) 
            {
                Console.WriteLine("Cool, pay $10000.");
            }


        }

        public static void Hurricane() 
        {
            
            Console.WriteLine("Hello, did you know there are 5 catergories of hurricanes based on their wind and speed? Well, now you do.");
            Console.WriteLine(" Please choose a number through 1 - 5, to learn about that category of hurricane.");
            int category = Convert.ToInt32(Console.ReadLine().Trim().ToUpper());
            switch (category)
            {
                case 1: 
                    Console.WriteLine("A catergory 1 hurricane has winds speeds of 74 - 95 mph, 119 - 153 km/hr or 64 - 82 knots.");
                    break;

                case 2:
                    Console.WriteLine("A catergory 2 hurricane has winds speeds of 96 - 110 mph, 154 - 177 km/hr, or 83 - 95 knots.");
                    break;

                case 3:
                    Console.WriteLine("A catergory 3 hurricane has winds speeds of 111 - 130 mph, 178 - 209 km/hr, or 96 - 113 knots");
                    break;

                case 4:
                    Console.WriteLine("A catergory 4 hurricane has winds speeds of 131 - 150 mph, 210 - 249 km/hr, or 114 - 135knots");
                    break;

                case 5:
                    Console.WriteLine("A catergory 5 hurricane has winds speeds of greater than 150 mph, 249 km/hr, 135 or knots");
                    break;

            }

        }

    }
}