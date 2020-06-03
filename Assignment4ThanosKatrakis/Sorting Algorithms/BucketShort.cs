using Assignment4ThanosKatrakis.Entities;
using Assignment4ThanosKatrakis.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Sorting_Algorithms
{
    public class BucketShort
    {
        public static List<Shirt> SizeAsc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++) 
            {
                int bucket = (int)x[i].Size;
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;
        }

        public static List<Shirt> SizeDesc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = (int)x[i].Size;
                buckets[(numOfBuckets - 1) - bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;
        }
    }
}
