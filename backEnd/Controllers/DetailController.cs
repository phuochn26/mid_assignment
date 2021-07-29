using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DetailController : ControllerBase
    {
        private readonly IBookBorrowingRequestDetailService _detailService;
        public DetailController(IBookBorrowingRequestDetailService detailService)
        {
            _detailService = detailService;
        }
        [HttpGet]
        public List<BookBorrowingRequestDetail> List()
        {
            return _detailService.GetDetails();
        }
        [HttpGet("{id}")]
        public BookBorrowingRequestDetail GetById(int id)
        {
            return _detailService.GetDetailById(id);
        }
        [HttpPost]
        public List<BookBorrowingRequestDetail> Create(BookBorrowingRequestDetailDTO request)
        {
            _detailService.CreateDetail(request);
            return _detailService.GetDetails();
        }
        [HttpPut("{id}")]
        public List<BookBorrowingRequestDetail> Update(BookBorrowingRequestDetailDTO request, int id)
        {
            _detailService.UpdateDetail(request, id);
            return _detailService.GetDetails();
        }
        [HttpDelete("{id}")]
        public List<BookBorrowingRequestDetail> Delete(int id)
        {
            _detailService.DeleteDetail(id);
            return _detailService.GetDetails();
        }
    }
}