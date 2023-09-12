using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private string accountNo;
    private string customerName;
    private string accountType;
    private char transactionType;
    private double amount;
    private double balance;

    public Program(string accountNo, string customerName, string accountType, char transactionType, double amount)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.transactionType = transactionType;
        this.amount = amount;
        this.balance = 0;
    }

    public void Credit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Amount {amount} credited to Account {accountNo}. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount for credit.");
        }
    }

    public void Debit(double amount)
    {
        if (amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Amount {amount} debited from Account {accountNo}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance for debit.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount for debit.");
        }
    }

    public void ShowData()
    {
        Console.WriteLine($"Account Number: {accountNo}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Transaction Type: {transactionType}");
        Console.WriteLine($"Current Balance: {balance}");
    }

    public static void Main(string[] args)
    {
        Program account = new Program("1033402", "Nayana", "current", 'D', 20000);
        account.Credit(500);
        account.Debit(300);
        account.ShowData();
    }
}

