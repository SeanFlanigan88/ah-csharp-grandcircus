using System;

namespace QuizProject
{
    public class QuestionFactory
    {
        public enum QuestionType
        {
            TrueOrFalse,
            ShortAnswer
        }

        public static IQuestion NewQuestion(QuestionType typeOfQuestion)
        {
            switch (typeOfQuestion)
            {
                case QuestionType.TrueOrFalse: return new TrueOrFalse();
                case QuestionType.ShortAnswer: return new ShortAnswer();
            }

            throw new ArgumentException($"Question of type '{typeOfQuestion}' is not supported.");
        }
    }
}