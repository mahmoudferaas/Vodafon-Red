using System.Collections.Generic;
using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Vodafon_Red.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly IVendorService _VendorsService;


        public VendorsController(IVendorService VendorsService)
        {
            _VendorsService = VendorsService;
        }
        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<VendorsDto>> Get()
        {
            return _VendorsService.GetAllVendors();
        }

        // GET values/5
        [HttpGet("{id}")]
        public ActionResult<VendorsDto> Get(int id)
        {
            return _VendorsService.GetVendorById(id);
        }

        // POST values
        [HttpPost]
        public OutPutDto Post([FromBody] VendorsDto VendorsDto)
        {
            return _VendorsService.CreateVendor(VendorsDto);
        }

        // PUT values/5
        [HttpPut("{id}")]
        public OutPutDto Put(VendorsDto VendorsDto)
        {
            return _VendorsService.UpdateVendor(VendorsDto);
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public OutPutDto Delete(int id)
        {
            return _VendorsService.DeleteVendor(id);
        }
    }
}
