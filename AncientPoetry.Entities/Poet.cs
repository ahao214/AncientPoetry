using AncientPoetry.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AncientPoetry.Entities
{
    /// <summary>
    /// 诗人表
    /// </summary>
    public class Poet : BaseEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        [ForeignKey("Dynasty")]
        public int DynastyId { get; set; }
        public Dynasty Dynasty { get; set; }

    }
}
