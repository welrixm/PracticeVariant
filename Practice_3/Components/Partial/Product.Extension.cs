using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3.Components
{
    partial class Product
    {
        public string Color
        {
            get
            {
                if (Price <= 200)
                    return "#FDFDFD";
                else if(Price >= 200)
                    return "#E7E3DF";
                else return "#000000";

            }
        }
        
        public int? Quantity1
        {
            get
            {
                return this.ProductOrder.Sum(x => x.Quantity);
            }
        }
        public decimal? TotalPrice
        {
            get
            {
                return this.ProductOrder.Sum(x => x.Quantity * x.Product.Price);
            }
        }
    }
}
