 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Shared.Response
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
    }

    public class BaseResponseGeneric<T> : BaseResponse
    {
        public T Data { get; set; } = default!;
    }

    public class PaginationResponse<T> : BaseResponse
    {
        public ICollection<T>? Data { get; set; }
        public int TotalPages { get; set; }
    }
}
