using BLL.Dtos;
using System.Collections.Generic;

namespace BLL.Abstractions
{
    public interface INumberService
    {
        NumbersDto GetNumberById(int id);
        List<NumbersDto> GetAllNumbers();
        OutPutDto CreateNumber(NumbersDto Number);
        OutPutDto UpdateNumber(NumbersDto Number);
        OutPutDto DeleteNumber(int NumberId);

    }
}
