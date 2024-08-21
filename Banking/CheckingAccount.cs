using System;
namespace Banking{
    public class CheckingAccount:Account
    {
             public CheckingAccount(string acc,double balance,int id)
             :base(acc,balance,id)
             {

             }

            //   CheckingAccount checkingAccount = new CheckingAccount("CHK001", 1000, 1);
           
            // By using base, you ensure that all properties inherited from the Account class are correctly 
            
            // initialized when you create an instance of CheckingAccount
    }
}