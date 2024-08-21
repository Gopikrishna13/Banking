using System;
namespace Banking{
    public class Banking{

        public List<Customer>customers=new List<Customer>();
        public List<Account>accounts=new List<Account>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }


        public void TransferFunds(Transaction transaction)
        {
                
        }

    }
}