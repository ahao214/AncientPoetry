using AncientPoetry.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AncientPoetry.Entities
{
    /// <summary>
    /// 问题类型
    /// </summary>
    public class ProblemType : BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }


    }
}
