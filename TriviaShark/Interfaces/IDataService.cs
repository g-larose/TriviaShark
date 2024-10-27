using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaShark.Interfaces
{
    public interface IDataService
    {
        Task<string> GetConnectionStringAsync();
    }
}
