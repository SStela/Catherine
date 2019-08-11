using System.Threading.Tasks;
using AutoMapper;
using Catherine.Api.Requests;
using Catherine.Api.Responses;
using Catherine.Api.Services.Contracts;
using Catherine.Shared.Pagination;
using Microsoft.AspNetCore.Mvc;

namespace Catherine.Api.Controllers
{
    public class CountriesController : AppController
    {
        private readonly ICountryService Countries;

        public CountriesController(
            ICountryService countries
        ) {
            Countries = countries;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage([FromQuery] CountryPaginationRequest request = null)
        {
            PagedResult<CountryResponse> pagedResult = await Countries.GetPageAsync(request);
            return ApiOk(pagedResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(long id)
        {
            var country = await Countries.GetByIdAsync(id);
            return ApiOk(country);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            int success = await Countries.DeleteByIdAsync(id);
            return ApiOk(success);
        }
    }
}
