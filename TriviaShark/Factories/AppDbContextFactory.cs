using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaShark.Data;
using TriviaShark.Interfaces;
using TriviaShark.Services;

namespace TriviaShark.Factories
{
    public class AppDbContextFactory : IDbContextFactory<AppDbContext>
    {
        private readonly IDataService _dataService = new DataServiceProvider();

        public AppDbContext CreateDbContext()
        {
            var conStr = "";
            Task.Run(async () =>
            {
                conStr = await _dataService.GetConnectionStringAsync();

            });
            var options = new DbContextOptionsBuilder<AppDbContext>();
            return new AppDbContext(options.Options);
        }
    }
}
