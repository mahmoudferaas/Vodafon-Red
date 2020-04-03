using BLL.Dtos;
using DAL.Common.Enums;
using System.Collections.Generic;

namespace BLL.Abstractions
{
    public interface ISalesService
    {
        SalesDto GetSaleById(int id);
        List<SalesDto> GetAllSales();
        List<SalesDto> GetSalesByStatus(SaleStatus status);
        OutPutDto CreateSale(SalesDto sale);
        OutPutDto UpdateSale(SalesDto sale);
        OutPutDto DeleteSale(int saleId);

    }
}
