using System;
using System.Linq;

namespace ECommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Chair", "Furniture"),
                new Product(3, "Keyboard", "Electronics"),
                new Product(4, "Notebook", "Stationery"),
                new Product(5, "Mouse", "Electronics")
            };

            Console.WriteLine("--- Linear Search ---");
            int index1 = SearchAlgorithms.LinearSearch(products, "Mouse");
            Console.WriteLine(index1 != -1 ? $"Found at index {index1}" : "Not found");

            Console.WriteLine("--- Binary Search ---");
            // Sort before binary search
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            int index2 = SearchAlgorithms.BinarySearch(sortedProducts, "Mouse");
            Console.WriteLine(index2 != -1 ? $"Found at index {index2}" : "Not found");

            Console.WriteLine("\nLinear Search: O(n), Binary Search: O(log n)");
            Console.WriteLine("Binary Search is more suitable for sorted data and large product lists.");
        }
    }
}
