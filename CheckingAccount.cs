using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
    internal class CheckingAccount : Account, AccountLimitInit
    {

        public double WithdrawalLimit { get; }
        public double DepositLimit { get; }
        private List<HistoryAccount> historyAccounts = new List<HistoryAccount>();
        public CheckingAccount(string AccountName, string AccountHolderName, double Balance) : base(AccountName, AccountHolderName, Balance)
        {
            this.Balance = Balance;
            this.AccountName = AccountName;
            this.AccountHolderName = AccountHolderName;
            //30 000 000
            WithdrawalLimit = 30000000;
            DepositLimit = 50000;
        }

        public override void DepoistPerAccount(double moneyDepoist)
        {
            if (DepositLimit > moneyDepoist)
            {
                Console.WriteLine("moneyDepoist must more " + moneyDepoist);
                return;
            }
            base.Depoist(moneyDepoist);
            addListHistory(moneyDepoist);
        }


        public override void WithdrawPerAccount(double moneyWidthdraw)
        {
            if (Balance < moneyWidthdraw || moneyWidthdraw > WithdrawalLimit)
            {
                Console.WriteLine("moneyWidthdraw must lower " + moneyWidthdraw);
                return;
            }
            base.Withdraw(moneyWidthdraw);
            addListHistory(-moneyWidthdraw);
        }
        private void addListHistory(double moneyChange)
        {
            historyAccounts.Add(new HistoryAccount(AccountName, AccountHolderName, Balance, moneyChange));
        }

        public void displayListHistory()
        {
            Console.WriteLine("List hisotry Account Checking Account");
            foreach (HistoryAccount account in historyAccounts)
            {
                account.displayHistory();
            }
        }
    }
}
