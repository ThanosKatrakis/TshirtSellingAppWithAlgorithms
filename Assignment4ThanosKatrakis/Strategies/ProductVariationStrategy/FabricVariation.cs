using Assignment4ThanosKatrakis.Entities;
using Assignment4ThanosKatrakis.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Strategies.ProductVariationStrategy
{
    class FabricVariation : VariationStrategy
    {
        public void Cost(Shirt shirt)
        {
            switch (shirt.Fabric)
            {
                case Fabric.CASHMERE: shirt.Price += 0.5m; break;
                case Fabric.COTTON: shirt.Price += 0.6m; break;
                case Fabric.LINEN: shirt.Price += 0.9m; break;
                case Fabric.POLYESTER: shirt.Price += 0.8m; break;
                case Fabric.RAYON: shirt.Price += 0.7m; break;
                case Fabric.SILK: shirt.Price += 1.1m; break;
                case Fabric.WOOL: shirt.Price += 1.5m; break;
                default: break;
            }
        }
    }
}
