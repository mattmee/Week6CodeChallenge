using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week6CodeChallenge.Models
{
    public class Contact
    {
        //TODO: Fill in the contact class
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string CompanyName { get; set; }
        public string ProductDesc { get; set; }
        public string Comment { get; set; }

        public Contact() { }
        public Contact(int contactId, string firstName, string lastName, string email, string phoneNum, string companyName, string productDesc, string comment)
        {
            this.ContactId = contactId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNum = phoneNum;
            this.CompanyName = companyName;
            this.ProductDesc = productDesc;
            this.Comment = comment;
        }

    }
}