using System;
using System.Collections.Generic;
using System.Text;

namespace Point_Of_Sale
{
    public class Customer
    {
        #region Fields
        private const double taxRate = .06;
        private double subTotal = 0;
        private double total = 0;
        private double tender =0;
        private double change =0;

        private Dictionary <Product, int> cart;
        #endregion Fields

        #region Properties
        public static double TaxRate => taxRate;

        public double SubTotal { get => subTotal; set => subTotal = value; }
        public double Total { get => total; set => total = value; }
        public double Tender { get => tender; set => tender = value; }
        public double Change { get => change; set => change = (tender - total); }
        public Dictionary<Product, int> Cart { get => cart; set => cart = value; }
        #endregion Properties

        #region Constructors

        public Customer()
        {
            cart = new Dictionary<Product, int>();
        }
        #endregion Constructors


        #region Methods

        public void AddToCart(Product p, int quantity)
        {
            cart.Add(p, quantity);
        }

        public double GetSubTotal(Customer cart)
        {
            foreach (KeyValuePair <Product, int> kvp in Cart)
            {
                subTotal += kvp.Key.Price * kvp.Value;
            }
            return subTotal;
        }

        public double GetTotal(Customer cart)
        {
            total = SubTotal  * (1 + taxRate);
            return total;
        }

        public double GetChange(double tenderInput)
        {
            tender = tenderInput;
            change = tender - total;
            return change;
        }

        public override string ToString()
        {
            return $"Product: {Cart.Keys}\nSubTotal: {SubTotal} Total: {Total} ";
        }
        #endregion Methods
        



    }
}
