using AdvancedQuestionGenerator.Web.Models.Base;

namespace AdvancedQuestionGenerator.Web.Models
{
    public class Option : BaseEntity
    {
        public string Title { get; set; }
        bool Status { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
