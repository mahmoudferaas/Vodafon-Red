using System.Collections.Generic;
using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Vodafon_Red.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly IPackageService _PackagesService;


        public PackagesController(IPackageService PackagesService)
        {
            _PackagesService = PackagesService;
        }
        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<PackagesDto>> Get()
        {
            return _PackagesService.GetAllPackages();
        }

        // GET values/5
        [HttpGet("{id}")]
        public ActionResult<PackagesDto> Get(int id)
        {
            return _PackagesService.GetPackageById(id);
        }

        // POST values
        [HttpPost]
        public OutPutDto Post([FromBody] PackagesDto PackagesDto)
        {
            return _PackagesService.CreatePackage(PackagesDto);
        }

        // PUT values/5
        [HttpPut("{id}")]
        public OutPutDto Put(PackagesDto PackagesDto)
        {
            return _PackagesService.UpdatePackage(PackagesDto);
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public OutPutDto Delete(int id)
        {
            return _PackagesService.DeletePackage(id);
        }
    }
}
