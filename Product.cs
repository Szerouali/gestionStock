using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike
{
    class Product
    {
        private int id;
        private String label;
        public String category;
        private String size;
        private int quantity;
        private String reference;
        private double price;
        private String color;

        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public string Category { get => category; set => category = value; }
        public string Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Reference { get => reference; set => reference = value; }
        public double Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }

        public Product(int id, string label, string category, string size, int quantity, string reference, double price, string color)
        {
            this.id = id;
            this.label = label;
            this.category = category;
            this.size = size;
            this.quantity = quantity;
            this.reference = reference;
            this.price = price;
            this.color = color;
        }
        public override string ToString()
        {
            return label + " | " + category + " | " + size + " | " + quantity + " | " + reference + " | " + price + " | " + color;
        }
    }
}

