using System;
using System.Collections.Generic;
using System.Linq;
using static linq.ListGenerator;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linqSummaryComment
            // LINQ to Objects: query operators as extension methods on IEnumerable<T> (Enumerable class). 
            // Originally ~40 operators in .NET 3.5; more exist now.
            // IQueryable<T>: matching operators for remote queries (e.g., Entity Framework).
            // LINQ to XML: query operators on XDocument and XElement.
            // LINQ to SQL: query operators as extension methods on DataContext (not DbContext).
            // LINQ to Entities: query operators on ObjectContext (modern EF uses DbContext).
            #endregion
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = Enumerable.Where(numbers, n => n % 2 == 0);
            foreach (var n in evenNumbers)
            {
                Console.WriteLine($"even number : {n}");
            }
            // We can use query expression
            var oddNumbers = from n in numbers
                             where n % 2 != 0
                             select n;
            foreach (var n in oddNumbers)
            {
                Console.WriteLine($"odd number : {n}");
            }
            //Use list generator class to get product list
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("---------------Uisng Native Expression---------------");
            var result = Enumerable.Where(ProductList, p => p.UnitsInStock > 0).Select(p => new { p.ProductName, p.ProductCategory });
            Console.WriteLine("Products with stock > 0:");
            foreach (var product in result)
            {
                Console.WriteLine($"Product Name: {product.ProductName}, Product Category: {product.ProductCategory}");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("---------------Uisng Query Expression---------------");
            var result2 = from p in ProductList
                          where p.UnitPrice < 400 && p.UnitPrice > 200 && p.UnitsInStock > 0
                          orderby p.UnitsInStock
                          select new { p.ProductName, p.ProductCategory };
            Console.WriteLine("Products with price < 400 and > 200 and stock > 0:");
            foreach (var product in result2)
            {
                Console.WriteLine($"Product Name: {product.ProductName}, Product Category: {product.ProductCategory}");
            }
            //Uisng OrderBy then
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("---------------Uisng OrderBy And Then---------------");
            var result3 = Enumerable.Where(ProductList, p => p.UnitPrice >= 200).Select(p => new { id = p.ProductName, name = p.ProductName, price = p.UnitPrice }).OrderBy(p => p.price).ThenBy(p => p.id);
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("---------------Indexed Where---------------");
            Console.WriteLine("---------------Know The index of the element u search for---------------");
            Console.WriteLine("---------------Cannot be used in Query Expression---------------");
            ProductList.Sort();
            var result4 = Enumerable.Where(ProductList, (p, i) => p.UnitPrice > 400 && i > 5)
            .OrderByDescending(p => p.UnitPrice)
            .Select((p, i) => new { id = p.ProductId, name = p.ProductName, price = p.UnitPrice, Index = i });
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            #region natural order operators
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("---------------Order Operators---------------");
            //Take:e.g 5 => return top 5 elements
            Console.WriteLine("---------------Order Operators Take---------------");
            var result5 = ProductList.Where(p => p.UnitsInStock != 0).Select(p => p).Take(5);
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            //Skip:Will skip the first 5 rows and return the rest
            Console.WriteLine("---------------Order Operators Skip---------------");
            result5 = ProductList.Where(p => p.UnitsInStock != 0).Select(p => p).Skip(5);
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------Order Operators Skip& Take---------------");
            // Will Skip first 5 take second 5
            result5 = ProductList.Where(p => p.UnitsInStock != 0).Select(p => p).Skip(5).Take(5);
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            //TakeWhile:
            Console.WriteLine("---------------Order Operators TakeWhile---------------");
            List<int> arr = [10, 20, 30, 40, 5, 80, 70];
            var arrResult = arr.TakeWhile(a => a < 30);
            foreach (var item in arrResult)
            {
                Console.WriteLine(item);
            }
            //SkipWhile:will continue skip the elemnt until its condtion is false
            //after meeting false condition it will return all values even the once doenot meat the condtion
            Console.WriteLine("---------------Order Operators SkipWhile---------------");
            arrResult = arr.SkipWhile(a => a < 30);
            foreach (var item in arrResult)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region first, last and single operators
            /*
            *First: Returns the first element of a sequence. Throws an exception if the sequence is empty.
            *FirstOrDefault: Returns the first element of a sequence, or a default value if the sequence is empty.
            *Last: Returns the last element of a sequence. Throws an exception if the sequence is empty.
            *LastOrDefault: Returns the last element of a sequence, or a default value if the sequence is empty.
            *Single: Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
            *SingleOrDefault: Returns the only element of a sequence, or a default value if the sequence is empty
            */
            List<int> arr2 = new List<int> { 10, 20, 30, 40, 50, 60, 70 };
            Console.WriteLine("---------------First---------------");
            var first = arr2.First();
            Console.WriteLine(first);
            Console.WriteLine("---------------FirstOrDefault---------------");
            var firstOrDefault = arr2.FirstOrDefault();
            Console.WriteLine(firstOrDefault);
            //FirstOrDefault with condition
            Console.WriteLine("---------------FirstOrDefault with condition---------------");
            firstOrDefault = arr2.FirstOrDefault(a => a > 100);
            Console.WriteLine(firstOrDefault);
            Console.WriteLine("---------------Last---------------");
            var last = arr2.Last();
            Console.WriteLine(last);
            Console.WriteLine("---------------LastOrDefault---------------");
            var lastOrDefault = arr2.LastOrDefault();
            Console.WriteLine(lastOrDefault);
            //LastOrDefault with condition
            Console.WriteLine("---------------LastOrDefault with condition---------------");
            lastOrDefault = arr2.LastOrDefault(a => a > 100);
            Console.WriteLine(lastOrDefault);
            Console.WriteLine("---------------Single---------------");
            var single = arr2.Single(a => a == 30);
            Console.WriteLine(single);
            Console.WriteLine("---------------SingleOrDefault---------------");
            //this will throw Exception as there is more than one element meet the condition
            //var singleOrDefault = arr2.SingleOrDefault(a => a >= 30);
            //Will return null as there is no matching condition
            var singleOrDefault = arr2.SingleOrDefault(a => a >= 3340);
            Console.WriteLine(singleOrDefault);

            var productList = ProductList.FirstOrDefault(p=>p.UnitsInStock >= 500);
            Console.WriteLine(productList);
            #endregion

            #region Generation Operator
            Console.WriteLine("---------------Generator operators---------------");
            Console.WriteLine("---------------Range Operator---------------");
            Console.WriteLine("---------------Can be called Only By Enumrable---------------");
            var sequence = Enumerable.Range(0,100);
            foreach (var item in sequence.Take(5))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------Reapeat Can be called Only By Enumrable---------------");
            var repeatedValue = Enumerable.Repeat(50000,10);
            foreach (var item in repeatedValue.Skip(5))
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            //SelectMany
            List<string> names = ["Magdy Mohamed", "Menna Rabiee", "Mohamed Elshrief", "Aya Sedawy"];
            var operationedNames = names.SelectMany(n=> n.Split(" "));
            foreach(var item in operationedNames)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            //Set 
            HashSet<int> nums = [1,2,2,2,3,4,5,55,3,2,2,2,55];
            HashSet<int> nums2 = new HashSet<int>(Enumerable.Range(0,56));
            foreach(var item in nums)
            {
               Console.Write(item + ",");
            }
             foreach(var item in nums2)
            {
                Console.Write(item + ",");
            }
            var interSectNumbers = Enumerable.Intersect(nums2, nums);
            Console.WriteLine("---------------Intersect---------------");
            foreach(var item in interSectNumbers)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            Console.WriteLine("---------------to get union---------------");
            //There is no duplicate in the union result
            var unionNumbers = Enumerable.Union(nums2, nums);
            foreach(var item in unionNumbers)
            {
               Console.Write(item + ",");
            }
            Console.WriteLine();
            //With duplicate
            Console.WriteLine("---------------to get concat---------------");
            var concatNumbers = Enumerable.Concat(nums2, nums);
            foreach(var item in concatNumbers)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            #endregion
        }
    }
}