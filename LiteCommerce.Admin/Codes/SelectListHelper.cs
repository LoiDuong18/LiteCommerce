using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin
{
    public class SelectListHelper
    {
        public static List<SelectListItem> ListOfCountries()
        {
            List<SelectListItem> listCountries = new List<SelectListItem>();
            listCountries.Add(new SelectListItem() { Value = "USA", Text = "United State" });
            listCountries.Add(new SelectListItem() { Value = "UK", Text = "England" });
            listCountries.Add(new SelectListItem() { Value = "CN", Text = "China" });
            listCountries.Add(new SelectListItem() { Value = "VN", Text = "Vietnam" });
            return listCountries;
        }
    }
}