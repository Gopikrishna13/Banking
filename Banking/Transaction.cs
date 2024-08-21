using System;

namespace Banking{
    public class Transaction
    {
        public int TransactionID{get;set;}
        public string source_accountNumber{get;set;}
        public string dest_accountNumber{get;set;}

        public double amount{get;set;}

        public string TransactionType{get;set;}
        public DateTime date{get;set;}

    }
}