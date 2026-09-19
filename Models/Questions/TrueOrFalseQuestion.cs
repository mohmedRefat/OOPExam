using Models.Answers;

namespace Models.Questions
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, int mark, Answer[] ansArr, Answer rightAns)
            : base(header, body, mark, ansArr, rightAns)
        {
        }

        public override void DisplayAllQuestions()
        {
            Console.WriteLine(Body);

            for (int i = 0; i < AnswersArr.Length; i++)
            {
                Console.WriteLine(AnswersArr[i]);
            }
        }

        protected override Question CreateClone(Answer[] answersArr, Answer rightAnswer)
        {
            return new TrueOrFalseQuestion(Header, Body, Mark, answersArr, rightAnswer);
        }
    }
}