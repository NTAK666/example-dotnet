using System.Security.Claims;
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
[Route("/api/products")]
[Authorize]
public class ProductController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUriService _uriService;

    public ProductController(IUnitOfWork unitOfWork, IUriService uriService)
    {
        _unitOfWork = unitOfWork;
        _uriService = uriService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginateDto<List<Product>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> FindAll([FromQuery] PaginationFilter paginationFilter)
    {
        var pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
        var response = await _unitOfWork.ProductRepository.Paginate(pagination);
        var route = Request.Path.Value!;

        var productPaginate =
            PaginationHelper.CreatePagedResponse(response.Data.ToList(),
                pagination, response.TotalRecord, _uriService, route);

        return CustomResult("Success", productPaginate);
    }

    [HttpGet("get-by-category/{categoryId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginateDto<List<Product>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> GetByCategory([FromRoute] string categoryId,
        [FromQuery] PaginationFilter paginationFilter)
    {
        var pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
        var response = await _unitOfWork.ProductRepository.Paginate(pagination,
            predicate: p => p.CategoryId == categoryId,
            relations: "Category");

        var route = Request.Path.Value!;

        var productPaginate =
            PaginationHelper.CreatePagedResponse(response.Data.ToList(),
                pagination, response.TotalRecord, _uriService, route);

        return CustomResult("Success", productPaginate);
    }

    [HttpGet("get/{productId}")]
    public async Task<IActionResult> GetById([FromRoute] string productId)
    {
        var product = await _unitOfWork.ProductRepository.FindById(productId, "Category");

        if (product == null) return BadRequest();

        return CustomResult("Success", product);
    }

}