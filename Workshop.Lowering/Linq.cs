using System.Collections.Generic;
using System.Linq;

namespace Workshop.Lowering;

public class Customer
{
    public string Code { get; set; }

    public string Name { get; set; }
}

public class Linq
{

    public void Test()
    {
        var customers = new List<Customer>();

        var result = from c in customers
            where c.Code == "AU"
            select c.Name;

        result = customers.Where(x => x.Code == "AU")
            .Select(x => x.Name);

        result = Enumerable.Select(Enumerable.Where(customers, x => x.Code == "AU"),
            x => x.Name);
    }
}