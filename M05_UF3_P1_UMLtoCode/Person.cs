using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P1_UMLtoCode
{
    public abstract class Person
    {
        public int id;
        public string name;
        protected string phone;
        public string email;

        public Address personAddress;
    }
    public struct Address
    {
        public string street;
        public string city;
        public string state;
        public string postalCode;
        public string country;
        public bool validate()
        {
            return true;
        }
        public Person addressPerson;
    }
    public class Customer : Person
    {
        public DateTime registration;
        private int creditScore;

        public Account customerAccount;
    }
    public class Employee : Person
    {
        public enum department { };
        private float salary;
    }
    public class Account
    {
        public string iban;
        protected float amount;
        public bool transaction(string texto)
        {
            return true;
        }
        public Customer accountCustomer;
        public Transaction accountTransaction;

    }
    public struct Transaction
    {
        public string from;
        public string to;
        public float amount;
        public DateTime request;

        public Account transactionAccount;
    }
    public class Investing : Account
    {
        public float interest;
        public float applyInterest(float amount)
        {
            return amount;
        }
    }
    public class Savings : Account
    {
        private float protectedAmount;
        public float liberateSavings(float amount)
        {
            return amount;
        }
    }

}
