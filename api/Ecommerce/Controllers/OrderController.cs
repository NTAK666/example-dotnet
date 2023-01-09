using System.Net;
using System.Security.Claims;
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
[Route("/api/orders")]
[Authorize]
public class OrderController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUriService _uriService;
    private readonly IMapper _mapper;

    public OrderController(IUnitOfWork unitOfWork, IUriService uriService, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _uriService = uriService;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginateDto<List<OrderDto>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> FindAll([FromQuery] PaginationFilter paginationFilter)
    {
        var pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
        var response = await _unitOfWork.OrderRepository.Paginate(pagination, relations: "User,OrderDetails.Product");
        var route = Request.Path.Value!;

        var orderPaginate =
            PaginationHelper.CreatePagedResponse(_mapper.Map<List<OrderDto>>(response.Data.ToList()),
                pagination, response.TotalRecord, _uriService, route);

        return CustomResult("Success", orderPaginate);
    }
    
    [HttpGet("get-order-by-user")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PaginateDto<List<OrderDto>>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
    public async Task<IActionResult> GetOrderById([FromQuery] PaginationFilter paginationFilter)
    {
        var userId = this.User.FindFirstValue("UserId");
        var pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
        var response = await _unitOfWork.OrderRepository.Paginate(pagination, predicate: o => o.UserId == userId, relations: "User,OrderDetails.Product");
        var route = Request.Path.Value!;

        var orderPaginate =
            PaginationHelper.CreatePagedResponse(_mapper.Map<List<OrderDto>>(response.Data.ToList()),
                pagination, response.TotalRecord, _uriService, route);

        return CustomResult("Success", orderPaginate);
    }

    [HttpPost("add-order")]
    public async Task<IActionResult> AddOrder([FromBody] AddOrderDto dto)
    {
        var userId = this.User.FindFirstValue("UserId");

        if (dto.OrderDetails.Count <= 0)
        {
            return CustomResult("Failed", new[] { "List product is required" }, HttpStatusCode.BadRequest);
        }

        var order = new Order()
        {
            UserId = userId,
        };

        var orderDetails = dto.OrderDetails
            .Select(detailDto => new OrderDetail()
                { OrderId = order.Id, ProductId = detailDto.ProductId, Quantity = detailDto.Quantity })
            .ToList();

        order.OrderDetails = orderDetails;

        await _unitOfWork.OrderRepository.Add(order);
        await _unitOfWork.SaveAsync();

        return CustomResult("Success", order);
    }
}