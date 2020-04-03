using AutoMapper;
using BLL.Abstractions;
using BLL.Dtos;
using DAL.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Implementions
{
    public class StatusService : IStatusService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Status> _context;

        public StatusService(IMapper mapper , IRepository<Status> context )
        {
            _mapper = mapper;
            _context = context;

        }
        public OutPutDto CreateStatus(StatusDto StatusDto)
        {
            var entity = _mapper.Map<Status>(StatusDto);
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
                    IsSuccessed = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public OutPutDto DeleteStatus(int StatusId)
        {
            try
            {
                _context.Remove(StatusId);
                return new OutPutDto
                {
                    IsSuccessed = true
                };
            }
            catch (Exception ex)
            {
                return new OutPutDto
                {
                    IsSuccessed = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public List<StatusDto> GetAllStatuss()
        {
            var Statuss = _context.GetAll();
            return _mapper.Map<List<StatusDto>>(Statuss);
        }

        public StatusDto GetStatusById(int id)
        {
            return _mapper.Map<StatusDto>(_context.Get(id));
        }

        public OutPutDto UpdateStatus(StatusDto Status)
        {
            var entity = _mapper.Map<Status>(Status);
            try
            {
                _context.Update(entity);
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
                    IsSuccessed = false,
                    ErrorMessage = ex.Message
                };
            }

        }
    }
}
