using System.Collections.Generic;
using System.Linq;
using figmaApi.Models;

public class CustomerRepository : ICustomerRepository
{
    private readonly FigmaContext _context;

    public CustomerRepository(FigmaContext context)
    {
        _context = context;
    }

    public List<CustomerTable> GetAllCustomers()
    {
        return _context.CustomerTables.ToList();
    }

    public CustomerTable GetCustomerById(int customerId)
    {
        return _context.CustomerTables.Find(customerId);
    }

    public void AddCustomer(CustomerTable customer)
    {
        _context.Add(customer);
        _context.SaveChanges();
    }

    public void UpdateCustomer(CustomerTable customer)
    {
        _context.Update(customer);
        _context.SaveChanges();
    }
}
