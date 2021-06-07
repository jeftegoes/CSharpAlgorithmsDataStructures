using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LinearSearch
{
    public class CustomersComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            return x.Age == y.Age && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Customer obj) => obj.GetHashCode();
    }
}