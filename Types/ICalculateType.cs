using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17_6_4.Types
{
    /// <summary>
    /// Общий интерфейс для разных типов аккаунтов
    /// </summary>
    public interface ICalculateType
    {
        void Execute(Account account);
    }
}
