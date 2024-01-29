using Microsoft.AspNetCore.Mvc.Rendering;

namespace AncientPoetry.Entities.ViewModels
{
    public class PoetVM
    {
        public Poet? Poet { get; set; }

        public IEnumerable<SelectListItem> DynastyList { get; set; }
    }
}
