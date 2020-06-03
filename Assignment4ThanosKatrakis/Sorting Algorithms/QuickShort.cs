using Assignment4ThanosKatrakis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Sorting_Algorithms
{
    class QuickShort
    {
        static int Partition(Shirt[] arr, int low, int high, Func<Shirt, Shirt, bool> comparedShirts)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (comparedShirts(pivot, arr[j]))
                {
                    i++;

                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void SortingFacade(Shirt[] arr, Func<Shirt, Shirt, bool> comparedShirts)
        {
            SortAll(arr, 0, arr.Length - 1, comparedShirts);
        }

        public static void SortAll(Shirt[] arr, int low, int high, Func<Shirt, Shirt, bool> comparedShirts)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, comparedShirts);

                SortAll(arr, low, pi - 1, comparedShirts);
                SortAll(arr, pi + 1, high, comparedShirts);
            }
        }

        public static void ColorAsc(Shirt[] shirts)
        {
            SortingFacade(shirts, (shirt1, shirt2) => shirt1.Color > shirt2.Color);
        }

        public static void ColorDesc(Shirt[] shirts)
        {
            SortingFacade(shirts, (shirt1, shirt2) => shirt1.Color < shirt2.Color);
        }
    }
}
