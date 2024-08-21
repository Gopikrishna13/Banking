using System;
namespace Banking{
    public class Bank{

        public List<Customer>customers=new List<Customer>();
        public List<Account>accounts=new List<Account>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void GetCustomerDetails()
        {
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.CustomerName+" "+customer.CustomerID);
            }
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

 public Account FindAccount(string acc_number)
        {
            foreach (var account in accounts)
            {
                if (acc_number == account.accountNumber)
                {
                    return account; // Return the found account
                }
            }
            return null; // Return null if no account is found
        }
        public void TransferFunds(Transaction transaction)
        {
                
        }

    }
}