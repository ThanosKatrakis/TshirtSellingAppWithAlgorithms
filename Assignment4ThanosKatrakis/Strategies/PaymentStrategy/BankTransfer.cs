using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Strategies.PaymentStrategy
{
    class BankTransfer : IPaymentMethodStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using bank tranfer");
        }
    }
}
