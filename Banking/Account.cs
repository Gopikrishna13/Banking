using System;

namespace Banking{
    public class Account{
        public string accountNumber{get;set;}
        public double balance{get;set;}

        public int CustomerID{get;set;}


        public void Deposit(double amount)
        {
           if(amount>0)
           {
            balance=balance+amount;
           }else{
            Console.WriteLine("Deposit amount more than 0");
           }
        }

        public void Withdraw(double amount)
        {
             if(balance<amount)
             {
                balance=balance-amount;
             }else{
                Console.WriteLine("Amount Not Sufficient");
             }
        }

  public void Withdraw(decimal percentage)
  {
    double amount=balance*((double)percentage);

    balance=balance-amount;
  }
        public void GetBalance()
        {
           Console.WriteLine(balance);
        }

      public Account(string acc,double balance,int id)
      {
           accountNumber=acc;
           this.balance=balance;
           CustomerID=id;
      }
    }
}