using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal abstract class Account
    {

        private string accountName { get; set; }
        private string accountHolderName { get; set; }
        private double balance { get; set; }
        public string AccountName { get { return accountName; } set { accountName = value; } }
        public string AccountHolderName { get { return accountHolderName; } set { accountHolderName = value; } }
        public double Balance { get { return balance;} set { balance = value; } }

        public Account(string AccountName, string AccountHolderName, double Balance) {
            this.accountName = AccountName;
            this.accountHolderName = AccountHolderName;
            this.balance = Balance;
        }

        public void Depoist(double amount)
        {
            Balance += amount;
            Console.WriteLine($"You  depoist {Balance} succesfully!!!");
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Console.WriteLine($"You  withdraw {Balance} succesfully!!!");
        }


        public abstract void DepoistPerAccount(double moneyDepoist);
        public abstract void WithdrawPerAccount(double moneyWidthdraw);

        public void displayInfo()
        {
            Console.WriteLine($"AccountName:{AccountName} - AccountHolderName:{AccountHolderName} - Balance:{Balance}");
        }

        public void displayHistory(double balanceFluctuations)
        {
            balanceFluctuations = balanceFluctuations < 0 ? -balanceFluctuations : balanceFluctuations;
            Console.WriteLine($"AccountName:{AccountName} - AccountHolderName:{AccountHolderName} - Balance:{Balance} - balance fluctuations :{balanceFluctuations}");
        }

    }
}
