namespace PREFINALS_EXAM.Models
{
    public class ExamItem
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string>();
        public char CorrectAnswer { get; set; }
        public string AnswerText { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }

    public class TosRow
    {
        public string Cilo { get; set; } = string.Empty;
        public string Tlo { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int ItemCount { get; set; }
        public string ItemPlacement { get; set; } = string.Empty;
    }

    public class ExamViewModel
    {
        public List<ExamItem> Questions { get; set; } = new List<ExamItem>();
        public List<TosRow> TosData { get; set; } = new List<TosRow>();
    }
}