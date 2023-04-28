using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17_6_4.Types;

namespace Module_17_6_4
{
    class Calculator
    {
        /// <summary>
        /// Рассчитывает процентную ставку
        /// </summary>
        public void CalculateInterest(ICalculateType calculateType, Account account)
        {
            Console.WriteLine($">> Расчет ставки для клиента типа {account.Type}");

            calculateType.Execute(account);

            Console.WriteLine($"Процентная ставка для клиента {account.Type}: {account.Interest}");
        }
    }
}
