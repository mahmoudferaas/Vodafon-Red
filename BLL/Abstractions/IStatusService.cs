using BLL.Dtos;
using System.Collections.Generic;

namespace BLL.Abstractions
{
    public interface IStatusService
    {
        StatusDto GetStatusById(int id);
        List<StatusDto> GetAllStatuss();
        OutPutDto CreateStatus(StatusDto Status);
        OutPutDto UpdateStatus(StatusDto Status);
        OutPutDto DeleteStatus(int StatusId);

    }
}
