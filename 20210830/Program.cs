using System;
using System.Collections.Generic;

namespace _20210830
{
    class Program
    {
        public static List<Question> allMyQuestions = new List<Question>();

        static void Main(string[] args)
        {
            #region Deck Of Cards

            List<Card> Deck = new List<Card>();
            Deck.Add(new Heart(1));
            Deck.Add(new Diamond(1));
            Deck.Add(new Spade(1));
            Deck.Add(new Club(1));

            foreach(var card in Deck)
            {
                Console.WriteLine($"{card.ToString()} of {card.GetType()}");
            }

            #endregion

            #region Question and Answer Example

            // var shortAnswerQuestion = new ShortAnswerQuestion("What day is it?", "Monday");

            // var trueAndFalseQuestion = new TrueAndFalseQuestion("True or False: The earth is flat", false);
            // Console.WriteLine(trueAndFalseQuestion.GetQuestion);

            // //trueAndFalseQuestion.Answer = false;

            // Console.WriteLine(trueAndFalseQuestion.IsCorrect(false));

            // allMyQuestions.Add(shortAnswerQuestion);
            // allMyQuestions.Add(trueAndFalseQuestion);

            // //var questionOne = allMyQuestions[0];
            // var questionOne = allMyQuestions[1].IsCorrect(false);

            // Question q = new TrueAndFalseQuestion("Is True?", true);
            // Console.WriteLine(q.GetType());

            // allMyQuestions.Add(q);

            #endregion

        }
    }
}
