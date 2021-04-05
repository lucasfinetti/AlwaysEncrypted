using AlwaysEncrypted.Data.Models;
using System.Collections.Generic;

namespace AlwaysEncrypted.Data.Repository
{
    public interface ICustomerRep
    {
        void Add(Customer customer);
        void Update(Customer customer);
        Customer GetById(int customerId);
        IEnumerable<Customer> GetAll();
    }
}
