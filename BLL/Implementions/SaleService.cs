using AutoMapper;
using BLL.Abstractions;
using BLL.Dtos;
using DAL.Common.Enums;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Implementions
{
    public class SaleService : ISalesService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Sale> _context;

        public SaleService(IMapper mapper , IRepository<Sale> context )
        {
            _mapper = mapper;
            _context = context;

        }
        public OutPutDto CreateSale(SalesDto saleDto)
        {
            var entity = _mapper.Map<Sale>(saleDto);
            try
            {
                _context.Add(entity);
                return new OutPutDto
                {
                    Id = entity.ID,
                    IsSuccessed = true
                };
            }
            catch (Exception ex)
            {
                return new OutPutDto
                {
                    Id = null,
                    IsSuccessed = false
                };
            }
        }

        public OutPutDto DeleteSale(int saleId)
        {
            try
            {
                _context.Remove(saleId);
                return new OutPutDto
                {
                    IsSuccessed = true
                };
            }
            catch (Exception)
            {
                return new OutPutDto
                {
                    IsSuccessed = false
                };
            }
        }

        public List<SalesDto> GetAllSales()
        {
            var sales = _context.GetAll();
            return _mapper.Map<List<SalesDto>>(sales);
        }

        public SalesDto GetSaleById(int id)
        {
            return _mapper.Map<SalesDto>(_context.Get(id));
        }

        public List<SalesDto> GetSalesByStatus(SaleStatus status)
        {
            var sales = _context.GetAll().Where(a =>a.Status.ID == (int)status).ToList();

            return _mapper.Map<List<SalesDto>>(sales);
        }

        public OutPutDto UpdateSale(SalesDto sale)
        {
            var entity = _mapper.Map<Sale>(sale);
            try
            {
                _context.Update(entity);
                return new OutPutDto
                {
                    Id = entity.ID,
                    IsSuccessed = true
                };
            }
            catch (Exception)
            {
                return new OutPutDto
                {
                    Id = null,
                    IsSuccessed = false
                };
            }

        }
    }
}
