namespace Models.Answers
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string txt)
        {
            AnswerId = id;
            AnswerText = txt;
        }

        public override string ToString()
        {
            return $"{AnswerId}.{AnswerText}";
        }
    }
}