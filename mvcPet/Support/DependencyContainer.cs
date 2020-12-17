
using Application.Interfaces;
using Application.Mapping;
using Application.Services;
using AutoMapper;
using Domain.Repository;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace mvcPet.Support
{
    public class  DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<PetContext>();

            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IThuCungService, ThuCungService>();
            services.AddScoped<IThuCungRepository, ThuCungRepository>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IKhachHangService, KhachHangService>();
            services.AddScoped<IKhachHangRepository, KhachHangRepository>();
            services.AddScoped<IHoaDonService, HoaDonService>();
            services.AddScoped<IHoaDonRepository, HoaDonRepository>();
            services.AddScoped<IChiTietHoaDonService, ChiTietHoaDonService>();
            services.AddScoped<IChiTietHoaDonRepository, ChiTietHoaDonRepository>();
            services.AddScoped<ITempService, TemptService>();
            services.AddScoped<ITemprepository, Temprepository>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();
        }

    }
}