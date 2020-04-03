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
    public class VendorService : IVendorService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Vendor> _context;

        public VendorService(IMapper mapper , IRepository<Vendor> context )
        {
            _mapper = mapper;
            _context = context;

        }
        public OutPutDto CreateVendor(VendorsDto vendor)
        {
            var entity = _mapper.Map<Vendor>(vendor);
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

  

        public OutPutDto DeleteVendor(int vendorId)
        {
            try
            {
                _context.Remove(vendorId);
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


        public List<VendorsDto> GetAllVendors()
        {
            var Vendors = _context.GetAll();
            return _mapper.Map<List<VendorsDto>>(Vendors);
        }


        public VendorsDto GetVendorById(int id)
        {
            return _mapper.Map<VendorsDto>(_context.Get(id));
        }



        public OutPutDto UpdateVendor(VendorsDto vendor)
        {
            var entity = _mapper.Map<Vendor>(vendor);
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
