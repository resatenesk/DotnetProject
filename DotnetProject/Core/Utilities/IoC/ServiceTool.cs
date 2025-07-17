﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.IoC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceProvider Create(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            ServiceProvider = serviceProvider;
            return serviceProvider;
        }
    }

}
