using LearnCore.CommonLibrary.Client.TestRespository;
using LearnCore.CommonLibrary.Client.Users;
using LearnCore.CommonLibrary.Users;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LearnCore.Helpers
{
    public static class IocBootstrap
    {
        public static IServiceProvider Register(IServiceCollection services)
        {
            services.AddScoped<ITestRepositoryManager, TestRepositoryManager>();
            services.AddScoped<IUserManager, UserManager>();            

            return services.BuildServiceProvider();
        }
    }
}
