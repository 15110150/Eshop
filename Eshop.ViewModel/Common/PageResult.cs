using System.Collections.Generic;

namespace Eshop.ViewModel.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}