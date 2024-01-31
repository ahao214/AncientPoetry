using AncientPoetry.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AncientPoetry.Entities
{
    /// <summary>
    /// 名句
    /// </summary>
    public class FamoutPhrase : BaseEntity
    {
        /// <summary>
        /// 名句内容
        /// </summary>
        [Required]
        public string Content { get; set; }
        [Required]
        /// <summary>
        /// 出处
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 作者
        /// </summary>        
        public string? Author { get; set; }
        /// <summary>
        /// 朝代名称
        /// </summary>
        public string? DynastyName { get; set; }


    }
}
