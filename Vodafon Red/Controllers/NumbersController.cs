using System.Collections.Generic;
using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Vodafon_Red.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        private readonly INumberService _NumbersService;


        public NumbersController(INumberService NumbersService)
        {
            _NumbersService = NumbersService;
        }
        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<NumbersDto>> Get()
        {
            return _NumbersService.GetAllNumbers();
        }

        // GET values/5
        [HttpGet("{id}")]
        public ActionResult<NumbersDto> Get(int id)
        {
            return _NumbersService.GetNumberById(id);
        }

        // POST values
        [HttpPost]
        public OutPutDto Post([FromBody] NumbersDto NumbersDto)
        {
            return _NumbersService.CreateNumber(NumbersDto);
        }

        // PUT values/5
        [HttpPut("{id}")]
        public OutPutDto Put(NumbersDto NumbersDto)
        {
            return _NumbersService.UpdateNumber(NumbersDto);
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public OutPutDto Delete(int id)
        {
            return _NumbersService.DeleteNumber(id);
        }
    }
}
