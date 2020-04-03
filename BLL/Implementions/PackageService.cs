using AutoMapper;
using BLL.Abstractions;
using BLL.Dtos;
using DAL.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Implementions
{
    public class PackageService : IPackageService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Package> _context;

        public PackageService(IMapper mapper , IRepository<Package> context )
        {
            _mapper = mapper;
            _context = context;

        }
        public OutPutDto CreatePackage(PackagesDto PackageDto)
        {
            var entity = _mapper.Map<Package>(PackageDto);
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

        public OutPutDto DeletePackage(int PackageId)
        {
            try
            {
                _context.Remove(PackageId);
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

        public List<PackagesDto> GetAllPackages()
        {
            var Package = _context.GetAll();
            return _mapper.Map<List<PackagesDto>>(Package);
        }


        public PackagesDto GetPackageById(int id)
        {
            return _mapper.Map<PackagesDto>(_context.Get(id));
        }

        

        public OutPutDto UpdatePackage(PackagesDto Package)
        {
            var entity = _mapper.Map<Package>(Package);
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
