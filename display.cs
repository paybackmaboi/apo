using System;

public class Display
{
    private string estorcoAccount;
    private string bsitPassword;
    private double accountBalance;
    private Method method;
int choice;
    public Display()
    {
        estorcoAccount = "Roy";
        bsitPassword = "Estorco";
        accountBalance = 1000.0;

        method = new Method();
    }

    public string EstorcoAccount
    {
        get { return estorcoAccount; }
        set { estorcoAccount = value; }
    }

    public string BsitPassword
    {
        get { return bsitPassword; }
        set { bsitPassword = value; }
    }

    private double AccountBalance
    {
        get { return accountBalance; }
        set { accountBalance = value; }
    }

    public void Sing()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t\tWelcome to the ATM machine!");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\t\t\tThis is your account number: {estorcoAccount}");
        Console.WriteLine($"\t\t\tThis is your account password: {bsitPassword}");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please log in to your account");
        Console.Write("Enter your account name: ");
        string userInputAccount = Console.ReadLine();
        Console.Write("Enter your password: ");
        string userInputPassword = Console.ReadLine();
        if (userInputAccount == estorcoAccount && userInputPassword == bsitPassword)
        {
            Console.WriteLine("Authentication successful!");

            bool exit = false;

        
            
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Inquire balance");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                
                while(!int.TryParse(Console.ReadLine(),out choice)||choice <-1||choice>4){
                    Console.WriteLine("Invalid input");
                    Console.Write("Enter your choice: ");
                }

                switch (choice)
                {
                    case 1:
                        method.Depo(estorcoAccount, ref accountBalance);
                        break;
                    case 2:
                        method.Bal(estorcoAccount, accountBalance);
                        break;
                    case 3:
                        method.Withdraw(estorcoAccount, ref accountBalance);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Do you want to perform another transaction?");
                    Console.WriteLine("1. Check balance");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("4. Log in another account");

                    Console.Write("Enter your choice: ");
                    int transactionChoice = Convert.ToInt32(Console.ReadLine());

                    switch (transactionChoice)
                    {
                        case 1:
                            method.Bal(estorcoAccount, accountBalance);
                            break;
                        case 2:
                            method.Withdraw(estorcoAccount, ref accountBalance);
                            break;
                        case 3:
                            Console.WriteLine("Exiting...");
                            exit = true;
                            break;
                        case 4:
                            Console.WriteLine("Logging in another account...");
                            Sing();
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
            
        }
        else
        {
            Console.WriteLine("Authentication failed. Please try again.");
            Console.WriteLine("Hello");
            Sing();
        }
    }
}

