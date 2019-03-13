﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    
        //Name : Gurkirat Singh - C0731779
        //Name : Robindeep Singh- C0723381 
        public class BankAccount
        {
            private string m_customerName;

            private double m_balance;

            private bool m_frozen = false;

            private BankAccount()
            {

            }
            public BankAccount(string customerName, double balance)
            {
                m_customerName = customerName;
                m_balance = balance;
            }
            public string CustomerName
            {
                get { return m_customerName; }
            }
            public double Balance
            {
                get { return m_balance; }
            }
            public void Debit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception("Account frozen");
                }

                if (amount > m_balance)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                m_balance -= amount;
            }
            public void Credit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception("Account frozen");
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                m_balance += amount;
            }
            private void FreezeAccount()
            {
                m_frozen = true;
            }
            private void unfreezeAccount()
            {
                m_frozen = false;
            }
            public static void Main(string[] args)
            {
                BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
                ba.Credit(5.77);
                ba.Credit(11.22);
                Console.WriteLine("Current balance is ${0}", ba.Balance);
            }
        }
    }


    

