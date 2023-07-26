using figmaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace figmaApi.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly FigmaContext _context;

        public AddressRepository(FigmaContext context)
        {
            _context = context;
        }

        public IEnumerable<AddressInformationTable> GetAllAddresses()
        {
            return _context.AddressInformationTables.ToList();
        }

        public AddressInformationTable GetAddressById(int addressInformationId)
        {
            return _context.AddressInformationTables.Find(addressInformationId);
        }

        public void AddAddress(AddressInformationTable address)
        {
            _context.Add(address);
            _context.SaveChanges();
        }
    }
}
