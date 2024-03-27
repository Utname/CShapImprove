using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class CheckingAccount : Account, AccountLimitInit
    {

        private double withdrawalLimit;

        public double WithdrawalLimit
        {
            get { return withdrawalLimit; }
            set { withdrawalLimit = 30000000; }
        }

        private double depositLimit;
        public double DepositLimit
        {
            get { return depositLimit; }
            set { depositLimit = 1000000; }
        }

        public CheckingAccount(string AccountName, string AccountHolderName, double Balance) : base(AccountName, AccountHolderName, Balance)
        {
            this.Balance = Balance;
            this.AccountName = AccountName;
            this.AccountHolderName = AccountHolderName;
        }

        public override void DepoistPerAccount(double moneyDepoist)
        {
            if (WithdrawalLimit > moneyDepoist)
            {
                Console.WriteLine("moneyDepoist must more " + withdrawalLimit);
                return;
            }
            base.Depoist(moneyDepoist);
        }


        public override void WithdrawPerAccount(double moneyWidthdraw)
        {
            if (Balance < moneyWidthdraw || moneyWidthdraw > WithdrawalLimit)
            {
                Console.WriteLine("moneyWidthdraw must lower " + withdrawalLimit);
                return;
            }
            base.Withdraw(moneyWidthdraw);
        }
    }
}
