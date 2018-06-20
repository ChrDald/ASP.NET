using Exam1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam1.BAL
{
    public class SupplierBAL
    {
        public List<Supplier> GetSuppliers()
        {
            using (var context = new SupplierBALDataContext())
            {
                List<Supplier> supplierList = (from s in context.Suppliers select s).ToList();
                return supplierList;
            }

        }

        public List<Supplier> GetSuppliersByCity(string city)
        {
            using (var context = new SupplierBALDataContext())
            {
                List<Supplier> supplierList = (from sup in context.Suppliers where sup.City == city select sup).ToList();
                return supplierList;
            }

        }

    }
}