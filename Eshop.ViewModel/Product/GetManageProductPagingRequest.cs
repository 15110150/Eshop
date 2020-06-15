using Eshop.ViewModel.Common;
using System.Collections.Generic;

namespace Eshop.ViewModel.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}