using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using AutoMapper;
using Infrastructure.Common;
using Infrastructure.Spends.Profiles;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services
{
    public static class AddExtraService
    {
        public static IServiceCollection AddExtraServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            var config = new MapperConfiguration(c =>
            {
                //c.AddProfile<InternProfile>();
                //c.AddProfile<RestaurantProfile>();
                //c.AddProfile<PositionProfile>();
                //c.AddProfile<EmployeeProfile>();
                //c.AddProfile<RoleProfile>();
                //c.AddProfile<ProductProfile>();
                //c.AddProfile<FailProfile>();
                //c.AddProfile<RestaurantContactProfile>();
                //c.AddProfile<ContractProfile>();
                //c.AddProfile<ContractPaymentProfile>();
                //c.AddProfile<RestaurantMeetingProfile>();
                //c.AddProfile<SpendProfile>();
                //c.AddProfile<StantProfile>();
                //c.AddProfile<EmployeePaymentProfile>();
                //c.AddProfile<PrePaymentProfile>();
                //c.AddProfile<UserProfile>();
                //c.AddProfile<UserTokenProfile>();
                //c.AddProfile<RestaurantStatusProfile>();
                //c.AddProfile<EmployeePunishmentProfile>();

                List<Type> types = typeof(SpendProfile).Assembly
                    .GetTypes()
                    .Where(e =>
                    !e.IsAbstract &&
                    !e.IsInterface &&
                    typeof(IProfileRegister)
                        .IsAssignableFrom(e) &&
                    typeof(Profile).IsAssignableFrom(e))
                    .ToList();

                foreach (var type in types)
                {
                    c.AddProfile(type);
                }

            });
            services.AddSingleton<IMapper>(s => config.CreateMapper());



            services.AddHttpContextAccessor();
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);


            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
            });
            return services;
        }
    }
}
