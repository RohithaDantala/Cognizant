using System;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Phone","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Bag","Fashion")
        };

        Product? linearResult = SearchService.LinearSearch(products, 104);

        if (linearResult != null)
        {
            Console.WriteLine("Linear Search Found: " + linearResult.ProductName);
        }

        Product? binaryResult = SearchService.BinarySearch(products, 104);

        if (binaryResult != null)
        {
            Console.WriteLine("Binary Search Found: " + binaryResult.ProductName);
        }
    }
}