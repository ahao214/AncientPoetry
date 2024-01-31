using AncientPoetry.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AncientPoetry.Entities
{
    /// <summary>
    /// 诗歌表
    /// </summary>
    public class Poem : BaseEntity
    {
        /// <summary>
        /// 题目
        /// </summary>
        [Required]
        public string Titel { get; set; }
        /// <summary>
        /// 作者
        /// </summary>        
        public string? Author { get; set; }
        /// <summary>
        /// 朝代名称
        /// </summary>
        public string? DynastyName { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Required]
        public string Context { get; set; }
        /// <summary>
        /// 讲解
        /// </summary>
        public string? Explain { get; set; }
        /// <summary>
        /// 创作背景
        /// </summary>
        public string? CreateBackground { get; set; }
        /// <summary>
        /// 体裁
        /// </summary>
        public string? Genre { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }


    }
}
