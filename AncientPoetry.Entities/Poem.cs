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
        public string Name { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        [ForeignKey("Poet")]
        public int PoetId { get; set; }

        public Poet Poet { get; set; }

        //前言
        public string? Preface { get; set; }

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
        /// 体裁
        /// </summary>
        public string? Genre { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }


    }
}
