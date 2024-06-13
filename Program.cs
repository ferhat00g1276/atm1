class Program
{
    static void Main(string[] args)
    {
        float balance = 1000;
        string pin = "1234";
        string enteredPin;
        int option;
        int pinTry = 0;
        float withdrawAmount,depositAmount;
        bool exit=false;
        while (pinTry<3 & exit!=true) {
            Console.WriteLine("Enter the pin:");
            enteredPin = Console.ReadLine();
            if ( enteredPin!=pin) { 
                pinTry++;
                Console.WriteLine($"Wrong pin: tries {pinTry}/3");
                continue;
            }else
            {
               while (exit!=true) {
                    Console.WriteLine(
@"1.Show balance
2. Withdraw money
3.Deposit money
4.Change pin
");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine($"{balance}$");
                            break;

                        case 2:
                            Console.WriteLine("How much would you like to withdraw?");
                            withdrawAmount = Convert.ToSingle(Console.ReadLine());
                            try
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"{balance}$");
                                break;
                            }
                            catch() { }
                            
                        case 3:
                            Console.WriteLine("How much would you like to deposit?");
                            depositAmount = Convert.ToSingle(Console.ReadLine());
                            balance += depositAmount;
                            Console.WriteLine($"{balance}$");
                            break;
                        case 4:
                            Console.WriteLine("What is going to be your new pin");
                            pin = Console.ReadLine();
                            Console.WriteLine("Pin Updated");
                            break;
                            case 5:
                                exit = true;    
                            break;
                        default:
                            Console.WriteLine("Wrong option!");
                            break;
                    }
                }
                
            }
        }
    }
}
