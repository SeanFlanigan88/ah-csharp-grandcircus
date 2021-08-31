using System;

namespace _20210830
{
    // Parent
    public class Question
    {
        private string _question = string.Empty;

        public string GetQuestion
        {
            get {
                return _question;
            }
        }

        // Base Class Constructor
        public Question(string myQuestion)
        {
            this._question = myQuestion;
        }

        public virtual bool IsCorrect(object userInput)
        {
            throw new NotImplementedException("Should not call here");
        }
    }

    // Child
    public class TrueAndFalseQuestion: Question
    {
        private bool _userInput = false;
        private bool _correctAnswer = false;

        public bool Answer
        {
            get {
                return _userInput;
            }
            set {
                _userInput = value;
            }
        }

        // Child Class Constructor
        public TrueAndFalseQuestion(string question, bool answer): base(question)
        {
            this._correctAnswer = answer;
        }

        public override bool IsCorrect(object userInput)
        {
            bool input = Convert.ToBoolean(userInput ?? false);
            if (input == this._correctAnswer) {
                return true;
            } else {
                return false;
            }
        }

        // public bool IsCorrect()
        // {
        //     return _userInput == _correctAnswer;
        // }

    }

    public class ShortAnswerQuestion: Question
    {
        private string _userInput = string.Empty;
        private string _correctAnswer = string.Empty;

        public string Answer
        {
            get {
                return _userInput;
            }
            set {
                _userInput = value;
            }
        }

        // Child Class Constructor
        public ShortAnswerQuestion(string question, string answer): base(question)
        {
            this._correctAnswer = answer;
        }

        public bool IsCorrect()
        {
            return _userInput == _correctAnswer;
        }
    }
}