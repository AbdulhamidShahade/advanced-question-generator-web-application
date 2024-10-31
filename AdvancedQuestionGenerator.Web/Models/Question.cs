using AdvancedQuestionGenerator.Web.Models.Base;

namespace AdvancedQuestionGenerator.Web.Models
{
    public class Question : BaseEntity
    {
        public string Title { get; set; }
        public List<Option> Options { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
