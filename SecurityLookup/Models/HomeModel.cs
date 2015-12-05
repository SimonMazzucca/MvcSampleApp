using System;
using System.Collections.Generic;
using System.Linq;
using MvcApp.DataAccess;

namespace MvcApp.Models
{

    public class HomeModel
    {

        public List<Security> Securities { get; set; }

        public HomeModel()
        {
            Securities = new List<Security>();
        }

        public void LoadSecurities(string symbol, string searchText)
        {
            DummyContext context = new DummyContext();

            symbol = symbol.ToLower();
            searchText = searchText.ToLower();

            Securities = context.Securities.Where(s =>
                (!String.IsNullOrEmpty(symbol) && s.SecurityCode.ToLower() == symbol) ||
                (!String.IsNullOrEmpty(searchText) &&
                    (
                        (!String.IsNullOrEmpty(s.SecurityName) && s.SecurityName.ToLower().IndexOf(searchText) > -1) ||
                        (!String.IsNullOrEmpty(s.Cusip) && s.Cusip.ToLower().IndexOf(searchText) > -1) ||
                        (!String.IsNullOrEmpty(s.Sedol) && s.Sedol.ToLower().IndexOf(searchText) > -1) ||
                        (!String.IsNullOrEmpty(s.Isin) && s.Isin.ToLower().IndexOf(searchText) > -1)
                    )
                )
            ).ToList();

        }

    }
}