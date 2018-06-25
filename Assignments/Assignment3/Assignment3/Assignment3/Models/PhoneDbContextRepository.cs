using Assignment3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Assignment3.Models
{
    public class PhoneDbContextRepository
    {
        PhonoDbContext context = new PhonoDbContext();

        public List<Phone> GetAllPhones()
        {
            List<Phone> phones = new List<Phone>();

            phones.AddRange(from p in context.Phone select p);

            return phones;
        }

        // probably shouldve named this GetPhoneViewModelById
        public PhoneFullDetailsViewModel GetPhoneById(int id)
        {
            return (from p in context.Phone
                    join b in context.Brand 
                    on p.BrandId equals b.ID
                    join t in context.PhoneType
                    on p.PhoneTypeId equals t.ID
                    where p.ID == id
                    select new PhoneFullDetailsViewModel
                    {
                        ID = p.ID,
                        PhoneName = p.PhoneName,
                        DateReleased = p.DateReleased,
                        ScreenSize = p.ScreenSize,
                        BrandName = b.BrandName,
                        CountryOfOrigin = b.CountryOfOrigin,
                        Type = t.Type,
                        OS = t.OS
                    }).SingleOrDefault();
        }

        public Phone GetSimplePhoneById(int id)
        {
            return context.Phone.SingleOrDefault(p => p.ID == id);
        }

        public Brand GetBrandById(int id)
        {
            return (from b in context.Brand where b.ID == id select b).SingleOrDefault();
        }

        public List<Brand> GetAllBrands()
        {
            List<Brand> Brands = new List<Brand>();

            Brands.AddRange(from b in context.Brand select b);

            return Brands;
        }

        public List<PhoneType> GetAllPhoneTypes()
        {
            List<PhoneType> PhoneTypes = new List<PhoneType>();

            PhoneTypes.AddRange(from p in context.PhoneType select p);

            return PhoneTypes;
        }

        public List<Phone> GetPhonesByBrand(int id)
        {

            return (from p in context.Phone                         
                          where p.BrandId == id
                          select p).ToList();


        }
        public AddPhoneViewModel AddPhoneModel()
        {
            AddPhoneViewModel model = new AddPhoneViewModel
            {
                Brands = GetAllBrands(),
                PhoneTypes = GetAllPhoneTypes()
            };

            return model;
        }

        // to edit an existing one
        public AddPhoneViewModel AddPhoneModel(PhoneFullDetailsViewModel phone)
        {
            AddPhoneViewModel model = new AddPhoneViewModel
            {
                ID = phone.ID,
                BrandName = phone.BrandName,
                PhoneName = phone.PhoneName,
                DateReleased = phone.DateReleased,
                ScreenSize = phone.ScreenSize,
                Brands = GetAllBrands(),
                PhoneTypes = GetAllPhoneTypes()
            };

            return model;
        }


        public void AddNewPhone(Phone phone)
        {
            context.Phone.Add(phone);
            context.SaveChanges();
        }
        public void EditPhone(Phone phone)
        {
            Phone existingPhone = GetSimplePhoneById(phone.ID);

            existingPhone.ID = phone.ID;
            existingPhone.PhoneName = phone.PhoneName;
            existingPhone.BrandId = phone.BrandId;
            existingPhone.PhoneTypeId = phone.PhoneTypeId;
            existingPhone.ScreenSize = phone.ScreenSize;
            existingPhone.DateReleased = phone.DateReleased;

            context.SaveChanges();
        }
        public void DeletePhone(Phone phone)
        {
            Phone existingPhone = GetSimplePhoneById(phone.ID);

            context.Phone.Remove(existingPhone);

            context.SaveChanges();
        }
    }
}