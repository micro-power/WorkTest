using System.Collections.Generic;

namespace WorkTests.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}