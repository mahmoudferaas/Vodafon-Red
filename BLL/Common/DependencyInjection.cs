using AutoMapper;
using BLL.Abstractions;
using BLL.Implementions;
using DAL.Entities;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BLL.Common
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddBLL(this IServiceCollection services)
		{

			services.AddScoped<IRepository<Number>, Repository<Number>>();
			services.AddScoped<IRepository<Package>,Repository<Package>>();
			services.AddScoped<IRepository<Sale>,   Repository<Sale>>();
			services.AddScoped<IRepository<Status>, Repository<Status>>();
			services.AddScoped<IRepository<Vendor>, Repository<Vendor>>();

			services.AddScoped<ISalesService, SaleService>();
			services.AddScoped<INumberService, NumberService>();
			services.AddScoped<IStatusService, StatusService>();
			services.AddScoped<IPackageService, PackageService>();
			services.AddScoped<IVendorService, VendorService>();
			services.AddScoped<IUserService, UserService>();

			services.AddAutoMapper(Assembly.GetExecutingAssembly());

			return services;
		}
	}
}
