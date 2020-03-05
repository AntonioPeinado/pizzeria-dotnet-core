using Microsoft.AspNetCore.Mvc;
using API.Application;
using API.DTO;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateCommentDTO createCommentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var commentDetail = _commentService.Create(createCommentDTO);
            return StatusCode(201, commentDetail);
        }
    }
}
