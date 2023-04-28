using System;
using Module_17_6_4.Types;

namespace Module_17_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обычный аккаунт
            Account commonAccount = new Account("Обычный", 20000);
            // Зарплатный аккаунт
            Account salaryAccount = new Account("Зарплатный", 60000);

            Calculator calculator = new Calculator();
            
            // Расчет ставки для обычного аккаунта
            calculator.CalculateInterest(new CommonType(), commonAccount);

            Console.WriteLine();

            // Расчет ставки для зарплатного аккаунта
            calculator.CalculateInterest(new SalaryType(), salaryAccount);


        }
    }
}
