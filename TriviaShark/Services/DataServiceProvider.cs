using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TriviaShark.Interfaces;
using TriviaShark.Models;

namespace TriviaShark.Services
{
    public class DataServiceProvider : IDataService
    {
        public async Task<string> GetConnectionStringAsync()
        {
            var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            var json = await File.ReadAllTextAsync(jsonPath);
            var conStr = JsonSerializer.Deserialize<ConfigJson>(json)!.ConnectionString;

            return conStr!;
        }
    }
}
