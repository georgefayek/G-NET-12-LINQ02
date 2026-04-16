using G_NET_12_LINQ02.Models;
using System.Diagnostics.Metrics;
namespace G_NET_12_LINQ02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ ProductID=1, ProductName="Chai", UnitPrice=18, UnitsInStock=39, Category="Beverages"},
                new Product{ ProductID=2, ProductName="Chang", UnitPrice=19, UnitsInStock=17, Category="Beverages"},
                new Product{ ProductID=3, ProductName="Aniseed Syrup", UnitPrice=10, UnitsInStock=13, Category="Condiments"},
                new Product{ ProductID=4, ProductName="Chef Anton", UnitPrice=22, UnitsInStock=53, Category="Seafood"},
                new Product{ ProductID=5, ProductName="Ikura", UnitPrice=31, UnitsInStock=0, Category="Seafood"},
                new Product{ ProductID=18, ProductName="Carnarvon Tigers", UnitPrice=62, UnitsInStock=42, Category="Seafood"}
            };


            #region 1. Get top 3 most expensive products
            //  var result1 = products
            //      .OrderByDescending(p => p.UnitPrice)
            //      .Take(3);

            //   foreach (var p in result1)
            //Console.WriteLine(p.ProductName);

            #endregion

            #region 2. show page 2 of products, with page size = 5

            //var result2 = products
            //.Skip(5)
            //.Take(5);
            #endregion

            #region 3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var result3 = products
            // .OrderBy(p => p.UnitPrice)
            // .TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region 4. Check if ALL products in the "Seafood" category are in stock

            //var result4 = products
            //.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result4);
            #endregion

            #region 5. Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 }
            //int[] ids = { 3, 9, 13, 18 };

            //bool result5 = ids.Contains(9);
            #endregion

            #region 6. Group all products by Category and print each group with its  product count.

            //var result6 = products
            //.GroupBy(p => p.Category);

            //foreach (var group in result6)
            //{
            //    Console.WriteLine(group.Key + " Count: " + group.Count());
            //}
            #endregion

            #region 7. Group products by Category and project only product names per group  
            // var result7 = products
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    Names = g.Select(p => p.ProductName)
            //});


            #endregion

            #region  8. Find all categories that have MORE THAN 3 products

            //var result8 = products
            //.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);

            #endregion

            #region 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var result9 = from c in customers
            //              group c by c.Country into g
            //              select new
            //              {
            //                  Country = g.Key,
            //                  Count = g.Count(),
            //                  TotalOrderValue = g.Sum(x => x.Orders.Sum(o => o.Total))
            //              };
            #endregion

            #region 10. Calculate the total number of units in stock across all products

            //var result10 = products.Sum(p => p.UnitsInStock);
            #endregion

            #region 11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var min = products.Min(p => p.UnitPrice);
            //var max = products.Max(p => p.UnitPrice);
            #endregion

            #region 12. Get a distinct list of all product categories

            //var result12 = products
            //.Select(p => p.Category)
            //.Distinct();
            #endregion

            #region 13. find product IDs that are in setA but NOT in setB  int[] setA = { 1, 3, 5, 7, 9, 11, 13 }; int[] setB = { 3, 6, 9, 12, 15, 13 }

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result13 = setA.Except(setB);

            #endregion

            #region 14. Find countries that appear in list1 but NOT in list2    (case -insensitive). string[] list1 = { "Germany", "France", "UK", "Spain" };  string[] list2 = { "france", "SPAIN", "Italy" };

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result14 = list1
            //    .Where(x => !list2.Contains(x, StringComparer.OrdinalIgnoreCase));

            #endregion

            #region 15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            //var dict = products.ToDictionary(p => p.ProductID);

            //var product = dict[18];

            //Console.WriteLine(product.ProductName);
            #endregion

            #region 16. Get the first product whose price is greater than $50.

            //var result16 = products.First(p => p.UnitPrice > 50);
            #endregion

            #region 17. Try to get the first product with a price > $500. it returns null  instead of throwing

            //var result17 = products.FirstOrDefault(p => p.UnitPrice > 500);

            //if (result17 == null)
            //    Console.WriteLine("Not Found");
            #endregion

            #region 18. Generate a multiplication table row for 7

            //var result17 = products.FirstOrDefault(p => p.UnitPrice > 500);

            //if (result17 == null)
            //    Console.WriteLine("Not Found");
            #endregion

            #region 19. Generate even numbers between 1 and 30.

            // var result19 = Enumerable.Range(1, 30)
            //.Where(x => x % 2 == 0);
            #endregion

            #region 20. Concatenate the first 3 product names with the first 3 customer company names into a single sequence.

            //var result20 = products.Take(3).Select(p => p.ProductName)
            //.Concat(customers.Take(3).Select(c => c.CompanyName));

            #endregion

        }
    }
}
