using BLL.Dtos;
using System.Collections.Generic;

namespace BLL.Abstractions
{
    public interface IVendorService
    {
        VendorsDto GetVendorById(int id);
        List<VendorsDto> GetAllVendors();
        OutPutDto CreateVendor(VendorsDto vendor);
        OutPutDto UpdateVendor(VendorsDto vendor);
        OutPutDto DeleteVendor(int vendorId);

    }
}
