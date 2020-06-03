using Assignment4ThanosKatrakis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4ThanosKatrakis.Strategies.ProductVariationStrategy
{
    interface VariationStrategy
    {
        void Cost(Shirt shirt);
    }
}
