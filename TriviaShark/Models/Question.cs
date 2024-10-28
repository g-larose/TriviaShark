using TriviaShark.Enums;

namespace TriviaShark.Models
{
    public class Question
    {
        public string? _Question { get; set; }
        public string? CorrectAnswer { get; set; }
        public string[]? IncorrectAnswers { get; set; }
        public Category Category { get; set; }
        public QuestionType Type { get; set; }
        public Difficulty Difficulty { get; set; }

    }
}
