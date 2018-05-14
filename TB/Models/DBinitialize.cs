using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TB.Models
{
    public static class DBinitialize
    {
        public static void INIT(IServiceProvider serviceProvider)
        {
            var context = new DBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DBContext>>());
            context.Database.EnsureCreated();
            //context.Database.Migrate();
            context.SaveChanges();
        }
    }
}
