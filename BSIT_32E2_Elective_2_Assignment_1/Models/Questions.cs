namespace BSIT_32E2_Elective_2_Assignment_1.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public string Topic { get; set; } = string.Empty;
        public string Prompt { get; set; } = string.Empty;
        public string[] Choices { get; set; } = Array.Empty<string>();
        public string Answer { get; set; } = string.Empty;
    }
}
