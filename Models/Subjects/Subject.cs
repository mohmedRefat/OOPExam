using Models.Exams;

namespace Models.Subjects
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam? Exam { get; set; }

        public Subject(int id, string Name)
        {
            SubjectId = id;
            SubjectName = Name;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"Subject: {SubjectId} - {SubjectName}";
        }
    }
}