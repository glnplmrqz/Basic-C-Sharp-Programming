using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp {

    class Product {

        private int productID;
        private string productName;
        private string productDescription;
        private int productStock;
        private double productPrice;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {

            get { return productDescription; }
            set { productDescription = value; }
        }

        public int ProductStock
        {

            get { return productStock; }
            set { productStock = value; }
        }

        public double ProductPrice
        {

            get { return productPrice; }
            set { productPrice = value; }
        }

        // Complete Constructor
        public Product(int productID, string productName, string productDescription, int productStock, double productPrice) {

            ProductID = productID;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductStock = productStock;
            ProductPrice = productPrice;
        }

        // Constructor without Product Description
        public Product(int productID, string productName, int productStock, double productPrice) {
            ProductID = productID;
            ProductName = productName;
            ProductStock = productStock;
            ProductPrice = productPrice;
        }

        public void displayProduct() {
            Console.WriteLine($"Product ID: {productID}");
            Console.WriteLine($"Product Name: {productName}");
            
            if(productDescription == null) { }
            else Console.WriteLine($"Product Description: {productDescription}");

            Console.WriteLine($"Product Stock: {productStock}");
            Console.WriteLine($"Product Price: {productPrice}");
        }

    }
}
