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
        public IActionResult Create(BookBorrowingRequestDTO request)
        {
            if (_requestService.CreateRequest(request))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public IActionResult Update(BookBorrowingRequestDTO request, int id)
        {
            if (_requestService.DeleteRequest(id))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_requestService.DeleteRequest(id))
            {
                return Ok();
            }
            return BadRequest();
            
        }
    }
}