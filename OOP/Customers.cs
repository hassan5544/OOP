using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customers : BaseEntity
    {
        public string CustomerName { get; set; } = "";
        public int Age { get; set; }
        public string NationalId { get; set; } = "";
        public string PassportNo { get; set; } = "";

        public Customers(Guid CustomerId, string customerName, int age, string passport , string nationalId)
        {
            EntityId = CustomerId;
            CustomerName = customerName;
            Age = age;
            PassportNo = passport;
            NationalId = nationalId;
        }

        public Customers()
        {
            
        }
        public Customers GetCustomerbyId(Guid CustomerId)
        {
            Customers customer = new Customers();
            return customer;
        }

   
        public void Cancel (Guid CustomerId)
        {
            Customers customer =  GetCustomerbyId(CustomerId);
            customer.IsCanceled = true;
        }

        public Guid AddCustomer(string customerName , int age , string passport ,string NationalId)
        {
            Guid CustomerId = Guid.NewGuid();
            Customers NewCustomer = new Customers(CustomerId , customerName , age, passport ,NationalId);
            return CustomerId;
        }
     


    }
}
