using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class SavingsAccount : Account,AccountLimitInit
    {
        
        private  double withdrawalLimit;

        public  double WithdrawalLimit
        {
            get { return withdrawalLimit; } set { withdrawalLimit = Balance; }
        }

        private double depositLimit;
        public double DepositLimit
        {
            get { return depositLimit; }
            set { depositLimit = value; }
        }

        public SavingsAccount(string AccountName,string AccountHolderName,double Balance) : base(AccountName, AccountHolderName, Balance)
        {
            this.Balance = Balance;
            this.AccountName = AccountName;
            this.AccountHolderName = AccountHolderName;
        }

        public override void DepoistPerAccount()
        {
          
        }

        public override void WithdrawPerAccount()
        {
            Console.WriteLine("Hi");
        }

    }
}
