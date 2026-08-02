using System;

public class Solution
{
    public static int FinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                balance += transaction;
            }
            else
            {
                if (balance >= -transaction)
                {
                    balance += transaction;
                }
            }
        }

        return balance;
    }

      
}