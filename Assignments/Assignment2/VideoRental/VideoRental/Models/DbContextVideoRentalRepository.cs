using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class DbContextVideoRentalRepository
    {
        DbContextVideoRental context = new DbContextVideoRental();

        //get all customers
        public List<Customer> GetCustomers()
        {
            return (from c in context.Customers
                    select c).ToList();
        }

        //get customer by id
        public Customer GetCustomerByID(int customerID)
        {
            return (from c in context.Customers
                    where c.ID == customerID
                    select c).SingleOrDefault();
        }


        //add a new customer  
        public void AddNewCustomer(Customer customer)
        {

            context.Customers.Add(customer);

            context.SaveChanges();

        }

        //add a new media  
        public void AddNewMedia(Media media)
        {

            context.Media.Add(media);

            context.SaveChanges();

        }

        // add rental record not working :)
        public void AddRentalRecord(int customerID, List<Media> rentedMedia)
        {
            /*
            Customer customer = (from c in context.Customers where c.ID == customerID select c).SingleOrDefault();

            
            RentalRecord newRecord = new RentalRecord
            {
                RentalDate = DateTime.Now,
                RentedMedia = rentedMedia
            };

            context.RentalRecords.Add(newRecord);
            
            /*
            customer.RentalRecords.Add(
                new RentalRecord
                {
                    RentalDate = DateTime.Now,
                    RentedMedia = rentedMedia
                });
                
            context.SaveChanges();
            */

        }
        // get media by title
        public List<Media> GetMediaByTitle(string title)
        {
            return (from m in context.Media where m.Title == title select m).ToList();

        }

        // get media by id
        public Media GetMediaByID(int id)
        {
            return (from m in context.Media where m.ID == id select m).SingleOrDefault();

        }
    }
}