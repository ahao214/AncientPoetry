using AncientPoetry.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace AncientPoetry.Entities
{
    /// <summary>
    /// 朝代
    /// </summary>
    public class Dynasty : BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }
        public string? Remark { get; set; }
    }
}
