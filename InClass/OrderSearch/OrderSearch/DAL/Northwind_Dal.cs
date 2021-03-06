﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderSearch.Data;

namespace OrderSearch.DAL
{
    public class Northwind_Dal
    {
        public List<Order> OrdersByDate(DateTime date)
        {
            using (var context = new DataClasses1DataContext())
            {
                List<Order> orderList = (from data in context.Orders
                                         join details in context.Order_Details 
                                         on data.OrderID equals details.OrderID
                                         where data.OrderDate == date
                                         select data).ToList();
                return orderList;
            }
        }
        /*
        public List<Product> GetProductsByOrderId(int orderId)
        {
            // get all products associated with the specified order id
            // FIX THIS
            using (var context = new DataClasses1DataContext())
            {
                List<Product> productsList = (from orderDetails in context.Order_Details
                                              join products in context.Products
                                              on orderDetails.ProductID equals products.ProductID
                                              where orderDetails.OrderID == orderId
                                              select orderDetails).ToList();
                return productsList;
            }
        }
        */
    }
}