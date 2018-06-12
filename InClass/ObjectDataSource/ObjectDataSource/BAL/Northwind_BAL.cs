using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObjectDataSource.Data;

namespace ObjectDataSource.BAL
{
    public class Northwind_BAL
    {
        public List<string> GetCountriesFromCustomers()
        {
            using (var context = new DataClasses1DataContext())
            {
                List<string> countryList = (from countries in context.Customers select countries.Country).Distinct().ToList();
                return countryList;                        
            }
                
        }

        // customers from selected country
        public List<Customer> GetCustomersByCountry(string country)
        {
            using (var context = new DataClasses1DataContext())
            {
                List<Customer> customersList = (from c in context.Customers where c.Country == country select c).ToList();
                return customersList;
            }
        }
        // customer details
        
    }
}