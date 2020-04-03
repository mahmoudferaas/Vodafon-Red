using BLL.Dtos;
using System.Collections.Generic;

namespace BLL.Abstractions
{
    public interface IPackageService
    {
        PackagesDto GetPackageById(int id);
        List<PackagesDto> GetAllPackages();
        OutPutDto CreatePackage(PackagesDto Package);
        OutPutDto UpdatePackage(PackagesDto Package);
        OutPutDto DeletePackage(int PackageId);

    }
}
