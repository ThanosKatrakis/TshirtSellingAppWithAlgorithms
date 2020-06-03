using Assignment4ThanosKatrakis.Database;
using Assignment4ThanosKatrakis.Entities;
using Assignment4ThanosKatrakis.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            var shirts = db.Shirts.ToArray();

            #region BubbleShort
            Console.WriteLine("Ascending order by size, color and fabric");
            BubbleShort.SizeColorFabricAsc(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Descending order by size, color and fabric");
            BubbleShort.SizeColorFabricDesc(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Ascending order by fabric");
            BubbleShort.FabricAsc(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Descending order by fabric");
            BubbleShort.FabricDesc(shirts);
            PrintAllItems(shirts);
            #endregion


            #region QuickShort
            Console.WriteLine("Ascending order by color");
            QuickShort.ColorAsc(shirts);
            PrintAllItems(shirts);

            Console.WriteLine("Descending order by color");
            QuickShort.ColorDesc(shirts);
            PrintAllItems(shirts);
            #endregion


            #region BucketShort
            Console.WriteLine("Ascending order by size");
            var listSizeAsc = BucketShort.SizeAsc(shirts);
            PrintAllItems(listSizeAsc.ToArray());

            Console.WriteLine("Descending order by size");
            var listSizeDesc = BucketShort.SizeDesc(shirts);
            PrintAllItems(listSizeDesc.ToArray());
            #endregion


            ClientApp.BuyShirt();

            Console.ReadKey();
        }

        public static void PrintAllItems(Shirt[] shirts)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Color", "Size", "Fabric");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in shirts)
            {
                item.Output();
            }
            Console.WriteLine();
        }
    }
}
