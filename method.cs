public class Method
{
    public void Depo(string estorcoAccount, ref double accountBalance)
    {
        Console.WriteLine("Deposit option selected");
        Console.Write("Enter the amount to deposit in PHP: ");
        double depositAmountPhp = Convert.ToDouble(Console.ReadLine());

        double newBalance = accountBalance + depositAmountPhp;
        accountBalance = newBalance;
        Console.WriteLine("Deposit of ₱{0:N2} PHP successful.", depositAmountPhp);
        Console.WriteLine("New balance: ₱{0:N2} PHP", newBalance);
    }

    public void Bal(string estorcoAccount, double accountBalance)
    {
        Console.WriteLine("Inquire balance option selected");
        Console.WriteLine("Your current balance is: {0:N2}", accountBalance);
    }

    public void Withdraw(string estorcoAccount, ref double accountBalance)
    {
        Console.WriteLine("Withdraw option selected");
        Console.Write("Enter the amount to withdraw in PHP: ");
        double withdrawAmountPhp = Convert.ToDouble(Console.ReadLine());

        if (withdrawAmountPhp <= accountBalance)
        {
            double newBalanceWithdraw = accountBalance - withdrawAmountPhp;
            accountBalance = newBalanceWithdraw;
            Console.WriteLine("Withdrawal of ₱{0:N2} PHP successful.", withdrawAmountPhp);
            Console.WriteLine("New balance: ₱{0:N2} PHP", newBalanceWithdraw);
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
    }
}
