using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_6_4.Types
{
    class SalaryType : ICalculateType
    {
        public void Execute(Account account)
        {
            // расчет процентной ставки зарплатного клиента по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
