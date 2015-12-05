using System.Collections.Generic;

namespace MvcApp.DataAccess
{

    public class DummyContext
    {
        public List<Security> Securities { get; set; }

        public DummyContext()
        {
            Securities = new List<Security>();

            Securities.Add(new Security()
            {
                SecurityId = 1,
                SecurityCode = "YHOO",
                SecurityName = "Yahoo",
                Sedol = "1111234",
                Cusip = "459200-10-1",
                Isin = "123123456123"
            });

            Securities.Add(new Security()
            {
                SecurityId = 2,
                SecurityCode = "MSFT",
                SecurityName = "Microsoft",
                Sedol = "2224567",
                Cusip = "459198-10-1"
            });

            Securities.Add(new Security()
            {
                SecurityId = 1,
                SecurityCode = "AAPL",
                SecurityName = "Apple",
                Sedol = "3337890",
                Cusip = "459184-10-1",
                Isin = "123123456125"
            });

            Securities.Add(new Security()
            {
                SecurityId = 1,
                SecurityCode = "GOOGL",
                SecurityName = "Google",
                Sedol = "4446756",
                Cusip = "459555-10-1"
            });

        }
    }
}