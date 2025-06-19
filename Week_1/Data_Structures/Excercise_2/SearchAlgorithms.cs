using System;

namespace ECommerceSearch
{
    public class SearchAlgorithms
    {
        public static int LinearSearch(Product[] products, string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName == name)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(Product[] products, string name)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(products[mid].ProductName, name);
                if (comparison == 0)
                    return mid;
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
