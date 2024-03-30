using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapImprove
{
     interface AccountLimitInit
    {
        double WithdrawalLimit { get;  }
        double DepositLimit { get; }
    }
}
