using AutoMapper;
using CoreApiResponse;
using Ecommerce.Data.Interface;
using Ecommerce.Filters;
using Ecommerce.Helpers;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Ecommerce.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

[ApiController]
[Route("/api/categories")]
[Authorize]
public class CategoryController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IUriService _uriService;

    public CategoryController(IUnitOfWork unitOfWork, IMapper mapper, IUriService uriService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _uriService = uriService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginateDto<List<Category>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> FindAll([FromQuery] PaginationFilter paginationFilter)
    {
        var pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
        var response = await _unitOfWork.CategoryRepository.Paginate(pagination);
        var route = Request.Path.Value!;

        var categoryPaginate =
            PaginationHelper.CreatePagedResponse(response.Data.ToList(),
                pagination, response.TotalRecord, _uriService, route);

        return CustomResult("Success", categoryPaginate);
    }
}