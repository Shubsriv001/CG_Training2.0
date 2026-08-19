using System;
using System.Collections.Generic;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string HolderName { get; set; }
    public decimal Balance { get; set; }
    public bool IsFrozen { get; set; }
    public decimal DailyWithdrawn { get; set; }
}

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

public class InvalidAccountException : Exception
{
    public InvalidAccountException(string message) : base(message) { }
}

public class DailyLimitExceededException : Exception
{
    public DailyLimitExceededException(string message) : base(message) { }
}

public class AccountFrozenException : Exception
{
    public AccountFrozenException(string message) : base(message) { }
}

public class NetworkException : Exception
{
    public NetworkException(string message) : base(message) { }
}

public class TransactionService
{
    private Dictionary<string, BankAccount> accounts;

    public List<string> transactionLogs = new List<string>();

    public TransactionService(Dictionary<string, BankAccount> accounts)
    {
        this.accounts = accounts;
    }

    public void Withdraw(string accountNo, decimal amount)
    {
        if (!accounts.ContainsKey(accountNo))
            throw new InvalidAccountException($"Account {accountNo} not found.");

        BankAccount account = accounts[accountNo];

        if (account.IsFrozen)
            throw new AccountFrozenException("Account is currently frozen.");

        if (account.DailyWithdrawn + amount > 50000)
            throw new DailyLimitExceededException("Daily withdrawal limit exceeded.");

        if (account.Balance < amount)
            throw new InsufficientFundsException("Insufficient funds.");

        Random random = new Random();

        if (random.Next(1, 10) == 5)
            throw new NetworkException("Unable to connect to banking server.");

        account.Balance -= amount;
        account.DailyWithdrawn += amount;

        transactionLogs.Add(
            $"{DateTime.Now:dd-MMM-yyyy hh:mm tt} Withdraw ₹{amount} - Success");
    }

    public void Deposit(string accountNo, decimal amount)
    {
        if (!accounts.ContainsKey(accountNo))
            throw new InvalidAccountException($"Account {accountNo} not found.");

        BankAccount account = accounts[accountNo];

        if (account.IsFrozen)
            throw new AccountFrozenException("Account is currently frozen.");

        Random random = new Random();

        if (random.Next(1, 10) == 5)
            throw new NetworkException("Unable to connect to banking server.");

        account.Balance += amount;

        transactionLogs.Add(
            $"{DateTime.Now:dd-MMM-yyyy hh:mm tt} Deposit ₹{amount} - Success");
    }

    public void Transfer(string fromAccount, string toAccount, decimal amount)
    {
        if (!accounts.ContainsKey(fromAccount))
            throw new InvalidAccountException($"Account {fromAccount} not found.");

        if (!accounts.ContainsKey(toAccount))
            throw new InvalidAccountException($"Account {toAccount} not found.");

        BankAccount from = accounts[fromAccount];
        BankAccount to = accounts[toAccount];

        if (from.IsFrozen || to.IsFrozen)
            throw new AccountFrozenException("Account is currently frozen.");

        if (from.DailyWithdrawn + amount > 50000)
            throw new DailyLimitExceededException("Daily withdrawal limit exceeded.");

        if (from.Balance < amount)
            throw new InsufficientFundsException("Insufficient funds.");

        Random random = new Random();

        if (random.Next(1, 10) == 5)
            throw new NetworkException("Unable to connect to banking server.");

        from.Balance -= amount;
        to.Balance += amount;
        from.DailyWithdrawn += amount;

        transactionLogs.Add(
            $"{DateTime.Now:dd-MMM-yyyy hh:mm tt} Transfer ₹{amount} - Success");
    }
}

public class Program
{
    public static void Main()
    {
        Dictionary<string, BankAccount> accounts =
            new Dictionary<string, BankAccount>()
            {
                {
                    "ACC1001",
                    new BankAccount
                    {
                        AccountNumber = "ACC1001",
                        HolderName = "Pankaj",
                        Balance = 25000,
                        IsFrozen = false,
                        DailyWithdrawn = 10000
                    }
                },
                {
                    "ACC1002",
                    new BankAccount
                    {
                        AccountNumber = "ACC1002",
                        HolderName = "Rahul",
                        Balance = 100000,
                        IsFrozen = true,
                        DailyWithdrawn = 0
                    }
                }
            };

        TransactionService service = new TransactionService(accounts);

        try
        {
            service.Withdraw("ACC1001", 5000);

            Console.WriteLine("Transaction Successful");
            Console.WriteLine("Remaining Balance: " +
                              accounts["ACC1001"].Balance);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("InsufficientFundsException:");
            Console.WriteLine(ex.Message);
        }
        catch (DailyLimitExceededException ex)
        {
            Console.WriteLine("DailyLimitExceededException:");
            Console.WriteLine(ex.Message);
        }
        catch (InvalidAccountException ex)
        {
            Console.WriteLine("InvalidAccountException:");
            Console.WriteLine(ex.Message);
        }
        catch (AccountFrozenException ex)
        {
            Console.WriteLine("AccountFrozenException:");
            Console.WriteLine(ex.Message);
        }
        catch (NetworkException ex)
        {
            Console.WriteLine("NetworkException:");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}
