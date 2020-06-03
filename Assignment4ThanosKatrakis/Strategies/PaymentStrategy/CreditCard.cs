using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Strategies.PaymentStrategy
{
    class CreditCard : IPaymentMethodStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using credit card");
        }
    }
}
