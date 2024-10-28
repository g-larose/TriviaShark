using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TriviaShark.Interfaces;
using TriviaShark.Models;

namespace TriviaShark.Services
{
    public class HttpServiceProvider : IHttpProvider
    {
        public Result<List<Question>, string> GetQuestions()
        {
            var questions = new List<Question>();
            using HttpClient client = new HttpClient();
            var link = "https://opentdb.com/api.php?amount=10";

            Task.Run(async () =>
            {
                HttpResponseMessage response = await client.GetAsync(link);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var json =  JsonSerializer.Deserialize<Question>(content)!;
                var question = new Question()
                {
                    _Question = json._Question,
                    CorrectAnswer = json.CorrectAnswer,
                    IncorrectAnswers = json.IncorrectAnswers,
                    Type = json.Type,
                    Category = json.Category,
                    Difficulty = json.Difficulty
                };
                questions.Add(question);
            });


            if (questions.Count > 0) return questions;
            else return "no questions found";
        }
    }
}
