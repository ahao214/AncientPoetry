using AncientPoetry.Entities.Base;

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
        public string Name { get; set; }
        public string? Remark { get; set; }
    }
}
