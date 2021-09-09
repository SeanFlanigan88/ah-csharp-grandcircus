using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizProject;

namespace QuizUnitTest
{
    [TestClass]
    public class QuestionFactoryTests
    {
        [TestMethod]
        public void CreateTrueFalseQuestion()
        {
            IQuestion q1 = QuestionFactory.NewQuestion(QuestionFactory.QuestionType.TrueOrFalse);
            Assert.IsInstanceOfType(q1, typeof(TrueOrFalse));

            // if (q1.GetType() != typeof(TrueOrFalse))
            // {
            //     throw new Exception();
            // }
        }

        [TestMethod]
        public void CreateShortAnswerQuestion()
        {
            IQuestion q1 = QuestionFactory.NewQuestion(QuestionFactory.QuestionType.ShortAnswer);

            if (q1.GetType() != typeof(ShortAnswer))
            {
                throw new Exception();
            }
        } 
    }
}
