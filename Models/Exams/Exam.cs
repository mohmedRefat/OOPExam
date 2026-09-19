using Models.Questions;

namespace Models.Exams
{
    //* We implemented the IComparable and ICloneable to exam class
    public abstract class Exam : IComparable, ICloneable
    {
        public int Time { get; set; }
        public Question[] QuestionsArr { get; set; }
        public int NumOfQuestions => QuestionsArr.Length;

        protected Exam(int time, Question[] qstArr)
        {
            Time = time;
            QuestionsArr = qstArr;
        }

        public abstract void DisplayAllQuestions();

    //* Icomparable interface to Compare between two exams based on time
        public int CompareTo(object? obj)
        {
            Exam otherExam = (Exam)obj!;
            return Time.CompareTo(otherExam.Time);
        }

    //* Icloneable interface to create deep copy of the exam object
        public object Clone()
        {
            Question[] clonedQuestions = new Question[QuestionsArr.Length];

            for (int i = 0; i < QuestionsArr.Length; i++)
            {
                clonedQuestions[i] = (Question)QuestionsArr[i].Clone();
            }

            return CreateClone(clonedQuestions);
        }
            //* Create new instance of exam obj with cloned questions array
        protected abstract Exam CreateClone(Question[] questionsArr);

        public override string ToString()
        {
            return $"Time : {Time} Minutes, Questions: {NumOfQuestions}";
        }
    }
}