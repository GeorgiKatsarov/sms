using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_2._0
{
    internal class Sale
    {
        private int idOfProduct;
        private Product product;
        private int quantity;
        private DateTime time;

        public int IdOfProduct
        {
            get { return idOfProduct; }
            set { idOfProduct = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        public Sale ()
        {
            Database database = new Database ();
            this.Product = database.Product(this.IdOfProduct);
        }

    }
}
