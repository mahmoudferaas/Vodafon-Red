using System.Collections.Generic;
using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Vodafon_Red.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _salesService;


        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }
        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<SalesDto>> Get()
        {
            return _salesService.GetAllSales();
        }

        // GET values/5
        [HttpGet("{id}")]
        public ActionResult<SalesDto> Get(int id)
        {
            return _salesService.GetSaleById(id);
        }

        // POST values
        [HttpPost]
        public OutPutDto Post([FromBody] SalesDto salesDto)
        {
            return _salesService.CreateSale(salesDto);
        }

        // PUT values/5
        [HttpPut("{id}")]
        public OutPutDto Put(SalesDto salesDto)
        {
            return _salesService.UpdateSale(salesDto);
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public OutPutDto Delete(int id)
        {
            return _salesService.DeleteSale(id);
        }
    }
}
