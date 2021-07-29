using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly IBookBorrowingRequestService _requestService;
        public RequestController(IBookBorrowingRequestService requestService)
        {
            _requestService = requestService;
        }
        [HttpGet]
        public List<BookBorrowingRequest> List()
        {
            return _requestService.GetRequests();
        }
        [HttpGet("{id}")]
        public BookBorrowingRequest GetById(int id)
        {
            return _requestService.GetRequestById(id);
        }
        [HttpPost]
        public List<BookBorrowingRequest> Create(BookBorrowingRequestDTO request)
        {
            _requestService.CreateRequest(request);
            return _requestService.GetRequests();
        }
        [HttpPut("{id}")]
        public List<BookBorrowingRequest> Update(BookBorrowingRequestDTO request, int id)
        {
            _requestService.UpdateRequest(request, id);
            return _requestService.GetRequests();
        }
        [HttpDelete("{id}")]
        public List<BookBorrowingRequest> Delete(int id)
        {
            _requestService.DeleteRequest(id);
            return _requestService.GetRequests();
        }
    }
}