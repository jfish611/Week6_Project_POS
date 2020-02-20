using System;
using System.Collections.Generic;
using System.Text;

namespace Point_Of_Sale
{
    public class Product
    {
        private static int count = 1;
        private int id;
        private string name;
        private string category;
        private string description;
        private double price;

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Id { get => id; }
        public static int Count { get => count; set => count = value; }

        public Product(string name, string category, string description, double price)
        {
            this.id = count;
            this.name = name;
            this.category = category;
            this.description = description;
            this.price = price;
            count++;
        }
        

        public override string ToString()
        {
            return $"{Id} Name: {Name}\tCategory: {Category}\nDescription: {Description}\nPrice: {Price}";
        }
    }
}
