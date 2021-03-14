using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankQuestion5
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int AccuontNum { get; set; }
        public int PhoneNum { get; set; }
        public int Balance { get; set; }

        public Customer(string name, string address, int accountNum, int phoneNum, int balance)
        {
            Name = name;
            Address = address;
            AccuontNum = accountNum;
            PhoneNum = phoneNum;
            Balance = balance;
        }
    }
}
