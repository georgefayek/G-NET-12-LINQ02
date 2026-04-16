using G_NET_12_LINQ02.Models;
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


        }
    }
}
