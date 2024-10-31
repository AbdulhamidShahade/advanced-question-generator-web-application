using AdvancedQuestionGenerator.Web.Models.Base;

namespace AdvancedQuestionGenerator.Web.Models
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }

        public List<Question> Questions { get; set; }
    }
}
