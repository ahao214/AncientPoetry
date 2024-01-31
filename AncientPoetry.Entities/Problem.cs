using AncientPoetry.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AncientPoetry.Entities
{
    /// <summary>
    /// 问题表
    /// </summary>
    public class Problem : BaseEntity
    {
        /// <summary>
        /// 题目
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// 答案
        /// </summary>
        [Required]
        public string Answer { get; set; }
        [ForeignKey("ProblemType")]
        public int ProblemId { get; set; }
        public ProblemType? ProblemType { get; set; }    

    }
}
