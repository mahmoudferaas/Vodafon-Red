using System.Collections.Generic;
using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Vodafon_Red.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _StatusService;


        public StatusController(IStatusService StatusService)
        {
            _StatusService = StatusService;
        }
        // GET values
        [HttpGet]
        public ActionResult<IEnumerable<StatusDto>> Get()
        {
            return _StatusService.GetAllStatuss();
        }

        // GET values/5
        [HttpGet("{id}")]
        public ActionResult<StatusDto> Get(int id)
        {
            return _StatusService.GetStatusById(id);
        }

        // POST values
        [HttpPost]
        public OutPutDto Post([FromBody] StatusDto StatusDto)
        {
            return _StatusService.CreateStatus(StatusDto);
        }

        // PUT values/5
        [HttpPut("{id}")]
        public OutPutDto Put(StatusDto StatusDto)
        {
            return _StatusService.UpdateStatus(StatusDto);
        }

        // DELETE values/5
        [HttpDelete("{id}")]
        public OutPutDto Delete(int id)
        {
            return _StatusService.DeleteStatus(id);
        }
    }
}
