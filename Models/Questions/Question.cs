using Models.Answers;

namespace Models.Questions
{
    public abstract class Question : ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] AnswersArr { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(string header, string body, int mark, Answer[] ansArr, Answer rightAns)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswersArr = ansArr;
            RightAnswer = rightAns;
        }
            // will be implemented in (mcq, true/false) classes
        public abstract void ShowQuestion();


        //* Create deep copy of the question object
        public object Clone()
        {
            Answer[] clonedAnswers = new Answer[AnswersArr.Length];

            for (int i = 0; i < AnswersArr.Length; i++)
            {
                clonedAnswers[i] = new Answer(
                    AnswersArr[i].AnswerId,
                    AnswersArr[i].AnswerText
                );
            }

            Answer clonedRightAnswer = new Answer(
                RightAnswer.AnswerId,
                RightAnswer.AnswerText
            );

            return CreateClone(clonedAnswers, clonedRightAnswer);
        }
        //* Create new instance of the question object with cloned and right answers
        protected abstract Question CreateClone(Answer[] answersArr, Answer rightAnswer);

        public override string ToString()
        {
            return $"{Header}: {Body} - Mark: {Mark}";
        }
    }
}