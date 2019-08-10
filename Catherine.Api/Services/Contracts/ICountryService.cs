using System.Threading.Tasks;
using Catherine.Api.Requests;
using Catherine.Api.Responses;
using Catherine.Model.Countries;
using Catherine.Shared.Pagination;

namespace Catherine.Api.Services.Contracts
{
    public interface ICountryService
    {
        Task<PagedResult<CountryResponse>> GetPageAsync(CountryPaginationRequest request);
        Task<CountryResponse> GetByIdAsync(long id);

        Task<int> DeleteByIdAsync(long id);
    }
}