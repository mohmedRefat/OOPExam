using Models.Questions;

namespace Models.Exams
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, Question[] questionsArr)
            : base(time, questionsArr)
        {
        }

        public override void DisplayAllQuestions()
        {
            Console.WriteLine("******* Practical Exam ******* ");
            Console.WriteLine($"Time: {Time} Minutes");
            Console.WriteLine($"Number Of Questions: {NumOfQuestions}");
            Console.WriteLine();

            for (int i = 0; i < QuestionsArr.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(QuestionsArr[i].Body);

                for (int j = 0; j < QuestionsArr[i].AnswersArr.Length; j++)
                {
                    Console.WriteLine(QuestionsArr[i].AnswersArr[j]);
                }

                Console.WriteLine($"Right Answer: {QuestionsArr[i].RightAnswer}");
                Console.WriteLine("****************************");
            }

            Console.WriteLine("================================");
        }

        protected override Exam CreateClone(Question[] questionsArr)
        {
            return new PracticalExam(Time, questionsArr);
        }
    }
}