using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaShark.Models;

namespace TriviaShark.Interfaces
{
    public interface IHttpProvider
    {
        Result<List<Question>, string> GetQuestions();
    }
}
