using Assignment4ThanosKatrakis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Sorting_Algorithms
{
    class BubbleShort
    {
        public static void SizeColorFabricAsc(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Color > shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Size > shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void SizeColorFabricDesc(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Color < shirts[i + 1].Color)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                    if (shirts[i].Size < shirts[i + 1].Size)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void FabricAsc(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric > shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }

        public static void FabricDesc(Shirt[] shirts)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Length - 2; j++)
            {
                for (int i = 0; i <= shirts.Length - 2; i++)
                {
                    if (shirts[i].Fabric < shirts[i + 1].Fabric)
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }
    }
}

