using System;


namespace Banking{
    public class Customer{
        public int CustomerID{get;set;}
        public string CustomerName{get;set;}

        public string Email{get;set;}

        public List<Account>accounts=new List<Account>();

public Customer(string name,int id,string mail)
{
   CustomerName=name;
   CustomerID=id;
   Email=mail;
}
        public void AddAccount(Account account)
        {
               accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
           accounts.Remove(account);
        }

        public void GetAccount()
        {
            Console.WriteLine($"Name :{CustomerName}");
            Console.WriteLine("Accounts :");
             foreach(var acc in accounts)
             {
                Console.WriteLine(acc.accountNumber);
             }
        }
    }
}