using Portal.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Services.Interfaces
{
    public interface ICategoryService 
    {
        Task<BaseResponseGeneric<ICollection<CategoryDTOResponse>>> ListAsync();

        Task<BaseResponseGeneric<CategoryDTOResponse>> FindByIdAsync(int id);

        Task<BaseResponse> AddAsync(CategoryDTOResponse request, string usuario);

        Task<BaseResponse> UpdateAsync(int id, CategoryDTOResponse request, string usuario);

        Task<BaseResponse> DeleteAsync(int id);
    }
}
