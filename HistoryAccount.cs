using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class HistoryAccount : Account
    {

        public double balanceFluctuations { get; set; }
        public HistoryAccount(string AccountName, string AccountHolderName, double Balance,double balanceFluctuations) : base(AccountName, AccountHolderName, Balance)
        {
            this.Balance = Balance;
            this.AccountName = AccountName;
            this.AccountHolderName = AccountHolderName;
            this.balanceFluctuations = balanceFluctuations;
        }

        public override void DepoistPerAccount(double moneyDepoist){ }
        public override void WithdrawPerAccount(double moneyWidthdraw){}

        public void displayHistory()
        {
            Console.WriteLine($"AccountName:{AccountName} - AccountHolderName:{AccountHolderName} - Balance:{Balance} - balance fluctuations :{balanceFluctuations}");
        }

    }
}
