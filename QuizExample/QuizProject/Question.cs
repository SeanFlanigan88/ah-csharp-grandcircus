using System;

namespace QuizProject
{
    public interface IQuestion
    {
        string Question { get; }
        bool IsCorrect();
    }

    public class ShortAnswer: IQuestion
    {
        public string Question { get; }
        public string CorrectAnswer {get;set;}

        public string UserAnswer {get;set;}


        public bool IsCorrect()
        {
            return CorrectAnswer == UserAnswer;
        }
    }

    public class TrueOrFalse: IQuestion
    {
        public string Question { get; }
        public bool CorrectAnswer {get;set;}
        public bool UserAnswer {get;set;}


        public bool IsCorrect()
        {
            return CorrectAnswer == UserAnswer;
        }
    }

}