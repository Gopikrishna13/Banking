using System;
using System.Threading.Tasks.Dataflow;

namespace Banking
{
    public class  Program
    {
        private static Bank bank = new Bank();
        
        
        public static void Main(string[]args)
        {
        //  Customer customer=new Customer(){CustomerID=1,CustomerName="ABC",Email="abc@gmail.com"};
        // customer.AddAccount(new Account("001",0,1));
        // customer.AddAccount(new Account("002",0,1));

        // Account account3=new Account("003",0,1);
        // customer.AddAccount(account3);
      
         // customer.RemoveAccount(account3);
        //  customer.GetAccount();

        //   Account account4=new Account("003",0,1);
        //   account4.Deposit(1000);
        //   account4.Deposit(2000);
        //   account4.Withdraw(500);
        //   account4.GetBalance();

int response=0;
      

        while(response!=7)
        {
        Console.WriteLine("1.Create a Customer");
        Console.WriteLine("2.Create an Account");
        Console.WriteLine("3.Deposit Funds");
        Console.WriteLine("4.Withdraw Funds");
        Console.WriteLine("5.Transfer Funds");
        Console.WriteLine("6.View Customer Details");
        Console.WriteLine("7.Exit");
          Console.Write("Enter Option:");
         response=int.Parse(Console.ReadLine());

         if(response==1)
         {
            Console.Write("Customer Name :");
            string name=Console.ReadLine();
            Console.Write("CustomerID:");
            int Id=int.Parse(Console.ReadLine());
            Console.Write("Email:");
            string mail=Console.ReadLine();

          
            bank.AddCustomer(new Customer(name,Id,mail));
           


         }else if(response==2)
         {
                 Console.Write("CustomerID:");
                 int Id=int.Parse(Console.ReadLine());

                 Console.Write("Account Number:");
                 string accountNumber=Console.ReadLine();

                 Console.Write("Select Account Type 1 for Savings 2 for Checkings:");
                 int acc_response=int.Parse(Console.ReadLine());

                 if(acc_response==1)
                 {
                    bank.AddAccount(new SavingsAccount(accountNumber,0,Id));
                 }else if(response==2)
                 {
                    bank.AddAccount(new CheckingAccount(accountNumber,0,Id));
                 }

         }else if(response==3)
         {
             Console.Write("Enter Account Number");
             string acc_number=Console.ReadLine();
             Account match_acc=bank.FindAccount(acc_number);
            
             if( match_acc!=null)
             {
                  Console.Write("Enter Amount to Deposit: ");
                  double amount=double.Parse(Console.ReadLine());

                  

             }else{
                Console.WriteLine("Could not find Bank Details");
             }

             
         }
         
         else if (response==6)
         {
           
            bank.GetCustomerDetails();
         }
        }
    
        }
      
    }
}
