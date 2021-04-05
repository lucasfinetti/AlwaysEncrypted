using AlwaysEncrypted.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlwaysEncrypted.Data.Repository
{
    public class CustomerRep : ICustomerRep
    {
        private readonly Context _context;

        public CustomerRep(Context context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customer.ToList();
        }

        public Customer GetById(int customerId)
        {
            return _context.Customer.FirstOrDefault(x => x.CustomerId == customerId);
        }

        public void Update(Customer customer)
        {
            _context.Update(customer);
        }
    }
}
