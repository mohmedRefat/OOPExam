using Models.Questions;

namespace Models.Exams
{   
    //* inherit from Exam class , implement Exam abstract methods
    public class FinalExam : Exam
    {
        public FinalExam(int time, Question[] questionsArr)
            : base(time, questionsArr)
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine("*********** Final Exam ***********");
            Console.WriteLine($"Time: {Time} Minutes");
            Console.WriteLine($"Number Of Questions: {NumOfQuestions}");
            Console.WriteLine();

            int grade = 0;

            for (int i = 0; i < QuestionsArr.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(QuestionsArr[i].Body);

                for (int j = 0; j < QuestionsArr[i].AnswersArr.Length; j++)
                {
                    Console.WriteLine(QuestionsArr[i].AnswersArr[j]);
                }

                Console.WriteLine($"Mark: {QuestionsArr[i].Mark}");
                Console.WriteLine("*****************************");

                grade += QuestionsArr[i].Mark;
            }

            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine("*********************************");
        }

        protected override Exam CreateClone(Question[] questionsArr)
        {
            return new FinalExam(Time, questionsArr);
        }
    }
}
