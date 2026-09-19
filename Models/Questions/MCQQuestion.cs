using Models.Answers;

namespace Models.Questions
{
    //* inherits from Question class 
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answersArr, Answer rightAnswer)
            : base(header, body, mark, answersArr, rightAnswer)
        {
        }
        //* override the abstract method to display question and answers
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
            return new MCQQuestion(Header, Body, Mark, answersArr, rightAnswer);
        }
    }
}