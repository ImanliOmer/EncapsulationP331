using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationP331
{
    internal class Invoice
    {
        private int account;
        private string customer;
        private string provider;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private string article;

        public string Article
        {
            get 
            {
                return article;
            }
            set 
            {
                article = value;
            }
        }

        private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set 
            {
                quantity = value;
            }
        }

        private decimal price;

        public decimal Price 
        {
            get 
            { 
                return price;
            }

            set
            {
                price = value;
            }
        }


        public decimal CostCalculation(bool needEdv)
        {
            if (needEdv)
            {
                return (Price * Quantity) * 0.18m;
            }
            else
            {

                return Price * Quantity;
            }
        }
    }

  

  
}
