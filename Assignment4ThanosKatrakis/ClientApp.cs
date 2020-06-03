using Assignment4ThanosKatrakis.Entities;
using Assignment4ThanosKatrakis.Enumerations;
using Assignment4ThanosKatrakis.Strategies.ProductVariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis
{
    class ClientApp
    {
        public static void BuyShirt()
        {
            List<VariationStrategy> variations = new List<VariationStrategy>()
            {
                new ColorVariation(),
                new SizeVariation(),
                new FabricVariation()
            };

            Color color = ChooseColor();
            Fabric fabric = ChooseFabric();
            Size size = ChooseSize();

            Shirt shirt = new Shirt(color, size, fabric);
            EshopContext eshop = new EshopContext(variations);

            PaymentMethods paymentMethods = ChoosePaymentMethod();
            eshop.SelectPaymentMethod(paymentMethods);
            eshop.TotalCostTShirt(shirt);

        }

        private static PaymentMethods ChoosePaymentMethod()
        {
            Console.WriteLine("Choose payment");
            var paymentMethods = Enum.GetValues(typeof(PaymentMethods));
            int counter = 0;
            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine("{0} --{1}", ++counter, paymentMethod);
            }

            return (PaymentMethods)Convert.ToInt32(Console.ReadLine());
        }

        private static Color ChooseColor()
        {
            Console.WriteLine("Choose color");
            var colors = Enum.GetValues(typeof(Color));
            int counter = 0;
            foreach (var color in colors)
            {
                Console.WriteLine("{0} --{1}", ++counter, color);
            }

            return (Color)Convert.ToInt32(Console.ReadLine());
        }

        private static Fabric ChooseFabric()
        {
            Console.WriteLine("Choose fabric");
            var fabrics = Enum.GetValues(typeof(Fabric));
            int counter = 0;
            foreach (var fabric in fabrics)
            {
                Console.WriteLine("{0} --{1}", ++counter, fabric);
            }

            return (Fabric)Convert.ToInt32(Console.ReadLine());
        }

        private static Size ChooseSize()
        {
            Console.WriteLine("Choose size");
            var sizes = Enum.GetValues(typeof(Size));
            int counter = 0;
            foreach (var size in sizes)
            {
                Console.WriteLine("{0} --{1}", ++counter, size);
            }

            return (Size)Convert.ToInt32(Console.ReadLine());
        }
    }
}