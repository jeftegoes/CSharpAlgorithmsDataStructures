using System;
using System.Collections.Generic;
using System.Linq;

namespace LinearSearch
{
    class Program
    {
        private static bool Exists(int[] array, int number)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }

            return false;
        }

        private static int IndexOf(int[] array, int number)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            var customerList = new List<Customer>()
            {
                new Customer { Age = 3, Name = "Ann"},
                new Customer { Age = 16, Name = "Bill"},
                new Customer { Age = 20, Name = "Rose"},
                new Customer { Age = 14, Name = "Rob"},
                new Customer { Age = 28, Name = "Bike"},
                new Customer { Age = 14, Name = "John"},
            };

            var intList = new List<int>() { 1, 4, 2, 7, 9, 12, 3, 2, 1 };

            var contains = intList.Contains(3);

            // from linq
            var contains2 = customerList.Contains(new Customer { Age = 14, Name = "Rob" }, new CustomersComparer());

            bool exists = customerList.Exists(customer => customer.Age == 28);

            // from linq
            int min = intList.Min();
            int max = intList.Max();

            // from linq
            int youngestCustomerAge = customerList.Min(customer => customer.Age);

            var bill = customerList.Find(customer => customer.Name == "Bill");

            // from list
            var lasbBill = customerList.FindLast(customer => customer.Name == "Bill");

            // from linq
            var lastBill2 = customerList.Last(customer => customer.Name == "Bill");

            // from list
            var customers = customerList.FindAll(customer => customer.Age > 18);

            // from linq
            var whereAge = customerList.Where(customer => customer.Age > 18);

            int index1 = customerList.FindIndex(customer => customer.Age == 14);
            int lastIndex = customerList.FindLastIndex(customer => customer.Age > 18);

            var indexOf = intList.IndexOf(2);
            var lastIndexOf = intList.LastIndexOf(2);

            // from list
            var isTrueForAll = customerList.TrueForAll(customer => customer.Age > 10);

            // from linq
            var all = customerList.All(customer => customer.Age > 10);

            // from linq
            var areThereAny = customerList.Any(customer => customer.Age == 3);

            // from linq
            var count = customerList.Count(customer => customer.Age > 18);

            // from linq
            var firstBill = customerList.First(customer => customer.Name == "Bill");

            // from linq
            var singleAnn = customerList.Single(customer => customer.Name == "Ann");
        }
    }
}
