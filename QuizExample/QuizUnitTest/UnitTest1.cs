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

            if (q1.GetType() != typeof(TrueOrFalse))
            {
                throw new Exception();
            }
            
        } 
    }
}
