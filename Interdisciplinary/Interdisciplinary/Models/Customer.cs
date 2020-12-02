using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interdisciplinary.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

       
        public Customer() { }

        public Customer(int customerId, string username, string password, string email) {
            CustomerId = customerId;
            Username = username;
            Password = password;
            Email = email;
        }

    }
}
