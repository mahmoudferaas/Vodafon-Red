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
    public class NumberService : INumberService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Number> _context;

        public NumberService(IMapper mapper , IRepository<Number> context )
        {
            _mapper = mapper;
            _context = context;

        }
        public OutPutDto CreateNumber(NumbersDto NumberDto)
        {
            var entity = _mapper.Map<Number>(NumberDto);
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

        public OutPutDto DeleteNumber(int NumberId)
        {
            try
            {
                _context.Remove(NumberId);
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

        public List<NumbersDto> GetAllNumbers()
        {
            var Numbers = _context.GetAll();
            return _mapper.Map<List<NumbersDto>>(Numbers);
        }

        public NumbersDto GetNumberById(int id)
        {
            return _mapper.Map<NumbersDto>(_context.Get(id));
        }

        public OutPutDto UpdateNumber(NumbersDto Number)
        {
            var entity = _mapper.Map<Number>(Number);
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
