using Models.Answers;
using Models.Exams;
using Models.Questions;
using Models.Subjects;

namespace MainTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer[] mcqAnswers =
            {
                new Answer(1, "paris"),
                new Answer(2, "london"),
                new Answer(3, "berlin"),
            };

            Answer[] trueFalseAnswers =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            Question question1 = new MCQQuestion(
                " MCQ Question",
                "what is the capital of France?",
                5,
                mcqAnswers,
                mcqAnswers[0]
            );

            Question question2 = new TrueOrFalseQuestion(
                "True / False Question",
                " the capital of London is  Cairo",
                5,
                trueFalseAnswers,
                trueFalseAnswers[0]
            );

            Question[] questions =
            {
                question1,
                question2
            };

            Subject subject = new Subject(1, "Geography");
            Exam finalExam = new FinalExam(60, questions);

            subject.CreateExam(finalExam);

            Console.WriteLine(subject);
            Console.WriteLine();
            subject.Exam.DisplayAllQuestions();
        }
    }
}