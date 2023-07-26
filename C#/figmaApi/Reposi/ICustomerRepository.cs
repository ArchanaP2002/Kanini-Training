using System.Collections.Generic;
using figmaApi.Models;

public interface ICustomerRepository
{
    List<CustomerTable> GetAllCustomers();
    CustomerTable GetCustomerById(int customerId);
    void AddCustomer(CustomerTable customer);
    void UpdateCustomer(CustomerTable customer);
}
