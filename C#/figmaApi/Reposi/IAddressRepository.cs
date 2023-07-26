using figmaApi.Models;
using System.Collections.Generic;

namespace figmaApi.Repositories
{
    public interface IAddressRepository
    {
        IEnumerable<AddressInformationTable> GetAllAddresses();
        AddressInformationTable GetAddressById(int addressInformationId);
        void AddAddress(AddressInformationTable address);
    }
}
